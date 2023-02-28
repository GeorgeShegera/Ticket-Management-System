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
    public partial class CompletedTripsWnd : Form
    {
        private List<Trip> CompletedTrips;
        public CompletedTripsWnd()
        {
            InitializeComponent();
            CompletedTrips = dataBase.GetCompletedTrips();
            lbCompletedTrips.Items.AddRange(CompletedTrips.Select(x => x.Signature).ToArray());
        }

        private void btnViewTrip_Click(object sender, EventArgs e)
        {
            int index = lbCompletedTrips.SelectedIndex;
            if (index == -1)
            {
                ErrorMessage("You must select a trip");
                return;
            }
            TripWnd tripWnd = new TripWnd(CompletedTrips[index]);
            Hide();
            tripWnd.ShowDialog();
            Show();
        }
    }
}
