using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double item1Price = 3.25;
        double item1Count = 0;
        double item1Total = 0;

        double item2Price = 1.00;
        double item2Count = 0;
        double item2Total = 0;

        double item3Price = 2.00;
        double item3Count = 0;
        double item3Total = 0;

        double subtotalPrice = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double totalPrice = 0;

        double tender = 0;
        double change = 0;


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


                subtotalLabel.Text = $"Subtotal: {subtotalPrice.ToString("C")}.";
                taxLabel.Text = $" Tax: {taxAmount.ToString("C")}."; 
                totalLabel.Text = $" Total: {totalPrice.ToString("C")}.";

                changeButton.Enabled = true;
                
            }

            catch
            {
                outputLabel.Text = $"Please enter a value in each field. (can be 0)";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tender = Convert.ToDouble(changeBox.Text);
            change = tender - totalPrice;

            changeLabel.Text = $"Change: {change.ToString("C")}";
            recieptButton.Enabled = true;

        }
        private void recieptButton_Click(object sender, EventArgs e)
        {


                SoundPlayer recieptPlayer = new SoundPlayer(Properties.Resources.recieptsound);
                recieptPlayer.Play();
                recieptLabel.Visible = true;
                recieptLabel.Text = "Reciept";
                Refresh();
                Thread.Sleep(1000);

                recieptLabel.Text += $"\n item 1 x{item1Count} {item1Total.ToString("C")}";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);

                recieptLabel.Text += $"\n item 2 x{item2Count} {item2Total.ToString("C")}";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);

                recieptLabel.Text += $"\n item 3 x{item3Count} {item3Total.ToString("C")}";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);

                recieptLabel.Text += $"\n\nSubtotal {subtotalPrice.ToString("C")}";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);

                recieptLabel.Text += $"\nTotal {totalPrice.ToString("C")}";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);

                recieptLabel.Text += $"\n\nTendered {tender.ToString("C")}";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);

                recieptLabel.Text += $"\nChange {change.ToString("C")}";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);



                recieptLabel.Text += $"\n\n Thanks for shopping at CashRegister!";
                recieptPlayer.Play();
                Refresh();
                Thread.Sleep(1000);
            
        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
