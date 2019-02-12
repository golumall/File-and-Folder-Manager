using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string []s=Directory.GetLogicalDrives();
            foreach (string x in s)
            {
                cmbdrive.Items.Add(x);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show(); 
        }

        private void cmbdrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbcrfolder.Items.Clear();
                string[] f = Directory.GetDirectories((cmbdrive.SelectedItem).ToString());
                foreach (string x in f)
                {
                    cmbcrfolder.Items.Add(x);
                }
            }
            catch
            {
                MessageBox.Show("Drive is not Exist...");
            }
        }

        private void cmbcrfolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbfile.Items.Clear();
            string[] f = Directory.GetFiles((cmbcrfolder.SelectedItem).ToString());
            foreach (string x in f)
            {
                cmbfile.Items.Add(x);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndlfolder_Click(object sender, EventArgs e)
        {
            try
            {
                if(Directory.Exists((cmbcrfolder.SelectedItem).ToString()))
                {
                Directory.Delete((cmbcrfolder.SelectedItem).ToString());
                MessageBox.Show("Directory deleted Successfully....");
                }
                else
                {
                    MessageBox.Show("Directory is not exist.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Directory is not Empty Pls Delete all files of directory and then try...");
            }

        }

        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(cmbdrive.SelectedItem + txtfolder.Text))
                {
                    MessageBox.Show("Directory is already exist pls enter another directory name..");
                }
                else
                {
                    Directory.CreateDirectory((cmbdrive.SelectedItem + txtfolder.Text).ToString());
                    MessageBox.Show("Directory created Successfully....");
                }
            }
            catch
            {
                MessageBox.Show("Path is Incorrect ...do not edit in drive name");
            }
        }

        private void btncrfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(cmbcrfolder.SelectedItem + "\\"+txtfile.Text + cmbfileext.SelectedItem))
                {
                    MessageBox.Show("File is already exist pls enter another file");
                }
                else
                {
                    File.Create(cmbcrfolder.SelectedItem +"\\"+ txtfile.Text + cmbfileext.SelectedItem);
                    MessageBox.Show("File Created Successfully....");
                }
            }
            catch
            {
                MessageBox.Show("Path is MisMatch.....");
            }
        }

        private void btndlfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(cmbfile.SelectedItem.ToString()))
                {
                    File.Delete(cmbfile.SelectedItem.ToString());
                    MessageBox.Show("File Deleted Successfuly....");

                }
                else if (File.Exists(cmbcrfolder.SelectedItem + "\\" + txtfile.Text + cmbfileext.SelectedItem))
                {
                    File.Delete(cmbcrfolder.SelectedItem + "\\" + txtfile.Text + cmbfileext.SelectedItem);
                    MessageBox.Show("File Deleted Successfuly....");
                }
                else
                {
                    MessageBox.Show("File is not Exist....");
                }
            }
            catch
            {
                MessageBox.Show("Pls Select File Before and then try....");
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                txtdata.Text = File.ReadAllText(cmbfile.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Select File Before....and then try..Or File not Exist....");
            }
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(cmbfile.SelectedItem.ToString(), txtdata.Text);
                MessageBox.Show("Data Written Successfully....");
            }
            catch
            {
                MessageBox.Show("The File u select can not write data on it....select only .docx,.txt file");
            }
        }
    }
}
