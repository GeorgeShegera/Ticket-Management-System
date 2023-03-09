using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemLibrary;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class BalanceReplenishmentWnd : Form
    {
        private Client client;
        public BalanceReplenishmentWnd(Client client)
        {
            this.client = client;
            InitializeComponent();
            RefreshCurBalance();
        }

        private void RefreshCurBalance() => LbCurBalace.Text = $"Current Balace: {client.Balance}";

        private void BtnReplenishment_Click(object sender, EventArgs e)
        {
            client.Balance += (double)NudSum.Value;
            dataBase.Save();
            RefreshCurBalance();
            NudSum.Value = 0;            
        }
    }
}
