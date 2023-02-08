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

namespace TicketManagementSystem
{
    public partial class AuthorizationWnd : Form
    {
        public static List<User> Users { get; set; }
        public static User CurUser { get; set; } = null;
        public AuthorizationWnd()
        {
            string json = "";
            using (FileStream stream = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    while (!reader.EndOfStream) json += reader.ReadLine();
            }
            Users = JsonConvert.DeserializeObject<List<User>>(json);
            if (Users is null) Users = new List<User> { new Administrator("AdminEmail@gmail.com", "admin", "admin",
                                                        "Admin", "Admin", DateTime.Now) };
            InitializeComponent();
        }
        internal static void ErrorMessage(string message) => MessageBox.Show(message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        internal void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(Users);
            using (FileStream stream = new FileStream("Users.json", FileMode.Open))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    writer.WriteLine(json);
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool notFilled = false;
            if (tbLogin.Text == "")
            {
                errorProvider.SetError(tbLogin, "Username are not specified!");
                notFilled = true;
            }
            if (tbPassword.Text == "")
            {
                errorProvider.SetError(tbPassword, "Password are not specified!");
                notFilled = true;
            }
            if (notFilled) return;
            foreach (User user in Users)
                if (user.Username == tbLogin.Text && user.Password == tbPassword.Text)
                    CurUser = user;
            if (CurUser is null)
            {
                tbPassword.Text = "";
                ErrorMessage("Incorrect login or password");
                return;
            }
            Hide();
            Form userForm;
            if (CurUser is Administrator) userForm = new AdminWnd(CurUser);
            else userForm = new AdminWnd(CurUser);
            userForm.ShowDialog();
            Show();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationWnd registrationWnd = new RegistrationWnd();
            registrationWnd.ShowDialog();
            if (!(registrationWnd.NewUser is null))
            {
                Users.Add(registrationWnd.NewUser);
                SaveUsers();
            }
        }
    }
}
