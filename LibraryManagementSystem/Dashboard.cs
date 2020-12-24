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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           // lblDate.Text = DateTime.Now.ToString();
            //timer1.Start();
             //GetSearch();
        }

        

        private void mnuUserCreate_Click(object sender, EventArgs e)
        {
            CreateAccount CA = new CreateAccount();
            CA.MdiParent = this;
            CA.Show();
            
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
               // timer1.Stop();
                //timer1.Dispose();
                Application.Exit();
            }
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            AddBook AB = new AddBook();
            AB.MdiParent = this;
            AB.Show();
        }

        private void mnuShowRecord_Click(object sender, EventArgs e)
        {
            ShowData SD = new ShowData();
            SD.MdiParent = this;
            SD.Show();

            }

        //private void txtSearch_Enter(object sender, EventArgs e)
        //{
        //    if (txtSearch.Text == "Search")
        //    {
        //        txtSearch.Text = "";
        //        txtSearch.ForeColor = Color.Black;
        //    }
        //}

        //private void txtSearch_Leave(object sender, EventArgs e)
        //{
        //    if (txtSearch.Text == "")
        //    {
        //        txtSearch.Text = "Search";
        //        txtSearch.ForeColor = Color.Black;
        //    }
        //}
        //private void GetSearch()
        //{
        //    AutoCompleteStringCollection Arr = new AutoCompleteStringCollection();
        //    StreamReader SR = new StreamReader("F:\\muzammil\\Record.txt");
        //    while (!SR.EndOfStream)
        //    {
        //        Arr.Add(SR.ReadLine());
        //    }
        //    SR.Close();
        //    txtSearch.AutoCompleteCustomSource = Arr;
        //    txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //}

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            ShowData SD = new ShowData();
            this.Hide();
            SD.Show();
          
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            AddBook AB = new AddBook();
            AB.MdiParent = this;
            AB.Show();
        }

        

        

        

        

        

        //private void mnuSearch_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    txtSearch.Show();
        //}
       
        }

        

        //private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        string[] A = txtSearch.Text.Split('#');
        //        lblName.Text = A[0];
        //        lblPrice.Text = A[1];
        //        txtQty.Focus();
        //    }
        //}

        

     

       

        //private void timer1_Tick_1(object sender, EventArgs e)
        //{
        //    lblDate.Text = DateTime.Now.ToString();
        //}

      

        


       
    }

