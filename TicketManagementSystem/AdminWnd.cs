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
    public partial class AdminWnd : Form
    {
        private Administrator Admin { get; set; }
        public AdminWnd(Administrator admin)
        {
            Admin = admin;
            InitializeComponent();
            RefreshData();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
