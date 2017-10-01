/*
 * Author       : Quaint Park
 * Copyright    : © 2014 Quaint Park.
 * Website      : www.quaintpark.com
 * -------------------------------------------
 * Developed By : Jeshad Khan
 * Profile      : www.github.com/JeshadKhan
 * -------------------------------------------
 * Release      : 2014
 * Re-Release   : 2017
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmailSender
{
    public partial class frmFlashScreen : Form
    {
        public frmFlashScreen()
        {
            InitializeComponent();
        }

        // Main Process
        #region Main Functionality

        private void frmFlashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                tmrLoading.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBarLoading.Value++;

                if (progressBarLoading.Value == 100)
                {
                    tmrLoading.Enabled = false;
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
