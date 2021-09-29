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
        double item1Total;

        double item2Price = 1.00;
        double item2Count;
        double item2Total;

        double item3Price = 2.00;
        double item3Count;
        double item3Total;

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

                item1Total = item1Count * item1Price;
                item2Total = item2Count * item2Price;
                item3Total = item3Count * item3Price;

                subtotalPrice = item1Total + item2Total + item3Total;
                taxAmount = subtotalPrice * taxRate;
                totalPrice = subtotalPrice + taxAmount;


                outputLabel.Text = $"Subtotal: {subtotalPrice.ToString("C")}.";
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
            recieptLabel.Text += $"\n item 1 x{item1Count} {item1Total.ToString("C")}";
            recieptLabel.Text += $"\n item 2 x{item2Count} {item2Total.ToString("C")}";
            recieptLabel.Text += $"\n item 3 x{item3Count} {item3Total.ToString("C")}";

        }
    }
}
