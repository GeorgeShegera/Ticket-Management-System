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
            this.client = client;
            UpcommingTrips = dataBase.GetTrips().Where(x => x.State == TripState.Upcoming).ToList();
            lbTrips.Items.AddRange(UpcommingTrips.Select(x => x.Name).ToArray());
        }
    }
}
