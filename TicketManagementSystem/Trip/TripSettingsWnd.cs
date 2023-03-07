using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ManagementSystemLibrary;
using Newtonsoft.Json.Linq;
using TicketManagementSystem.Settings;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class TripSettingsWnd : Form
    {
        public Trip trip;
        private List<EditState> EditStates { get; set; } = new List<EditState>();
        public TripSettingsWnd(Trip trip)
        {
            this.trip = trip;
            InitializeComponent();
            foreach (GroupBox gb in Controls.OfType<GroupBox>())
            {
                for (int i = 0; i < gb.Controls.OfType<PictureBox>().Count(); i++)
                    EditStates.Add(EditState.Edit);
            }
            tbName.Text = trip.Name;
            cbState.Items.AddRange(new string[]
            {
                "Upcoming",
                "Canceled",
                "Happened"
            });
            cbState.SelectedIndex = 0;
            tbDeparturePlace.Text = trip.DeparturePlace;
            dtpDepartureDateTime.Value = trip.DepartureDate;
            tbArrivalPlace.Text = trip.ArrivalPlace;
            dtpArrivalDateTime.Value = trip.ArrivalDate;
            nudEconomyPrice.Value = (decimal)trip.EconomyPrice;
            nudMiddlePrice.Value = (decimal)trip.MiddlePrice;
            nudBusinessPrice.Value = (decimal)trip.BusinessPrice;
            dtpArrivalDateTime.MinDate = DateTime.Now;
            dtpDepartureDateTime.MinDate = DateTime.Now;
        }

        private TripState GetTripState() =>
            cbState.SelectedIndex == 0 ? TripState.Upcoming
                : cbState.SelectedIndex == 1 ? TripState.Canceled : TripState.Complete;

        private (int, Control, PictureBox) GetControl(object tag)
        {
            if (tag == tbName.Tag) return (0, tbName, pbName);
            else if (tag == cbState.Tag) return (1, cbState, pbState);
            else if (tag == tbDeparturePlace.Tag) return (2, tbDeparturePlace, pbDeparturePlace);
            else if (tag == dtpDepartureDateTime.Tag) return (3, dtpDepartureDateTime, pbDepartureTime);
            else if (tag == tbArrivalPlace.Tag) return (4, tbArrivalPlace, pbArrivalPlace);
            else if (tag == dtpArrivalDateTime.Tag) return (5, dtpArrivalDateTime, pbArrivalTime);
            else if (tag == nudEconomyPrice.Tag) return (6, nudEconomyPrice, pbEconomyPrice);
            else if (tag == nudMiddlePrice.Tag) return (7, nudMiddlePrice, pbMiddlePrice);
            else if (tag == nudBusinessPrice.Tag) return (8, nudBusinessPrice, pbBusinessPrice);
            else return (-1, null, null);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!(sender is PictureBox pictureBox)) return;
            (int index, Control control, _) = GetControl(pictureBox.Tag);
            EditState state = EditStates[index];
            EditStates[index] = EditState.Edit;
            bool enabled = false;
            Image image = Properties.Resources.EditImg;
            TripState tripState = GetTripState();
            switch (state)
            {
                case EditState.Edit:
                    {
                        if (pictureBox.Tag == cbState.Tag && tripState == TripState.Upcoming)
                        {
                            DialogResult result = MessageBox.Show("Tickets of the train will become canceled", "Warning",
                                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (result == DialogResult.Cancel) return;
                        }
                        if (control is NumericUpDown)
                        {
                            image = Properties.Resources.SaveImg;
                            EditStates[index] = EditState.Save;
                        }
                        else
                        {
                            EditStates[index] = EditState.Cancel;
                            image = Properties.Resources.CancelImg;
                        }
                        enabled = true;
                    }
                    break;
                case EditState.Save:
                    {
                        if (pictureBox.Tag == tbName.Tag)
                        {
                            if (dataBase.IsTakenTripName(tbName.Text))
                            {
                                Error("This name is already taken");
                                break;
                            }
                            trip.Name = control.Text;
                        }
                        else if (pictureBox.Tag == cbState.Tag) dataBase.ChangeTripState(trip, tripState);
                        else if (pictureBox.Tag == tbDeparturePlace.Tag) trip.DeparturePlace = control.Text;
                        else if (pictureBox.Tag == dtpDepartureDateTime.Tag)
                        {
                            if (dtpDepartureDateTime.Value >= trip.ArrivalDate)
                            {
                                Error("Departure date must be before arrival date");
                                break;
                            }
                            trip.DepartureDate = dtpDepartureDateTime.Value;
                        }
                        else if (pictureBox.Tag == tbArrivalPlace.Tag) trip.ArrivalPlace = control.Text;
                        else if (pictureBox.Tag == dtpArrivalDateTime.Tag)
                        {
                            if (dtpArrivalDateTime.Value <= trip.DepartureDate)
                            {
                                Error("Arrival date must be after departure date");
                                break;
                            }
                            trip.ArrivalDate = dtpArrivalDateTime.Value;
                        }
                        else if (pictureBox.Tag == nudEconomyPrice.Tag)
                        {
                            if (nudEconomyPrice.Value >= nudMiddlePrice.Value)
                            {
                                Error("Economy class price must be below the middle class price");
                                break;
                            }
                            trip.EconomyPrice = (double)nudEconomyPrice.Value;
                        }
                        else if (pictureBox.Tag == nudMiddlePrice.Tag)
                        {
                            if (nudMiddlePrice.Value >= nudBusinessPrice.Value)
                            {
                                Error("Middle class price must be below the business class price");
                                break;
                            }
                            trip.MiddlePrice = (double)nudMiddlePrice.Value;
                        }
                        else if (pictureBox.Tag == nudBusinessPrice.Tag)
                            trip.BusinessPrice = (double)nudBusinessPrice.Value;
                        dataBase.Save();
                    }
                    break;
            }
            control.Enabled = enabled;
            pictureBox.Image = image;

            void Error(string mes)
            {
                ErrorMessage(mes);
                EditStates[index] = EditState.Save;
                enabled = true;
                image = Properties.Resources.SaveImg;
            }
        }

        private void DataChange(object sender, EventArgs e)
        {
            if (!(sender is Control control)) return;
            (int index, _, PictureBox pictureBox) = GetControl(control.Tag);
            if (EditStates[index] != EditState.Cancel) return;
            bool sameData = false;
            if (control.Tag == tbName.Tag) sameData = tbName.Text == trip.Name;
            else if (control.Tag == cbState.Tag) sameData = GetTripState() == trip.State;
            else if (control.Tag == dtpDepartureDateTime.Tag) sameData = trip.DepartureDate == dtpDepartureDateTime.Value;
            else if (control.Tag == tbDeparturePlace.Tag) sameData = trip.DeparturePlace == tbDeparturePlace.Text;
            else if (control.Tag == dtpArrivalDateTime.Tag) sameData = trip.ArrivalDate == dtpArrivalDateTime.Value;
            else if (control.Tag == tbArrivalPlace.Tag) sameData = trip.ArrivalPlace == tbArrivalPlace.Text;
            if (sameData)
            {
                EditStates[index] = EditState.Cancel;
                pictureBox.Image = Properties.Resources.CancelImg;
            }
            else
            {
                EditStates[index] = EditState.Save;
                pictureBox.Image = Properties.Resources.SaveImg;
            }
        }
    }
}
