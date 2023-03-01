using ManagementSystemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class ChooseTripWnd : Form
    {
        private Client client;
        private List<Trip> UpcommingTrips { get; set; }
        public ChooseTripWnd(Client client)
        {
            InitializeComponent();
            dtpDepartureDate.MinDate = DateTime.Now;
            dtpArrivalDate.MinDate = DateTime.Now;
            this.client = client;
            UpcommingTrips = dataBase.GetTrips().Where(x => x.State == TripState.Upcoming).ToList();
            lbTrips.Items.AddRange(UpcommingTrips.Select(x => x.Name).ToArray());
        }

        private Trip GetTrip()
        {
            int index = lbTrips.SelectedIndex;
            if (index == -1) return null;
            else return UpcommingTrips[index];
        }

        private void cbDepartureFilters_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox checkBox)) return;
            if (checkBox.Tag.ToString() == "Departure")
            {
                gbDepartureFilters.Visible = checkBox.Checked;
                tbDeparturePlace.Text = "";
                dtpDepartureDate.Value = DateTime.Now;
            }
            else
            {
                gbArrivalFilters.Visible = checkBox.Checked;
                tbArrivalPlace.Text = "";
                dtpArrivalDate.Value = DateTime.Now;
            }
            btnApply.Visible = cbArrivalFilters.Checked || cbDepartureFilters.Checked;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Trip trip = GetTrip();
            if(trip is null)
            {
                ErrorMessage("You must select a trip");
                return;
            }
            TripWnd tripWnd = new TripWnd(trip, true);
            tripWnd.ShowDialog();
        }
    }
}
