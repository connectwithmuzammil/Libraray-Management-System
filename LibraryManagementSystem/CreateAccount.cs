using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btncreateC_Click(object sender, EventArgs e)
        {
            

            if (txtFname.Text.Trim() == string.Empty ) 
            {
                MessageBox.Show("Please enter your Full Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                else if(txtEmail.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else  if(txtphoneC.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("Please enter your Phone NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else   if (txtPass.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            

            
            else
            {
                StreamWriter SW = new StreamWriter("F:\\muzammil\\UserCreate\\" + txtEmail.Text + ".txt");
                SW.WriteLine(txtPass.Text);
                SW.WriteLine(txtEmail.Text);
                SW.WriteLine(txtFname.Text);
                SW.Flush();
                SW.Close();
                MessageBox.Show("User Created successfully", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 F1 = new Form1();
                this.Hide();
                F1.Show();
            }
            
            if(txtphoneC.Text.Trim()==string.Empty)
            {
            }
            else
            txtEmail.Text= txtFname.Text = txtPass.Text = txtphoneC.Text = null;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            this.Hide();
            F1.Show();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            
            Form1 F1 = new Form1();
            this.Hide();
            F1.Show();
        }

        

       

        

       
    }
}
