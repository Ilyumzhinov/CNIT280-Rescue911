﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallForm CallForm = new CallForm();

            CallForm.Show();
        }

        private void btnWaitingCall_Click(object sender, EventArgs e)
        {
            Call_Waiting_Form Waiting_Form = new Call_Waiting_Form();

            Waiting_Form.Show();
        }

        
    }
}
