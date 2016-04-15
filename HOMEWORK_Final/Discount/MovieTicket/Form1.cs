using Discount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicket
{
    public partial class Form1 : Form
    {
        public List<Ticket> tickets;
        public ChildrenDiscount childrenDiscount = new ChildrenDiscount();
        public StudentDiscount studentDiscount = new StudentDiscount();
        public VipDiscount vipDiscount = new VipDiscount();
        private Ticket ticket = new Ticket();
        public double discount;
        public double price;
        public double totalPrice;

        public Form1()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            reset();
        }

        private void TicketCateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkValue();
            PriceTextBox.Text = string.Format("{0}", price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetBotton.Visible = false;
            SummaryButton.Visible = true;
            checkValue();
            ResultTextBox.Text = string.Empty;
            ticket = new Ticket(TicketCateComboBox.SelectedIndex, QtyComboBox.SelectedIndex + 1, discount);
            tickets.Add(ticket);
            foreach (Ticket ticket in tickets)
            {
                ResultTextBox.Text = string.Format("{0}\n", ticket)
                    + ResultTextBox.Text;
            }
            reset();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            foreach (Ticket ticket in tickets)
            {
                totalPrice += ticket.SumPrice;
            }
            ResultTextBox.Text = string.Format("總金額為:{0}\r\n", totalPrice)
                + ResultTextBox.Text;
            AddButton.Enabled = TicketCateComboBox.Enabled = QtyComboBox.Enabled
                = SummaryButton.Visible = false;
            ResetBotton.Visible = true;
        }

        private void reset()
        {
            price = ticket.StandPrice;
            discount = 1;
            TicketCateComboBox.SelectedIndex = 0;
            PriceTextBox.Text = string.Format("{0}", ticket.StandPrice);
        }

        private void checkValue()
        {
            switch (TicketCateComboBox.SelectedIndex)
            {
                case 0:
                    discount = 1;
                    price = ticket.StandPrice * discount;
                    break;

                case 1:
                    discount = vipDiscount.Calculate;
                    price = ticket.StandPrice * discount;
                    break;

                case 2:
                    discount = studentDiscount.Calculate;
                    price = ticket.StandPrice * discount;
                    break;

                case 3:
                    discount = childrenDiscount.Calculate;
                    price = ticket.StandPrice * discount;
                    break;

                default:
                    discount = 1;
                    price = ticket.StandPrice * discount;
                    break;
            }
        }

        private void ResetBotton_Click(object sender, EventArgs e)
        {
            tickets.Clear();
            ResetBotton.Visible = SummaryButton.Visible = false;
            AddButton.Enabled = TicketCateComboBox.Enabled = QtyComboBox.Enabled = true;
            ResultTextBox.Text = string.Empty;
        }
    }
}