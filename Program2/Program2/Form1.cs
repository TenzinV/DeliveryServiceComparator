//Program 2
//CIS 199-01
//Due: 3-11-2021
//By: R2889

//This program prompts the user to enter values and calculates the cost of three companies based on what
//each company charges. The program will tell the user which company is the cheapest after displaying all
//three prices.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class deliveryCost : Form
    {
        public deliveryCost()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            const int compAPeople = 1; //per person fee company a charges
            const double compADistance = .02; //distance fee for company a 
            const double compBDistance = .10; //distance fee for company b
            const double compCPeople = .25; //per person fee for company c
            const int compCDelivery = 20; //delivery fee for company c

            int people; //int for the number of people the user entered 
            double distance; //double for the distance the user entered
            int delivery; //int for the number of days the user entered

            double compA; //will be used for total cost of company a
            double compB; //will be used for total cost of company b
            double compC; //will be used for total cost of company c

            int compADays = 0; //int to help calculate delivery fee for company a
            double compBPeople = 0; //double to help calculate person fee for company b
            double compBDelivery = 0; //double to hlep calculate delivery fee for company b
            int compCDistance = 0; //int to help calcute additional delivery fee  for company c
            //tryparses each of the inputs to check whether the user entered valid information
            if (int.TryParse(peopleInput.Text, out people))
            {
                if (double.TryParse(distanceInput.Text, out distance))
                {
                    if (int.TryParse(deliveryInput.Text, out delivery))
                    {
                        //checks the delivery and inputs the according fees 
                        if (delivery == 1)
                            compADays = 20;
                        if (delivery == 2)
                            compADays = 17;
                        if (delivery == 3)
                            compADays = 15;
                        if (delivery >= 4 && delivery <= 7)
                            compADays = 10;
                        if (delivery > 7)
                            compADays = 7;
                        //calculates the total cost of company a 
                        compA = (people * compAPeople) + (distance * compADistance) + compADays;
                        //checks the people and delivery and inputs the according fees
                        if (people < 10)
                            compBPeople = 20;
                        if (people >= 10 && people < 50)
                            compBPeople = 10;
                        if (people >= 50 && people < 100)
                            compBPeople = 5;
                        if (people >= 100 && people < 200)
                            compBPeople = 3;
                        if (people >= 200)
                        {
                            compBPeople = .15;
                        }
                        if (delivery >= 1 && delivery < 4)
                            compBDelivery = 10;
                        if (delivery > 4)
                            compBDelivery = 7;
                        //calculates the total cost of company b
                        compB = (people * compBPeople) + (distance * compBDistance) + compBDelivery;
                        //checks the distance entered and adds the according fee 
                        if (distance >= 1000)
                            compCDistance = 40;
                        if (distance >= 750 && distance < 1000)
                            compCDistance = 35;                 
                        if (distance >= 500 && distance < 750)
                            compCDistance = 25;
                        if (distance >= 200 && distance < 500)
                            compCDistance = 15;
                        if (distance >= 0 && distance < 200)
                            compCDistance = 10;
                        //calculates the toal cost of company c
                        compC = (people * compCPeople) + compCDistance + compCDelivery;
                        //outputs the total cost of each company
                        compAOut.Text = $"{compA:c}";
                        compBOut.Text = $"{compB:c}";
                        compCOut.Text = $"{compC:c}";
                        //outputs which company is the cheapest of the three
                        if (compA < compB && compA < compC)
                            resultOut.Text = "The lowest company is: A";
                        if (compB < compA && compB < compC)
                            resultOut.Text = "The lowest company is: B";
                        if (compC < compA && compC < compB)
                            resultOut.Text = "The lowest company is: C";
                    }
                    else
                        MessageBox.Show("Invalid Delivery Days"); //tells the user the delivery days is wrong
                }
                else
                    MessageBox.Show("Invalid Distance"); //tells the user the distance is wrong
            }
            else
                MessageBox.Show("Invalid Number of People"); //tells the user the number of people is wrong
        }
    }
}
