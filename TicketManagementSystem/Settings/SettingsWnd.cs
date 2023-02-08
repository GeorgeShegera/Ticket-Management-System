using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemLibrary;
using TicketManagementSystem.Settings;
using TextBox = System.Windows.Forms.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TicketManagementSystem.AuthorizationWnd;
namespace TicketManagementSystem
{
    public partial class SettingsWnd : Form
    {
        internal User user;
        private List<EditState> EditStates { get; set; }

        public SettingsWnd(User user)
        {
            this.user = user;
            EditStates = new List<EditState>
            {
                EditState.Edit,
                EditState.Edit,
                EditState.Edit
            };
            InitializeComponent();
            tbName.Text = user.Name;
            tbSurname.Text = user.Surname;
            dtpBirth.Value = user.DateBirth ?? DateTime.Now;
            pbName.Image = Properties.Resources.EditImg;
            pbSurname.Image = Properties.Resources.EditImg;
            pbBirthDate.Image = Properties.Resources.EditImg;
        }

        private int GetStateIndex(string tag)
        {
            switch (tag)
            {
                case "Name": return 0;
                case "Surname": return 1;
                case "BirthDate": return 2;
                default: return -1;
            }
        }
        private void Edit_Changed(object sender, EventArgs e)
        {
            if (!(sender is PictureBox pictureBox)) return;
            string tag = (string)pictureBox.Tag;
            Control control = null;
            int index = GetStateIndex(tag);
            switch (tag)
            {
                case "Name":
                    control = tbName;
                    break;
                case "Surname":
                    control = tbSurname;
                    break;
                case "BirthDate":
                    control = dtpBirth;
                    break;
            }
            EditState state = EditStates[index];
            EditStates[index] = EditState.Edit;
            control.Enabled = false;
            pictureBox.Image = Properties.Resources.EditImg;
            switch (state)
            {
                case EditState.Edit:
                    {
                        EditStates[index] = EditState.Cancel;
                        control.Enabled = true;
                        pictureBox.Image = Properties.Resources.CancelImg;
                    }
                    break;
                case EditState.Save:
                    {
                        switch (tag)
                        {
                            case "Name":
                                user.Name = control.Text;
                                break;
                            case "Surname":
                                user.Surname = control.Text;
                                break;
                            case "BirthData":
                                user.DateBirth = (control as DateTimePicker).Value;
                                break;
                        }
                    }
                    break;
            }
        }

        private void AccountData_Changed(object sender, EventArgs e)
        {
            string tag = (string)(sender as Control).Tag;
            int index = GetStateIndex(tag);
            if (EditStates[index] != EditState.Cancel) return;
            PictureBox pictureBox = null;
            switch (tag)
            {
                case "Name":
                    pictureBox = pbName;
                    break;
                case "Surname":
                    pictureBox = pbSurname;
                    break;
                case "BirthDate":
                    pictureBox = pbBirthDate;
                    break;
            }
            EditStates[index] = EditState.Save;  
            pictureBox.Image = Properties.Resources.SaveImg;
        }

        private void Visible_Click(object sender, EventArgs e)
        {
            string tag = (string)(sender as Control).Tag;
            TextBox textBox = tag == "OldPass" ? tbOldPass : tbNewPass;
            PictureBox pictureBox = tag == "OldPass" ? pbOldPass : pbNewPass;
            textBox.UseSystemPasswordChar = !textBox.UseSystemPasswordChar;
            if (textBox.UseSystemPasswordChar) pictureBox.Image = Properties.Resources.HiddenImg;
            else pictureBox.Image = Properties.Resources.VisibleImg;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOldPass.Text) ||
               string.IsNullOrEmpty(tbNewPass.Text))
            {
                ErrorMessage("You must fill all the fields");
                return;
            }
            else if (tbOldPass.Text != user.Password)
            {
                ErrorMessage("Wrong password");
                return;
            }
            else if (tbOldPass.Text == tbNewPass.Text)
            {
                ErrorMessage("New password must differ");
                return;
            }
        }
    }
}
