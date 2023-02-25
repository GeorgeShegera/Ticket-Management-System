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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class AddingTrainWnd : Form
    {
        private readonly List<TextBox> textBoxes;
        private readonly List<NumericUpDown> numericUpDowns;
        public AddingTrainWnd()
        {
            InitializeComponent();
            textBoxes = new List<TextBox>
            {
                tbName,
                tbModel
            };
            numericUpDowns = new List<NumericUpDown>
            {
                numBusinessTick,
                numEconomyTick,
                numMiddleTick
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (dataBase.IsTakenTrainName(tbName.Text))
            {
                errorProvider.SetError(tbName, "This name is already taken");
                return;
            }
            bool error = false;
            int tickets = 0;
            foreach(TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    errorProvider.SetError(textBox, "This field must be filled");
                    error = true;
                }
                else if (textBox is TextBox && textBox.Text.Length > 10)
                {
                    errorProvider.SetError(textBox, "Must be less than 10 characters");
                    error = true;
                }
            }
            if (error) return;
            foreach (NumericUpDown numeric in numericUpDowns) tickets += (int)numeric.Value;            
            if(tickets == 0)
            {
                ErrorMessage("There must be at least one seat");
                return;
            }
            dataBase.AddTrain(new Train(tbName.Text, tbModel.Text, (int)numBusinessTick.Value,
                                       (int)numMiddleTick.Value, (int)numEconomyTick.Value));
            Close();
        }
    }
}
