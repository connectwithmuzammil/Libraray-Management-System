using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace LibraryManagementSystem
{
    public partial class ShowData : Form
    {
        
        public ShowData()
        {
            InitializeComponent();
            xGrid.Columns.Add("A", "ID");
            xGrid.Columns.Add("B", "Member Name");
            xGrid.Columns.Add("C", "Phone No");
            xGrid.Columns.Add("D", "Book Name");
            xGrid.Columns.Add("E", "Author");
            xGrid.Columns.Add("F", "Issue Date");
            xGrid.Columns.Add("G", "Return Date");
            xGrid.Columns.Add("H", "Fee");
            xGrid.Columns.Add("I", "Status");

            GetSearch();

            //xGrid.Columns[0].Width = 30;
            //xGrid.Columns[1].Width = 150;
            //xGrid.Columns[2].Width = 150;
            //xGrid.Columns[3].Width = 150;
            //xGrid.Columns[4].Width = 150;
            //xGrid.Columns[5].Width = 150;
            //xGrid.Columns[6].Width = 150;
            //xGrid.Columns[7].Width = 30;
            //xGrid.Columns[8].Width = 30;
            
        }
       
        
        private void btnReverse_Click(object sender, EventArgs e)
        {
            AddBook AB= new AddBook();
            this.Hide();
            AB.Show();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void GetSearch()
        {
            AutoCompleteStringCollection Arr = new AutoCompleteStringCollection();
            StreamReader SR = new StreamReader("F:\\muzammil\\Record.txt");
            while (!SR.EndOfStream)
            {
                Arr.Add(SR.ReadLine());
            }
            SR.Close();
            txtSearch.AutoCompleteCustomSource = Arr;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] arr = txtSearch.Text.Split('#');
                xGrid.Rows.Add(arr[0],arr[1],arr[2],arr[3],arr[4],arr[5],arr[6],arr[7],arr[8]);
                txtSearch.Clear();
                txtSearch.Focus();
            }
        }

        private void xGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to delete item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                int i = xGrid.CurrentRow.Index;
                xGrid.Rows.RemoveAt(i);

            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDocument xDoc = new PrintDocument();
            xDoc.PrintPage += new PrintPageEventHandler(xDoc_PrintPage);
            PrintPreviewDialog PPD = new PrintPreviewDialog();
            PPD.Document = xDoc;
            PPD.Show();
        }

        private void xDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font F = new Font("Arial", 12, FontStyle.Regular);
            Brush B = Brushes.Black;
           // e.Graphics.DrawImage(Image.FromFile("Images//Logo.png"), 1, 1);
            e.Graphics.DrawString("MEMBER NAME", F, B, 10, 110);
            e.Graphics.DrawString("ID", F, B, 190, 110);
            e.Graphics.DrawString("PHONE NUMBER", F, B, 270, 110);
            e.Graphics.DrawString("BOOK NUMBER", F, B, 370, 110);
            e.Graphics.DrawString("AUTHOR", F, B, 470, 110);
            e.Graphics.DrawString("ISSUE DATE", F, B, 570, 110);
            e.Graphics.DrawString("RETURN DATE", F, B, 670, 110);
            e.Graphics.DrawString("FEES", F, B, 770, 110);
            e.Graphics.DrawString("STATUS", F, B, 870, 110);
            int Y = 130;
            for (int i = 0; i < xGrid.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(xGrid.Rows[i].Cells[0].Value.ToString(), F, B, 10, Y); //FullName
                e.Graphics.DrawString(xGrid.Rows[i].Cells[1].Value.ToString(), F, B, 100, Y); //Email
                e.Graphics.DrawString(xGrid.Rows[i].Cells[2].Value.ToString(), F, B, 170, Y); //Pass
                e.Graphics.DrawString(xGrid.Rows[i].Cells[3].Value.ToString(), F, B, 250, Y);
                e.Graphics.DrawString(xGrid.Rows[i].Cells[4].Value.ToString(), F, B, 330, Y);
                e.Graphics.DrawString(xGrid.Rows[i].Cells[5].Value.ToString(), F, B, 430, Y);
                e.Graphics.DrawString(xGrid.Rows[i].Cells[6].Value.ToString(), F, B, 500, Y);
                e.Graphics.DrawString(xGrid.Rows[i].Cells[7].Value.ToString(), F, B, 580, Y);
                e.Graphics.DrawString(xGrid.Rows[i].Cells[8].Value.ToString(), F, B, 650, Y);
                e.Graphics.DrawLine(Pens.Black, 10, Y, 500, Y);
                Y = Y + 25;
            }
            e.Graphics.DrawLine(Pens.Black, 10, Y + 10, 500, Y + 10);

           // e.Graphics.DrawImage(Image.FromFile("Images//100.jpg"), 100, Y + 10);
            //e.Graphics.DrawString(" Name: " + txtName.Text, F, B, 10, 110);
            //e.Graphics.DrawString("Phone: " + txtPhone.Text, F, B, 10, 150);
            //e.Graphics.DrawString("Email: " + txtEmail.Text, F, B, 10, 200);
            //e.Graphics.DrawImage(Image.FromFile("Images//100.jpg"), 200, 110);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Arr;
            StreamReader SR = new StreamReader("F:\\muzammi\\Record.txt\\");
            while (!SR.EndOfStream)
            {
                Arr = SR.ReadLine().Split('#');
                xGrid.Rows.Add(Arr[0], Arr[1], Arr[2], Arr[3], Arr[4], Arr[5], Arr[6], Arr[7], Arr[8]);
            }
            SR.Close();
        }

       
        }
    }

