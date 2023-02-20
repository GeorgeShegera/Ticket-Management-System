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
    public partial class AdminWnd : Form
    {
        private Administrator Admin { get; set; }
        public AdminWnd(Administrator admin)
        {
            Admin = admin;
            InitializeComponent();
            RefreshData();
            RefreshTrains();
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
            TrainWnd trainWnd = new TrainWnd(dataBase.Trains[lbTrains.SelectedIndex]);
            trainWnd.ShowDialog();
            lbTrains.SelectedIndex = -1;
            RefreshTrains();
        }
    }
}
