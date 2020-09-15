using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Car Class
* Author      : Kabrina Brady
* Created     : 10/22/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User inputs the year and make of a car, and controls the speed of the car by clicking Accelerate or Brake
*               Input:  Button clicks, text input
*               Output: Text output, MessageBoxes (potentially)
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace CarClassBrady
{
    public partial class CarClassForm : Form
    {
        Car myCar = new Car(year: 0, make: "", speed: 0); //creates instance of Car class and initializes all parameters to nothing

        public CarClassForm()
        {
            InitializeComponent();
        }

        //Accelerate button
        private void Button1_Click(object sender, EventArgs e)
        {
            Accelerate(); //calls Accelerate method to increase speed

            //input validation
            try
            {
                int parsedYear = int.Parse(txtYear.Text); //parses the year
                myCar.Year = parsedYear; //sets the myCar.Year property to the year the user inputted
                myCar.Make = txtMake.Text; //sets the myCar.Make property to the make the user inputted
                lblSpeed.Text = myCar.Speed.ToString(); //converts the speed to string and displays in label
            }
            catch
            {
                MessageBox.Show("Enter a year."); //error message
            }

            //ensures speed is greater than or equal to 0
            if (myCar.Speed < 0)
            {
                myCar.Speed = 0;
                MessageBox.Show("Speed cannot be negative.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        private void Accelerate()
        {
            myCar.Speed += 5; //adds 5 to the speed
        }
        
        //Brake button
        private void BtnBrake_Click(object sender, EventArgs e)
        {
            Brake(); //calls the Brake method
            lblSpeed.Text = myCar.Speed.ToString(); //displays the speed in a label
        }

        private void Brake()
        {
            myCar.Speed -= 5; //subtracts 5 from the speed

            //ensures speed is greater than or equal to 0
            if (myCar.Speed < 0)
            {
                myCar.Speed = 0;
                MessageBox.Show("Speed cannot be negative.");
            }
        }
    }
}
