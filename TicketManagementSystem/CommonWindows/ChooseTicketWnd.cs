﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemLibrary;
using static TicketManagementSystem.Program;

namespace TicketManagementSystem
{
    public partial class ChooseTicketWnd : Form
    {
        private Client client;
        private List<Ticket> Tickets { get; set; }
        private List<Ticket> FilteredTickets { get; set; } = new List<Ticket>();
        public ChooseTicketWnd(List<Ticket> tickets, Client client)
        {
            Tickets = tickets;
            FilteredTickets.AddRange(Tickets);
            this.client = client;
            InitializeComponent();
            cbTicketType.Items.AddRange(new string[]
            {
                "",
                "Economy",
                "Middle",
                "Business"
            });
            RefreshTickets();
        }

        private void RefreshTickets()
        {
            lbTickets.Items.Clear();
            lbTickets.Items.AddRange(FilteredTickets.Select(x => x.Signature).ToArray());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbTicketType.SelectedIndex = 0;
            nudMaxPrice.Value = 0;
            nudMinPrice.Value = 0;
            RemoveFilters();
            RefreshTickets();
        }

        private void RemoveFilters()
        {
            FilteredTickets.Clear();
            FilteredTickets.AddRange(Tickets);
        }

        private TicketType GetTicketType()
        {
            if (cbTicketType.SelectedIndex == 1) return TicketType.Economy;
            else if (cbTicketType.SelectedIndex == 2) return TicketType.Middle;
            else if (cbTicketType.SelectedIndex == 3) return TicketType.Business;
            else return new TicketType();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            RemoveFilters();
            if (nudMinPrice.Value > nudMaxPrice.Value)
            {
                ErrorMessage("Minimum price must be less than maximum price");
                return;
            }
            if (cbTicketType.SelectedIndex > 0)
            {
                TicketType type = GetTicketType();
                FilteredTickets = FilteredTickets.Where(x => x.Type == type).ToList();
            }
            if (nudMinPrice.Value != 0)
                FilteredTickets = FilteredTickets.Where(x => x.Price >= (double)nudMinPrice.Value).ToList();
            if (nudMaxPrice.Value != 0)
                FilteredTickets = FilteredTickets.Where(x => x.Price <= (double)nudMaxPrice.Value).ToList();
            RefreshTickets();
        }

        private Ticket GetSelectedTicket()
        {
            int index = lbTickets.SelectedIndex;
            if (index == -1) return null;
            return FilteredTickets[index];
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Ticket ticket = GetSelectedTicket();
            if (ticket is null)
            {
                ErrorMessage("You must select a ticket");
                return;
            }
            TicketWnd ticketWnd = new TicketWnd(ticket);
            if (ticketWnd is null) return;
            ticketWnd.ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Ticket ticket = GetSelectedTicket();
            if (ticket is null)
            {
                ErrorMessage("You must select a ticket");
                return;
            }
            else if (client.Balance < ticket.Price)
            {
                ErrorMessage("You don't have enough money");
                return;
            }
            ticket.Purchase(client);
            Tickets.Remove(ticket);
            RemoveFilters();
            RefreshTickets();
            dataBase.Save();
            MessageBox.Show($"Ticket#{ticket.Id} has been bought", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
