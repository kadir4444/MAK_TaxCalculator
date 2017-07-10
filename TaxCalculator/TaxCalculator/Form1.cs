using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            cmbCountry.Text = "";
            lblTaxOutput.Text = "#################";
        }

        int Amount;
        int tax;
        String Country;
        double rate;
        double CountryTax;
        String total;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text != "")
                {
                    Amount = Convert.ToInt32(txtAmount.Text);
                    Country = cmbCountry.Text;

                    switch (Country)
                    {
                        case "United Kingdom":
                            if (Amount <= 11500)
                            {
                                rate = 0;
                            }
                            else if (Amount >= 11501 && Amount <= 45000)
                            {
                                rate = 20;
                            }
                            else if (Amount >= 45001 && Amount <= 150000)
                            {
                                rate = 40;
                            }
                            else if (Amount > 150000)
                            {
                                rate = 45;
                            }
                            CountryTax = Amount - (Amount / rate);
                            total = Convert.ToString(CountryTax);
                            lblTaxOutput.Text = "Tax Due: " + total;
                            break;

                        case "USA":
                            if (Amount <= 9325)
                            {
                                rate = 10;
                            }
                            else if (Amount >= 9326 && Amount <= 37950)
                            {
                                rate = 15;
                            }
                            else if (Amount >= 37951 && Amount <= 91900)
                            {
                                rate = 25;
                            }
                            else if (Amount >= 91901 && Amount <= 191650)
                            {
                                rate = 28;
                            }
                            else if (Amount >= 191651 && Amount <= 416700)
                            {
                                rate = 33;
                            }
                            else if (Amount >= 416701 && Amount <= 418400)
                            {
                                rate = 35;
                            }
                            else if (Amount > 418400)
                            {
                                rate = 39.6;
                            }
                            CountryTax = Amount - (Amount / rate);
                            total = Convert.ToString(CountryTax);
                            lblTaxOutput.Text = "Tax Due: " + total;
                            break;
                        case "China":
                            //Enter deetss
                            if (Amount < 1500)
                            {
                                rate = 2.5;
                            }
                            else if (Amount >= 9326 && Amount <= 37950)
                            {
                                rate = 15;
                            }
                            else if (Amount >= 37951 && Amount <= 91900)
                            {
                                rate = 25;
                            }
                            else if (Amount >= 91901 && Amount <= 191650)
                            {
                                rate = 28;
                            }
                            else if (Amount >= 191651 && Amount <= 416700)
                            {
                                rate = 33;
                            }
                            else if (Amount >= 416701 && Amount <= 418400)
                            {
                                rate = 35;
                            }
                            else if (Amount > 418400)
                            {
                                rate = 39.6;
                            }
                            break;
                        case "France":
                            lblTaxOutput.Text = "g";
                            break;
                        case "Germany":
                            lblTaxOutput.Text = "h";
                            break;
                        case "Brazil":
                            lblTaxOutput.Text = "i";
                            break;
                        case "Japan":
                            lblTaxOutput.Text = "j";
                            break;
                        case "India":
                            lblTaxOutput.Text = "k";
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Populate the Amount with currency");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR Message: " + ex);
            }
        }
    }
}
