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

namespace TicketManagementSystem
{
    public partial class TicketWnd : Form
    {
        public TicketWnd(Ticket ticket)
        {
            InitializeComponent();
            lbStatus.Text = $"Status: {ticket.GetState()}";
            lbType.Text = $"Type: {ticket.GetTicketType()}";
            lbPrice.Text = $"Price: {ticket.Price}";
            lbId.Text = $"Id: #{ticket.Id}";
            if (ticket.IsPurchased())
            {
                lbDateOfPurchase.Text = $"Date of Purchased: {ticket.DateOfPurchase:HH:mm dd.MM.yyyy}";
                lbOwnerName.Text = $"Owner Name: {ticket.OwnerName}";
            }
            else
            {
                lbDateOfPurchase.Visible = false;
                lbOwnerName.Visible = false;
            }
        }
    }
}
