//A7793
//Program 2
//Due on October 23rd at 11:59
//CIS 199-01
//This GUI Form allows a user to select their class grade and type the last initial of their last name
//to determine the earliest time they can register for classes in the spring




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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            
               
            //variables for day, time and letters
            string day = "Error";
            string time = "Error";
            char letter;
            




            //allowing the user to input first letter of last name
            letter = Convert.ToChar(nameTextBox.Text);
            Char.ToUpper(letter);



            //constant days 
            const string SENIOR_DAY = "Nov. 3rd";
            const string JUNIOR_DAY = "Nov. 6th";
            const string SOPHOMORE_DAY1 = "Nov. 7th";
            const string SOPHOMORE_DAY2 = "Nov. 8th";
            const string FRESHMAN_DAY1 = "Nov. 9th";
            const string FRESHMAN_DAY2 = "Nov. 10th";

            //constant times 
            const string TIME_830 = "8:30";
            const string TIME_10 = "10:00";
            const string TIME_11 = "11:30";
            const string TIME_2 = "2:00";
            const string TIME_4 = "4:00";


            //Days for Juniors and Seniors
            if (seniorButton.Checked)
                day = SENIOR_DAY;
            else
                day = JUNIOR_DAY;

            //times for juniors and seniors
            if (seniorButton.Checked || juniorButton.Checked)
            {
                if (letter <= 'D')
                    time = TIME_10;
                else
                    if (letter <= 'I')
                    time = TIME_11;
                else
                    if (letter <= 'O')
                    time = TIME_2;
                else
                    if (letter <= 'S')
                    time = TIME_4;
                else
                    if (letter <= 'Z')
                    time = TIME_830;
            }
            //days for sophomores
            if (sophomoreButton.Checked)
                if (letter >= 'G' && letter <= 'S')
                    day = SOPHOMORE_DAY2;
                else
                    day = SOPHOMORE_DAY1;
            //days for freshmen
            if (freshmanButton.Checked)
                if (letter >= 'G' && letter <= 'S')
                    day = FRESHMAN_DAY2;
                else
                    day = FRESHMAN_DAY1;

            //times for freshmen and sophomores
            if (freshmanButton.Checked || sophomoreButton.Checked)
            {
                if (letter <= 'B')
                    time = TIME_11;
                else
                    if (letter <= 'D')
                    time = TIME_2;
                else
                    if (letter <= 'F')
                    time = TIME_4;
                else
                    if (letter <= 'I')
                    time = TIME_830;
                else
                    if (letter <= 'L')
                    time = TIME_10;
                else
                    if (letter <= 'O')
                    time = TIME_11;
                else
                    if (letter <= 'Q')
                    time = TIME_2;
                else
                    if (letter <= 'S')
                    time = TIME_4;
                else
                    if (letter <= 'V')
                    time = TIME_830;
                else
                    if (letter <= 'Z')
                    time = TIME_10;

            }
           
            //Output results
            outputLabel.Text = ($"{day}, at {time}");



        }















    }


    }


