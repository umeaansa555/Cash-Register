using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double item1Price = 3.25;
        double item1Count;

        double item2Price = 1.00;
        double item2Count;

        double item3Price = 2.00;
        double item3Count;


        double subtotalPrice;
        double taxRate = 0.13;
        double taxAmount;
        double totalPrice;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                item1Count = Convert.ToInt32(item1Box.Text);
                item2Count = Convert.ToInt32(item2Box.Text);
                item3Count = Convert.ToInt32(item3Box.Text);
                subtotalPrice = (item1Count * item1Price) + (item2Count * item2Price) + (item3Count * item3Price);
                taxAmount = subtotalPrice * taxRate;
                totalPrice = subtotalPrice + taxAmount;


                outputLabel.Text = $" Subtotal: {subtotalPrice.ToString("C")}.";
                outputLabel.Text += $" Tax: {taxAmount.ToString("C")}."; 
                outputLabel.Text += $" Total: {totalPrice.ToString("C")}.";
            }

            catch
            {
                outputLabel.Text = $"Please enter a value in each field. (can be 0)";
            }
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {
            recieptLabel.Visible = true;
            recieptLabel.Text = "Reciept";
            recieptLabel.Text += $"\n item 1 x{item1Count}";

            Refresh();
            Thread.Sleep(1000);


        }
    }
}
