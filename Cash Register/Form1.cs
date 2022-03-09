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

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //global variables
        double milkprice = 2.50;
        double whiteprice = 2.50;
        double darkprice = 2.50;
        int milkpieces = 0;
        int whitepieces = 0;
        int darkpieces = 0;
        double subtotal = 0;
        double taxrate = 0.13;
        double taxamount = 0;
        double totalprice = 0;

            public Form1()
        {
            InitializeComponent();
        }

        private void calcolatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                milkpieces = Convert.ToInt32(milkinput.Text);
                whitepieces = Convert.ToInt32(whiteinput.Text);
                darkpieces = Convert.ToInt32(darkinput.Text);

                subtotal = milkprice * milkpieces + whiteprice * whitepieces + darkprice * darkpieces;
                taxamount = subtotal * taxrate;
                totalprice = subtotal + taxamount;

                subtotaloutput.Text = subtotal.ToString("C");
                taxoutput.Text = taxamount.ToString("C");
                totaloutput.Text = totalprice.ToString("C");
            }

            catch
            {
                subtotaloutput.Text = "Error";
                taxoutput.Text = "";
                totaloutput.Text = "";
            }
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            outputlable.Text = $"MY AMAZING CASH REGISTER\n\n";
            outputlable.Refresh();
            Thread.Sleep(500);

            outputlable.Text += $"{milkpieces} Milk Chocolate @{milkprice.ToString("C")}\n";
            outputlable.Refresh();
            Thread.Sleep(500);

            outputlable.Text += $"{whitepieces} White Chocolate @{whiteprice.ToString("C")}\n";
            outputlable.Refresh();
            Thread.Sleep(500);

            outputlable.Text += $"{darkpieces} Dark Chocolate @{darkprice.ToString("C")}\n\n";
            outputlable.Refresh();
            Thread.Sleep(500);

            outputlable.Text += $"Subtotal.....................................{subtotal.ToString("C")}\n";
            outputlable.Refresh();
            Thread.Sleep(500);

            outputlable.Text += $"Tax Amount...............................{taxamount.ToString("C")}\n";
            outputlable.Refresh();
            Thread.Sleep(500);

            outputlable.Text += $"Total Price.................................{totalprice.ToString("C")}\n\n";
            outputlable.Refresh();
            Thread.Sleep(500);
        }
    }
}
