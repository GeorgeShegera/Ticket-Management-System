using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemLibrary;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class AdminWnd : Form
    {
        private Administrator Admin { get; set; }
        public AdminWnd(Administrator admin)
        {
            Admin = admin;
            InitializeComponent();
            RefreshData();
            RefreshTrains();
            RefreshClients();
        }

        private void RefreshData()
        {
            lbName.Text = $"Name: {Admin.Name}";
            lbSurname.Text = $"Surname: {Admin.Surname}";
            lbBirthDate.Text = $"Date of Birth: {Admin.DateBirth?.ToString("d")}";
            lbEmail.Text = $"Email: {Admin.Email}";
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Hide();
            SettingsWnd settingsWnd = new SettingsWnd(Admin);
            settingsWnd.ShowDialog();
            Show();
            RefreshData();
        }

        private void RefreshTrains()
        {
            lbTrains.Items.Clear();
            lbTrains.Items.AddRange(dataBase.Trains.Select(x => x.Signature).ToArray());
        }

        private void RefreshClients()
        {
            lbClients.Items.Clear();
            lbClients.Items.AddRange(dataBase.Users.Where(x => x is Client).Select(x => x.Username).ToArray());
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void tbnAddTrain_Click(object sender, EventArgs e)
        {
            AddingTrainWnd addingTrainWnd = new AddingTrainWnd();
            addingTrainWnd.ShowDialog();
            lbTrains.Items.AddRange(dataBase.Trains.Select(x => x.Name).ToArray());
            RefreshTrains();
        }

        private void btnEditTrain_Click(object sender, EventArgs e)
        {
            if (lbTrains.SelectedIndex == -1)
            {
                ErrorMessage("You must select the train");
                return;
            }
            Hide();
            TrainWnd trainWnd = new TrainWnd(dataBase.Trains[lbTrains.SelectedIndex]);
            trainWnd.ShowDialog();
            Show();
            lbTrains.SelectedIndex = -1;
            RefreshTrains();
        }

        private void btnViewCompletedTrips_Click(object sender, EventArgs e)
        {
            CompletedTripsWnd completedTripsWnd = new CompletedTripsWnd();
            Hide();
            completedTripsWnd.ShowDialog();
            Show();
        }

        private void btnApplicationInfo_Click(object sender, EventArgs e)
        {
            ApplicationInfoWnd infoWnd = new ApplicationInfoWnd();
            infoWnd.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            RegistrationWnd registration = new RegistrationWnd();
            registration.ShowDialog();
            RefreshClients();
        }

        private void BtnViewClient_Click(object sender, EventArgs e)
        {
            int index = lbClients.SelectedIndex;
            if (index == -1)
            {
                ErrorMessage("You must select a clint");
                return;
            }
            string username = lbClients.SelectedItem.ToString();
            ClientViewWnd clientViewWnd = new ClientViewWnd((Client)dataBase.GetUser(username));
            Hide();
            clientViewWnd.ShowDialog();
            lbClients.SelectedIndex = -1;
            Show();
        }
    }
}
