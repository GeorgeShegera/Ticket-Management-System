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
    public partial class TripWnd : Form
    {
        private readonly Trip trip;
        public TripWnd(Trip trip, bool viewOnly = false)
        {
            this.trip = trip;
            InitializeComponent();
            btnTripSettings.Visible = trip.State == TripState.Upcoming && !viewOnly;
            RefreshData();
        }
        private void RefreshData()
        {
            lbName.Text = $"Name: {trip.Name}";
            lbState.Text = $"Status: {trip.GetState()}";
            lbDepartureTime.Text = $"Departure Time: {trip.DepartureDate:HH:mm, dd.MM.yyyy}";
            lbDeparturePlace.Text = $"Departure Place: {trip.DeparturePlace}";
            lbArrivalTime.Text = $"Arrival Time: {trip.ArrivalDate:HH:mm, dd.MM.yyyy}";
            lbArrivalPlace.Text = $"Arrival Place: {trip.ArrivalPlace}";
            lbEconomyPrice.Text = $"Economy class price: {trip.EconomyPrice}";
            lbMiddlePrice.Text = $"Middle class price: {trip.MiddlePrice}";
            lbBusinessPrice.Text = $"Business class price:  {trip.BusinessPrice}";
            lbTickets.Items.Clear();
            lbTickets.Items.AddRange(trip.Tickets.Select(x => x.SignatureState).ToArray());
        }
        private void btnTripSettings_Click(object sender, EventArgs e)
        {
            TripSettingsWnd tripSettings = new TripSettingsWnd(trip);
            tripSettings.ShowDialog();
            RefreshData();
        }
    }
}
