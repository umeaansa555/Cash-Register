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

        double item2Price;
        double item2Count;

        double item3Price;
        double item3Count;


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
                totalPrice = item1Count * item1Price;

                outputLabel.Text = $"{totalPrice}";
                outputLabel.Text = $" The price of {item1Count} slice(s) is {totalPrice.ToString("C")}.";
            }

            catch
            {
                outputLabel.Text = $"We can't serve {item1Box.Text} slices.";
            }
        }
    }
}
