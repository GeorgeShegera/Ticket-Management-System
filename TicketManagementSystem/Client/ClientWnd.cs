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
    public partial class ClientWnd : Form
    {
        private Client client;
        private List<Ticket> ActiveTickets { get; set; }
        public ClientWnd(Client client)
        {
            this.client = client;
            InitializeComponent();
            RefreshData();
            RefreshTickets();
        }

        private void RefreshData()
        {
            lbName.Text = $"Name: {client.Name}";
            lbSurname.Text = $"Surname: {client.Surname}";
            lbEmail.Text = $"Email: {client.Email}";
            lbDataOfBirth.Text = $"Date of Birth: {client.DateBirth:dd.MM.yyyy}";
            lbBalance.Text = $"Balance: {client.Balance}";
        }

        private void RefreshTickets()
        {
            ActiveTickets = dataBase.GetTickets(client.Username);
            lbActiveTickets.Items.Clear();
            lbActiveTickets.Items.AddRange(ActiveTickets.Where(x => x.State == TicketState.Purchased)
                                                  .Select(x => x.Signature).ToArray());
        }

        private void BtnApplicationInfo_Click(object sender, EventArgs e)
        {
            ApplicationInfoWnd applicationInfo = new ApplicationInfoWnd();
            applicationInfo.ShowDialog();
        }

        private void BtnBalanceReplenishment_Click(object sender, EventArgs e)
        {
            BalanceReplenishmentWnd balanceReplenishment = new BalanceReplenishmentWnd(client);
            balanceReplenishment.ShowDialog();
            RefreshData();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Hide();
            SettingsWnd settingsWnd = new SettingsWnd(client);
            settingsWnd.ShowDialog();
            RefreshData();
            Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnViewTicket_Click(object sender, EventArgs e)
        {
            int index = lbActiveTickets.SelectedIndex;
            if (index == -1)
            {
                ErrorMessage("You must select a ticket");
                return;
            }
            TicketWnd ticketWnd = new TicketWnd(ActiveTickets[index]);
            ticketWnd.ShowDialog();
        }

        private void BtnBuyTicket_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseTripWnd chooseTrip = new ChooseTripWnd(client);
            chooseTrip.ShowDialog();
            Show();
            RefreshTickets();
        }

        private void BtnCancelTicket_Click(object sender, EventArgs e)
        {
            int index = lbActiveTickets.SelectedIndex;
            if (index == -1)
            {
                ErrorMessage("You must select a ticket");
                return;
            }
            dataBase.ChangeTicketState(ActiveTickets[index], TicketState.Canceled);
            RefreshTickets();
            MessageBox.Show("Ticket has been canceled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
