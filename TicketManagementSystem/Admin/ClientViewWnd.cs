using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemLibrary;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class ClientViewWnd : Form
    {
        public Client client;
        public List<Ticket> Tickets { get; set; }

        public ClientViewWnd(Client client)
        {
            this.client = client;
            InitializeComponent();
            lbName.Text = $"Name: {client.Name}";
            lbSurname.Text = $"Surmane: {client.Surname}";
            lbBirthDate.Text = $"Birth Date: {client.DateBirth:dd.MM.yyyy}";
            lbEmail.Text = $"Email: {client.Email}";
            RefreshData();
        }



        private void RefreshData()
        {
            lbBalance.Text = $"Balance: {client.Balance}";
            Tickets = dataBase.GetTickets(client.Username);
            lbTickets.Items.Clear();
            lbTickets.Items.AddRange(Tickets.Select(x => x.Signature).ToArray());
        }

        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            ChooseTripWnd chooseTrip = new ChooseTripWnd(client);
            Hide();
            dataBase.RefreshTrips();
            chooseTrip.ShowDialog();
            Show();
            RefreshData();
        }

        private void btnViewTicket_Click(object sender, EventArgs e)
        {
            int index = lbTickets.SelectedIndex;
            if (index == -1)
            {
                ErrorMessage("You must select a ticket");
                return;
            }
            TicketWnd ticketWnd = new TicketWnd(Tickets[index]);
            ticketWnd.ShowDialog();
        }

        private void btnCancelTcket_Click(object sender, EventArgs e)
        {
            int index = lbTickets.SelectedIndex;
            if (index == -1)
            {
                ErrorMessage("You must select a ticket");
                return;
            }
            else if (Tickets[index].State != TicketState.Purchased)
            {
                ErrorMessage("This ticket can't be canceled");
                return;
            }
            MessageBox.Show("Ticket has been successfully canceled", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.ChangeTicketState(Tickets[index], TicketState.Canceled);
            dataBase.Save();
            RefreshData();
        }
    }
}
