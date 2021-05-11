﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    

    public partial class MainForm : Form
    {
        int mov;
        int movX;
        int movY;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Navbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Navbar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Navbar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        string password = "daniel";

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == password)
                { 
                    AuthPanel.Visible = false;
                    MainPanel.Visible = true;

                }
                else
                { 
                    MesajParola.Text = "*Parola incorecta";
                    textBox1.Text = "";
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
        }
    }
}
