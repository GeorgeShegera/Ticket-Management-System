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
        private User Admin { get; set; }
        public AdminWnd(User admin)
        {
            Admin = admin;
            InitializeComponent();
            lbName.Text = $"Name: {admin.Name}";
            lbSurname.Text = $"Surname: {admin.Surname}";
            lbBirthDate.Text = $"Date of Birth: {admin.DateBirth}";
            lbEmail.Text = $"Email: {admin.Email}";
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            SettingsWnd settingsWnd = new SettingsWnd(Admin);
            settingsWnd.ShowDialog();
            Admin = settingsWnd.user;
        }
    }
}
