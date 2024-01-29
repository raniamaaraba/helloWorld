using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld1
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Display the Hello World Message

            messageLabel.Text = "Hello World";
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // EWxit the project. 

            this.Close();



        }

        private void spanishButton_Click (object sender, EventArgs e)
        {
            // Display the Hello World message in Spanish

            messageLabel.Text = "Hola Mundo";

        }

       
               
    }
}

