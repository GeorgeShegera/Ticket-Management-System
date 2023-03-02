using ManagementSystemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private List<Trip> FilteredTrips { get; set; } = new List<Trip>();
        public ChooseTripWnd(Client client)
        {
            InitializeComponent();
            dtpDepartureDate.MinDate = DateTime.Now;
            dtpDepartureDate.CustomFormat = " ";
            this.client = client;
            UpcommingTrips = dataBase.GetTrips().Where(x => x.State == TripState.Upcoming).ToList();
            FilteredTrips.AddRange(UpcommingTrips);
            RefreshTrips();
        }

        private void RefreshTrips()
        {
            lbTrips.Items.Clear();
            lbTrips.Items.AddRange(FilteredTrips.Select(x => x.Name).ToArray());
        }

        private Trip GetTrip()
        {
            int index = lbTrips.SelectedIndex;
            if (index == -1) return null;
            else return UpcommingTrips[index];
        }

        private void RemoveFilters()
        {
            FilteredTrips.Clear();
            FilteredTrips.AddRange(UpcommingTrips);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Trip trip = GetTrip();
            if (trip is null)
            {
                ErrorMessage("You must select a trip");
                return;
            }
            TripWnd tripWnd = new TripWnd(trip, true);
            tripWnd.ShowDialog();
        }

        private void FilterTrips()
        {
            RemoveFilters();
            if (!string.IsNullOrEmpty(tbDeparturePlace.Text))
                FilteredTrips = FilteredTrips.Where(x => x.DeparturePlace == tbDeparturePlace.Text).ToList();
            if (!string.IsNullOrEmpty(tbArrivalPlace.Text))
                FilteredTrips = FilteredTrips.Where(x => x.ArrivalPlace == tbArrivalPlace.Text).ToList();
            if (dtpDepartureDate.CustomFormat != " ")
                FilteredTrips = FilteredTrips.Where(x => x.DepartureDate.Date == dtpDepartureDate.Value.Date).ToList();
            RefreshTrips();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FilterTrips();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpDepartureDate.CustomFormat = " ";
            tbArrivalPlace.Text = "";
            tbDeparturePlace.Text = "";
            RemoveFilters();
            RefreshTrips();
        }

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDepartureDate.CustomFormat = "dd.MM.yyyy";
        }
    }
}
