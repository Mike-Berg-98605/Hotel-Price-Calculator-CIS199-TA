using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2_S22
{
    public partial class Prog2Form : Form
    {
        public Prog2Form()
        {
            InitializeComponent();
        }

        private void calcCostButton_Click(object sender, EventArgs e)
        {
            //constants to hold static costs;
            const double oneStarCostFactor = 1.0;
            const double twoStarCostFactor = 1.5;
            const double threeStarCostFactor = 2.5;
            const double fourStarCostFactor = 3.0;
            const double fiveStarCostFactor = 4.0;

            const double oneGuest = 100;
            const double twoGuest = 150;
            const double threeGuest = 250;
            const double fourPlusGuests = 400;

            const double dailyRate = 100;
            const double weeklyRatePerDay = 75;
            const double monthlyRatePerDay = 25;

            //variables to hold program data
            int numGuests;
            int numNights;
            string hotelStars;
            //variables to hold cost data
            double peopleCost;
            double costPerNight;
            double nightsCost;
            double starsCostFactor;
            double totalCost;

            //gather input, and validate it

            if (int.TryParse(peopleTextBox.Text, out numGuests) && numGuests > 0 && numGuests <= 7)
            {
                if (int.TryParse(nightsTextBox.Text, out numNights) && numNights > 0)
                {
                    if (starsComboBox.SelectedIndex >= 0)
                    {
                        //assign relevant factor for number of stars
                        hotelStars = starsComboBox.Text;
                        if (hotelStars == "1")
                        {
                            starsCostFactor = oneStarCostFactor;
                        } else if (hotelStars == "2")
                        {
                            starsCostFactor = twoStarCostFactor;
                        }
                        else if(hotelStars == "3")
                        {
                            starsCostFactor = threeStarCostFactor;
                        } else if (hotelStars == "4")
                        {
                            starsCostFactor = fourStarCostFactor;
                        }
                        else
                        {
                            starsCostFactor = fiveStarCostFactor;
                        }

                        //assign relevant cost for number of guests
                        if (numGuests == 1)
                        {
                            peopleCost = oneGuest;
                        } 
                        else if (numGuests == 2)
                        {
                            peopleCost = twoGuest;
                        } 
                        else if (numGuests == 3)
                        {
                            peopleCost = threeGuest;
                        } 
                        else
                        {
                            peopleCost = fourPlusGuests;
                        }

                        // assign relevant number of nights cost
                        if (numNights < 7)
                        {
                            costPerNight = dailyRate;
                        }
                        else if (numNights < 31)
                        {
                            costPerNight = weeklyRatePerDay;
                        }
                        else
                        {
                            costPerNight = monthlyRatePerDay;
                        }

                        //calculate total cost
                        nightsCost = numNights * costPerNight;
                        totalCost = (nightsCost + peopleCost) * starsCostFactor;

                        //update form control
                        outputTextBox.Text = $"{totalCost:C}";

                    }
                    else
                    {
                        MessageBox.Show("No number of stars selected");
                    }
                }
                else 
                {
                    MessageBox.Show("Invalid Number of Nights");
                }
            }
            else
            {
                MessageBox.Show("Invalid Number of Guests");
            }


        }
    }
}
