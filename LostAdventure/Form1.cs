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

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            
            if (page == 1) 
            {
                page = 2;
            }
            else if (page == 2) 
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 5) 
            {
                page = 6;
            }
            else if (page == 4) 
            {
                page = 1;
            }
            else if (page == 5) 
            {
                page = 6;
            }
            else if (page == 6) 
            {
                page = 1;
            }
            else if (page == 7) 
            {
                page = 98;
            }
            else if (page == 98)
            {
                page =1;
            }

            /// Display text and game options to screen based on the 
            /// current page
            DisplayPage();
          
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2 )
            {
                page = 5;
            }
            else if (page == 3 )
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page =10;
            }
            else if (page ==4 )
            {
                page = 3;
            }
            else if (page ==5 )
            {
                page =6 ;
            }
            else if (page == 5) 
            {
                page = 7;
            }
            
                

           

            /// Display text and game options to screen based on the 
            /// current page

            DisplayPage();

        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are walking to the bank.";
                    option1Label.Text = "Cross the Street";
                    option2Label.Text = "Go left";
                    imageBox.Image = Properties.Resources.walking;
                    break;
                case 2:
                    outputLabel.Text = "You see the Bank Of Montreal?";
                    option1Label.Text = "Turn Left";
                    option2Label.Text = "Go inside";

                    imageBox.Image = Properties.Resources.BMO_roundel;
                    
                    player2.Play();

                    break;
                case 3:
                    outputLabel.Text = "You get lost and stabbed by a homeless junkie. Play again?";//
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.hobo;
                    break;
                case 4:
                    outputLabel.Text = "You see a homeless man begging for change.";
                    option1Label.Text = "Give Him Change?";
                    option2Label.Text = "Turn Right";
                    imageBox.Image = Properties.Resources.hobo2;
                    break;
                case 5:
                    outputLabel.Text = "You see a security guard";
                    option1Label.Text = "Go for his gun";
                    option2Label.Text = "Ignore him";
                    imageBox.Image = Properties.Resources.guard;
                    break;
                case 6:
                    outputLabel.Text = "You get tackled and arrested. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.loser;
                    break;
                case 7:
                    outputLabel.Text = "You walk up to the tellers desk";
                    option1Label.Text = "Make a deposit";
                    option2Label.Text = "Scream at the lady";
                    imageBox.Image = Properties.Resources.banker;


                 break;
                case 8:
                   outputLabel.Text = "";
                    option1Label.Text = "Yes";
                  option2Label.Text = "No";
                   break;

                case 9:
                    outputLabel.Text = "Walk home or walk to the bank?";
                    option1Label.Text = "home";
                    option2Label.Text = "Bank";
                    imageBox.Image = Properties.Resources.cross;
                    break;
                case 10:
                    outputLabel.Text = "You get banned from the bank for life. play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.loser;
                    break;
                case 11:
                    outputLabel.Text = "Walk to the bank or walk back home?";
                    option1Label.Text = "To the bank";
                    option2Label.Text = "Home";
                    imageBox.Image = Properties.Resources.cross;
                    break;
                case 98:
                    outputLabel.Text = "You deposit all your money and go home. you win. play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.winner;
                    break;

                case 99:
                    outputLabel.Text = "Thanks?";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
            }

        }
    }
}
