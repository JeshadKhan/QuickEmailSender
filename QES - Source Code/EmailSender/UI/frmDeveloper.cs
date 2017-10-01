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
using EmailSender;
using EmailSender.ProClass;

namespace EmailSender.UI
{
    public partial class frmDeveloper : Form
    {
        /* Initialize Property */
        public bool AlwaysOnTop { get; set; }



        /* Control Method Functionality */

        public frmDeveloper()
        {
            InitializeComponent();
        }

        // Tool Functionality
        #region Tool Functionality

        private void frmDeveloper_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.AlwaysOnTop)
                    this.TopMost = true;
                else
                    this.TopMost = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnklblDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProLogicLayer pll = new ProLogicLayer();
                pll.WebLinkDeveloper();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnklblOnline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProLogicLayer pll = new ProLogicLayer();
                pll.WebLinkOfficial();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
