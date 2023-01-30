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
        public List<User> Users { get; set; }
        public AuthorizationWnd()
        {
            string json = "";
            using(FileStream stream = new FileStream("Users.json", FileMode.OpenOrCreate))
            {
                using(StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    while (!reader.EndOfStream) json += reader.ReadLine();
                }
            }
            Users = JsonConvert.DeserializeObject<List<User>>(json);
            InitializeComponent();
        }
        public void ErrorMessage(string message) => MessageBox.Show(message, "Error", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text == "" || tbPassword.Text == "")
            {
                ErrorMessage("You must fill login and password fields");
                return;
            }
        }
    }
}
