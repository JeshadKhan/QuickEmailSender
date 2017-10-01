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
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EmailSender.ProClass
{
    public class ProLogicLayer
    {
        /* Initialize Variables & Objects */

        const string validEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";



        /* Function or Method Property */
        #region Main Process

        internal void WebLinkOfficial()
        {
            try
            {
                Process.Start("http://quaintpark.com");
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void WebLinkDeveloper()
        {
            try
            {
                Process.Start("http://github.com/JeshadKhan");
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void WebLinkApp()
        {
            try
            {
                Process.Start("http://quaintpark.com/Project/Quick-Email-Sender");
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal bool IsValidEmail(string email)
        {
            try
            {
                if (!string.IsNullOrEmpty(email))
                {
                    return Regex.IsMatch(email, validEmailPattern);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void HelpViewer(string appSrartPath)
        {
            try
            {
                string path = appSrartPath;
                Process.Start(path + @"\help.chm");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        internal void CloseHelpViewer()
        {
            try
            {
                Process[] processSystem = Process.GetProcessesByName("hh");

                foreach (Process process in processSystem)
                {
                    process.CloseMainWindow();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion
    }
}
