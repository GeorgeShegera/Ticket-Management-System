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
            lbBalance.Text = $"Balance: {client.Balance}";            
            Tickets = dataBase.GetTickets(client.Username);
            lbTickets.Items.AddRange(Tickets.Select(x => x.Signature).ToArray());
        }
    }
}
