using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            sidepanel.Height = btnHome.Height;
            sidepanel.Top = btnHome.Top;
            btnHome.BringToFront();
            
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            sidepanel.Height =btnAddMember.Height;
            sidepanel.Top = btnAddMember.Top;
            btnAddMember.BringToFront();
           
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnHome.Height; 
            sidepanel.Top = btnHome.Top;
            btnHome.BringToFront();
           // btnhomeUser.BringToFront();

        }

        

        

       
    }
}
