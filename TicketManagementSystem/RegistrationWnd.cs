using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicketManagementSystem.AuthorizationWnd;

namespace TicketManagementSystem
{
    public partial class RegistrationWnd : Form
    {
        public RegistrationWnd()
        {
            InitializeComponent();
        }

        private void btnSighUp_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text) ||
               string.IsNullOrEmpty(tbSurname.Text) ||
               string.IsNullOrEmpty(tbEmail.Text) ||
               string.IsNullOrEmpty(tbUsername.Text) ||               
               string.IsNullOrEmpty(tbPassword.Text))
            {
                ErrorMessage("You must fill in all fields");
                return;
            }
        }
    }
}
