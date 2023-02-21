using ManagementSystemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManagementSystem.Settings;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TicketManagementSystem.Program;
namespace TicketManagementSystem
{
    public partial class TrainSettingsWnd : Form
    {
        private Train train;
        private List<EditState> EditStates { get; set; }
        public TrainSettingsWnd(Train train)
        {
            EditStates = new List<EditState>
            {
                EditState.Edit,
                EditState.Edit,
                EditState.Edit
            };
            this.train = train;
            InitializeComponent();
            cmState.Items.AddRange(new string[]
            {
                "Available",
                "Unavailable"
            });
            cmState.SelectedIndex = train.State == TrainState.Available ? 0 : 1;
            tbName.Text = train.Name;
            tbModel.Text = train.Model;
        }

        private TrainState GetState() 
            => cmState.SelectedIndex == 0 ? TrainState.Available : TrainState.Unavailable;

        private (int, Control) GetStateIndex(object tag)
        {
            if (tag == tbName.Tag) return (0, tbName);
            else if (tag == tbModel.Tag) return (1, tbModel);
            else if (tag == cmState.Tag) return (2, cmState);
            else return (-1, null);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!(sender is PictureBox pictureBox)) return;
            (int index, Control control) = GetStateIndex(pictureBox.Tag);
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
                        if (pictureBox.Tag == tbName.Tag) train.Name = control.Text;
                        else if (pictureBox.Tag == tbModel.Tag) train.Model = control.Text;
                        else train.State = GetState();
                        dataBase.Save();
                    }
                    break;
            }
        }

        private void Data_Changed(object sender, EventArgs e)
        {
            if(!(sender is Control control)) return;
            (int index, _) = GetStateIndex(control.Tag); 
            if (EditStates[index] == EditState.Edit) return;
            PictureBox pictureBox = null;
            bool sameData = false;
            if(control.Tag == tbName.Tag)
            {
                pictureBox = pbName;
                sameData = tbName.Text == train.Name;
            }
            else if(control.Tag == tbModel.Tag)
            {
                pictureBox = pbModel;
                sameData = tbModel.Text == train.Model;
            }
            else if(control.Tag == cmState.Tag)
            {
                pictureBox = pbState;
                sameData = GetState() == train.State;
            }
            if (sameData)
            {
                EditStates[index] = EditState.Cancel;
                pictureBox.Image = Properties.Resources.CancelImg;
            }
            else
            {
                EditStates[index] = EditState.Save;
                pictureBox.Image = Properties.Resources.SaveImg;
            }
        }
    }
}
