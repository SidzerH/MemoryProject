﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobbelsteenMemory
{
    public partial class Dobbelsteen : Form
    {
        int dice_1, dice_2;
        
        public Dobbelsteen()                                            //Main
        {
            InitializeComponent();

            afterlb.Text = "";
        }

        private void Gooi_1_Click(object sender, EventArgs e)           //Gooi button
        {
            dobbelsteen();
            after();
        }

        private void dobbelsteen()                                     //Dobbelsteen code
        {
            Random rnd = new Random();

            dice_1 = rnd.Next(1, 7);
            dice_2 = rnd.Next(1, 7);

            ///Dice_1

            if (dice_1 == 1)                                            
            {
                pictureBox1.Image = Properties.Resources._1;
            }

            if (dice_1 == 2)
            {
                pictureBox1.Image = Properties.Resources._2;
            }

            if (dice_1 == 3)
            {
                pictureBox1.Image = Properties.Resources._3;
            }

            if (dice_1 == 4)
            {
                pictureBox1.Image = Properties.Resources._4;
            }

            if (dice_1 == 5)
            {
                pictureBox1.Image = Properties.Resources._5;
            }

            if (dice_1 == 6)
            {
                pictureBox1.Image = Properties.Resources._6;
            }

            ///Dice_2

            if (dice_2 == 1)                                            
            {
                pictureBox2.Image = Properties.Resources._1;
            }

            if (dice_2 == 2)
            {
                pictureBox2.Image = Properties.Resources._2;
            }

            if (dice_2 == 3)
            {
                pictureBox2.Image = Properties.Resources._3;
            }

            if (dice_2 == 4)
            {
                pictureBox2.Image = Properties.Resources._4;
            }

            if (dice_2 == 5)
            {
                pictureBox2.Image = Properties.Resources._5;
            }

            if (dice_2 == 6)
            {
                pictureBox2.Image = Properties.Resources._6;
            }

        }

        private void after()                    //Geeft aan wie gewonnen heeft
        {
            dobbelsteen();

            string tekst = "";

            if (dice_1 > dice_2)
            {
                tekst = tekst + "Speler 1 mag als eerste beginnen.";
                afterlb.Text = Convert.ToString(tekst);
            }

            if (dice_1 < dice_2)
            {
                tekst = tekst + "Speler 2 mag als eerste beginnen.";
                afterlb.Text = Convert.ToString(tekst);
            }

            if (dice_1 == dice_2)
            {
                tekst = tekst + "Gooi opnieuw!";
                afterlb.Text = Convert.ToString(tekst);
            }

        }
    }
}