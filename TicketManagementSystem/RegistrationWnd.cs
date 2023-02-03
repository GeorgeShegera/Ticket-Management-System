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
            errorProvider.Clear();
            if (SetErrorProv()) return;
            else if (Users.Any(x => x.Username == tbUsername.Text))
            {
                ErrorMessage("This username is already taken");
                return;
            }
            NewUser = new User(tbEmail.Text, tbUsername.Text, tbPassword.Text,
                               tbName.Text, tbSurname.Text, dateTimePicker.Value);
            Close();
        }

        private bool SetErrorProv()
        {
            bool errorSet = false;
            foreach(Control control in Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    errorProvider.SetError(control, $"Field {control.Tag} must be filled");
                    errorSet = true;
                }
            }
            return errorSet;
        }
    }
}
