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
    public partial class TripCreatingWnd : Form
    {
        private readonly Train train;
        private readonly List<TextBox> textBoxes;
        public TripCreatingWnd(Train train)
        {
            InitializeComponent();
            this.train = train;
            textBoxes = new List<TextBox>
            {
                tbName,
                tbArrivalPlace,
                tbDepaturePlace
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (numEconomyPrice.Value >= numMiddlePrice.Value)
            {
                errorProvider.SetError(numEconomyPrice, "Economy price must less than Middle price");
                return;
            }
            else if (numMiddlePrice.Value >= numBusinessPrice.Value)
            {
                errorProvider.SetError(numMiddlePrice, "Middle price must less than Business price");
                return;
            }
            else if (dtpDepatureTime.Value > dtpArrivalDate.Value)
            {
                errorProvider.SetError(dtpDepatureTime, "Depature time must be less than arrival");
                return;
            }
            bool error = false;
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    errorProvider.SetError(textBox, "Field must be filled");
                    error = true;
                }
                else if (textBox.Text.Length > 15)
                {
                    errorProvider.SetError(textBox, "Name must less than 15 symbols");
                    error = true;
                }
            }
            if (error) return;
            List<Ticket> tickets = new List<Ticket>();
            TicketType ticketType = TicketType.Economy;
            for (int i = 0; i < train.EconCapacity + train.BusCapacity + train.MidCapacity; i++)
            {
                if (i >= train.EconCapacity) ticketType = TicketType.Middle;
                else if (i >= train.EconCapacity + train.EconCapacity) ticketType = TicketType.Business;
                tickets.Add(new Ticket(ticketType, dtpDepatureTime.Value));
            }
            Trip trip = new Trip(tbName.Text, dtpDepatureTime.Value, tbDepaturePlace.Text,
                                dtpDepatureTime.Value, tbArrivalPlace.Text, (double)numEconomyPrice.Value,
                                (double)numMiddlePrice.Value, (double)numBusinessPrice.Value, tickets);
            train.Trips.Add(trip);
            dataBase.Save();
            Close();
        }
    }
}
