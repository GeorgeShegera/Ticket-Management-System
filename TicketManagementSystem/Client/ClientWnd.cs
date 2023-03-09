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
        private List<Ticket> Tickets { get; set; }
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
            lbBalance.Text = $"Balance: {client.Balance}";
        }

        private void RefreshTickets()
        {
            Tickets = dataBase.GetTickets(client.Username);
            lbActiveTickets.Items.Clear();
            lbActiveTickets.Items.AddRange(Tickets.Where(x => x.State == TicketState.Purchased)
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
    }
}
