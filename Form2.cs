using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnshutdown_Click(object sender, EventArgs e)
        {
            try
            {

                Process.Start("shutdown", "/s /t 0");
            }
            catch
            {
                MessageBox.Show("Some Error Occured....");

            }

        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("shutdown", "/r /t 0");
            }
            catch
            {
                MessageBox.Show("Some Error Occured...");
            }
        }

        private void btnlogoff_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("shutdown.exe", "-l");
            }
            catch
            {
                MessageBox.Show("Some Error occured...");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnhibernate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.SetSuspendState(PowerState.Hibernate, true, true);
            }
            catch
            {
                MessageBox.Show("Some Error Occured...");
            }
        }

        private void btnsleep_Click(object sender, EventArgs e)
        {
            try
            {
                Application.SetSuspendState(PowerState.Suspend, true, true);

            }
            catch
            {
                MessageBox.Show("Some Error Occured...");
            }
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Process.Start("Rundll32.exe", "User32.dll,LockWorkStation");
            }
            catch
            {
                MessageBox.Show("Some Error Occured.....");
            }
        }

        private void btnswitch_Click(object sender, EventArgs e)
        {

        }

        private void btnaboutsys_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            ob.Show();
        }
    }
}
