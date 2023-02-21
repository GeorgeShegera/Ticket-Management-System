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
using static System.Windows.Forms.AxHost;

namespace TicketManagementSystem
{
    public partial class TrainWnd : Form
    {
        private readonly Train train;
        public TrainWnd(Train train)
        {
            this.train = train;
            InitializeComponent();
            RefreshData();
            lbBusinessSeats.Text = $"Business class seats: {train.BusCapacity}";
            lbMiddleSeats.Text = $"Middle class seats: {train.MidCapacity}";
            lbEconomySeats.Text = $"Economy class seats: {train.EconCapacity}";
            RefreshTrips();
        }

        public void RefreshData()
        {
            lbName.Text = $"Name: {train.Name}";
            lbModel.Text = $"Model: {train.Model}";
            lbState.Text = $"Status: {train.GetState()}";
        }

        public void RefreshTrips()
        {
            lbTrips.Items.Clear();
            lbTrips.Items.AddRange(train.Trips.Select(x => x.Signature).ToArray());
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            TripCreatingWnd tripCreatingWnd = new TripCreatingWnd(train);
            tripCreatingWnd.ShowDialog();
            RefreshTrips();
        }

        private void btnTrainSettings_Click(object sender, EventArgs e)
        {
            TrainSettingsWnd settings = new TrainSettingsWnd(train);
            settings.ShowDialog();
            RefreshData();
        }
    }
}
