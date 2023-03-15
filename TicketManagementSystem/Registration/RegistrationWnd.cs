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
using ManagementSystemLibrary;
using System.Text.RegularExpressions;
using static TicketManagementSystem.Program;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TicketManagementSystem
{
    public partial class RegistrationWnd : Form
    {
        public RegistrationWnd()
        {
            InitializeComponent();
            dateTimePicker.MaxDate = DateTime.Now;
        }

        private void btnSighUp_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (SetErrorProv()) return;
            else if (dataBase.IsTakenUsername(tbUsername.Text))
            {
                ErrorMessage("This username is already taken");
                return;
            }
            else if(dataBase.IsTakenEmail(tbEmail.Text))
            {
                ErrorMessage("This email is already taken");
                return;
            }
            dataBase.AddUser(new Client(tbEmail.Text, tbUsername.Text, tbPassword.Text,
                                        tbName.Text, tbSurname.Text, dateTimePicker.Value));
            Close();
        }

        private bool SetErrorProv()
        {
            bool errorSet = false;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        errorProvider.SetError(control, $"Field {control.Tag} must be filled");
                        errorSet = true;
                    }
                    else if (control.Tag.ToString() == "Email" && !ValidEmail(control.Text))
                    {
                        errorProvider.SetError(control, "Incorrect email");
                        errorSet = true;
                    }
                }
            }
            return errorSet;
        }
        private bool ValidEmail(string email)
        {
            string strRegex = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            return re.IsMatch(email);
        }
    }
}
