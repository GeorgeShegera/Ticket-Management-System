using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManagementSystem
{
    public partial class TripCreatingWnd : Form
    {
        public TripCreatingWnd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (dtpDepatureTime.Value > dtpArrivalDate.Value)
            {
                errorProvider.SetError(dtpDepatureTime, "Depature time must be less than arrival");
                return;
            }
            bool error = false;
            foreach(Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        errorProvider.SetError(textBox, "Field must be filled");
                        error = true;
                    }
                    else if(textBox.Text.Length > 15)
                    {
                        errorProvider.SetError(textBox, "Name must less than 15 symbols");
                        error = true;
                    }
                }
            }
            if (error) return;
        }
    }
}
