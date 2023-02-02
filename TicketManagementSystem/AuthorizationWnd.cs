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
        public User CurUser { get; set; } = null;
        public AuthorizationWnd()
        {
            string json = "";
            using (FileStream stream = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    while (!reader.EndOfStream) json += reader.ReadLine();
                }
            }
            Users = JsonConvert.DeserializeObject<List<User>>(json);
            if (Users is null) Users = new List<User>();
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
            if (tbLogin.Text == "" || tbPassword.Text == "")
            {
                ErrorMessage("You must fill login and password fields");
                return;
            }
            foreach (User user in Users)
            {
                if (user.Username == tbLogin.Text && user.Password == tbPassword.Text)
                    CurUser = user;
            }
            if (CurUser is null)
            {
                ErrorMessage("Incorrect login or password");
                return;
            }            
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
