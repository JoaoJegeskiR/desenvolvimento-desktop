﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultApps.Windows
{
    public partial class SplashScreen: Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            for (int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40);
            }
            progressBar1.Value = 99;
            Thread.Sleep(500);

            this.Close();
        }
    }
}
