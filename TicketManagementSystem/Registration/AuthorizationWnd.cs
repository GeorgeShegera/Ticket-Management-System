using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemLibrary;
using Newtonsoft.Json;
using TicketManagementSystem;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class AuthorizationWnd : Form
    {
        public AuthorizationWnd()
        {
            LoadDataBase();
            if (dataBase.Users.Count == 0)
                dataBase.AddUser(new Administrator("AdminEmail@gmail.com", "admin",
                                                   "admin", "Admin", "Admin", DateTime.Now));
            List<User> clients = dataBase.Users.Where(x => x is Client y && y.Balance == 0).ToList();
            foreach (Client client in clients)
                client.Balance = 1000;
            dataBase.RefreshTrips();
            InitializeComponent();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool notFilled = false;
            if (tbUsername.Text == "")
            {
                errorProvider.SetError(tbUsername, "Username are not specified!");
                notFilled = true;
            }
            if (tbPassword.Text == "")
            {
                errorProvider.SetError(tbPassword, "Password are not specified!");
                notFilled = true;
            }
            if (notFilled) return;
            User newUser = new User(tbUsername.Text, tbPassword.Text);
            foreach (User user in dataBase.Users)
                if (user == newUser) curUser = user;
            if (curUser is null)
            {
                tbPassword.Text = "";
                ErrorMessage("Wrong login or password");
                return;
            }
            Hide();
            Form userForm;
            if (curUser is Administrator admin) userForm = new AdminWnd(admin);
            else userForm = new ClientWnd(curUser as Client);
            userForm.ShowDialog();
            curUser = null;
            tbUsername.Text = "";
            tbPassword.Text = "";
            Refresh();
            Show();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegistrationWnd().ShowDialog();
        }
    }
}
