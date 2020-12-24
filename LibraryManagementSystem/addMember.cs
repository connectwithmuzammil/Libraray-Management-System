using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class addMember : UserControl
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //string Invoice = DateTime.Now.ToString("ddMMMyyyyHHmmss");
            //StreamWriter SW = new StreamWriter("F:\\muzammil\\Member Data"+Invoice + ".txt");

            StreamWriter SW = new StreamWriter(@"F:\data.txt",true);
            SW.WriteLine("Id:"+txtId.Text);
            SW.WriteLine("Member:"+txtMember.Text);
            SW.WriteLine("Phone:" + txtPhone.Text);
            SW.WriteLine("Book:"  + txtBook.Text);
            SW.WriteLine("Author:"+txtAuthor.Text);
            SW.WriteLine("Issue:" + txtIssue.Text);
            SW.WriteLine("Return:"+ txtReturn.Text);
            SW.WriteLine("Fee:"   + txtFee.Text);
            SW.WriteLine("Status:"+ txtStatus.Text);
            //SW.WriteLine(txtEmail.Text);
            //SW.WriteLine(txtFname.Text);
            SW.Flush();
            SW.Close();
            MessageBox.Show("Data Record SucessFully!!");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            this.Hide();
            H.Show();
        }

       

       
    }
}
