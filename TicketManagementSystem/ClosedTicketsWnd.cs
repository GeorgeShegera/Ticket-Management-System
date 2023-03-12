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
    public partial class ClosedTicketsWnd : Form
    {        
        private List<Ticket> ClosedTickets { get; }
        public ClosedTicketsWnd(List<Ticket> tickets)
        {            
            ClosedTickets = tickets;
            InitializeComponent();
            lbTickets.Items.AddRange(tickets.Select(x => x.Signature).ToArray());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int index = lbTickets.SelectedIndex;
            if(index == -1)
            {
                ErrorMessage("You must select ticket");
                return;
            }
            TicketWnd ticketWnd = new TicketWnd(ClosedTickets[index]);
            ticketWnd.ShowDialog();
        }
    }
}
