using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using static TicketManagementSystem.AuthorizationWnd;
using ManagementSystemLibrary;

namespace TicketManagementSystem
{
    public partial class RegistrationWnd : Form
    {
        internal User NewUser { get; set; } = null;
        public RegistrationWnd()
        {
            InitializeComponent();
        }

        private void btnSighUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) ||
               string.IsNullOrEmpty(tbSurname.Text) ||
               string.IsNullOrEmpty(tbEmail.Text) ||
               string.IsNullOrEmpty(tbUsername.Text) ||
               string.IsNullOrEmpty(tbPassword.Text))
            {
                ErrorMessage("You must fill in all fields");
                return;
            }
            else if (Users.Any(x => x.Username == tbUsername.Text))
            {
                ErrorMessage("This username is already taken");
                return;
            }
            NewUser = new User(tbEmail.Text, tbUsername.Text, tbPassword.Text,
                               tbName.Text, tbSurname.Text, (int)numAge.Value);
            Close();
        }
    }
}
