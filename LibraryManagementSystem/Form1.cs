using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                StreamReader SR = new StreamReader("F:\\muzammil\\UserCreate\\" + txtuser.Text + ".txt");
                string Pass = SR.ReadLine();
                string FName = SR.ReadLine(); 
                if (txtpass.Text.Equals(Pass))
                {
                    MessageBox.Show("You have Sucessuflly login !!", "Login",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    Dashboard D = new  Dashboard();
                    this.Hide();
                    D.Show();
                   
                }
                else
                {

                    MessageBox.Show("Please try again", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException )
            {
                
               MessageBox.Show("Email and Password is wrong!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

               
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Enter Email or Phone Number")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
                
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
                txtuser.Text = "Enter Email or Phone Number";
                txtuser.ForeColor = Color.Black;
               
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
              
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
                txtpass.Text = "Password";
            txtpass.ForeColor = Color.Black;
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            CreateAccount CA = new CreateAccount();
            this.Hide();
            CA.Show();

           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   this.ActiveControl = txtuser;
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;


            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);//the rectangle, the same size as our Form


            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);//define gradient's properties


            graphics.FillRectangle(b, gradient_rectangle);//apply gradient
        }

        

        

       

        
       

       
    }
}
