using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBook : Form
    {
        
        public AddBook()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("A", "ID");
            dataGridView1.Columns.Add("B", "Member Name");
            dataGridView1.Columns.Add("C", "Phone No");
            dataGridView1.Columns.Add("D", "Book Name");
            dataGridView1.Columns.Add("E", "Author");
            dataGridView1.Columns.Add("F", "Issue Date");
            dataGridView1.Columns.Add("G", "Return Date");
            dataGridView1.Columns.Add("H", "Fee");
            dataGridView1.Columns.Add("I", "Status");


            data();


            this.Paint += new PaintEventHandler(set_background);

            DateTime DT = DateTime.Now;
            txtDateIssue.Text = DT.ToString();

            DateTime DT2 = DT.AddDays(10);
            txtDateReturn.Text = DT2.ToString();


        }
        

        
        private void btnshowData_Click(object sender, EventArgs e)
        {
            ShowData SD = new ShowData();
            this.Hide();
            SD.Show();
        }

    
        private void btnAddRecord_Click(object sender, EventArgs e)
        {

            if (txtMember.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Member name","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPhone.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please enter Phone No","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtAuthor.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please enter Author Name","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Fees","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStatus.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Rows.Add(txtId.Text, txtMember.Text, txtPhone.Text, txtBook.Text, txtAuthor.Text, txtDateIssue.Text, txtDateReturn.Text, txtFee.Text, txtStatus.Text);

                txtMember.Text = txtId.Text = txtPhone.Text = txtBook.Text = txtAuthor.Text = txtDateReturn.Text = txtDateIssue.Text = txtFee.Text = txtStatus.Text = null;
                
            }
           
           
            
        }
        public void data()
        {
            string[] lines = File.ReadAllLines(@"F:\\muzammil\\Record.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('#');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridView1.Rows.Add(row);
               
            }
        }
        int SelectedRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                SelectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];
                txtId.Text = row.Cells[0].Value.ToString();
                txtMember.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                txtBook.Text = row.Cells[3].Value.ToString();
                txtAuthor.Text = row.Cells[4].Value.ToString();
                txtDateIssue.Text = row.Cells[5].Value.ToString();
                txtDateReturn.Text = row.Cells[6].Value.ToString();
                txtFee.Text = row.Cells[7].Value.ToString();
                txtStatus.Text = row.Cells[8].Value.ToString();
           
            
          //  = row.Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMember.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select the cell First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow DGR = dataGridView1.Rows[SelectedRow];
                DGR.Cells[0].Value = txtId.Text;
                DGR.Cells[1].Value = txtMember.Text;
                DGR.Cells[2].Value = txtPhone.Text;
                DGR.Cells[3].Value = txtBook.Text;
                DGR.Cells[4].Value = txtAuthor.Text;
                DGR.Cells[5].Value = txtDateIssue.Text;
                DGR.Cells[6].Value = txtDateReturn.Text;
                DGR.Cells[7].Value = txtFee.Text;
                DGR.Cells[8].Value = txtStatus.Text;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtMember.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Member name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAuthor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Author Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFee.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStatus.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamWriter SW = new StreamWriter(@"F:\muzammil\Record.txt", true);

                SW.Write(txtId.Text +      "#");
                SW.Write(txtMember.Text +  "#");
                SW.Write(txtPhone.Text +   "#");
                SW.Write(txtBook.Text +    "#");
                SW.Write(txtAuthor.Text +  "#");
                SW.Write(txtDateIssue.Text+"#");
                SW.Write(txtDateReturn.Text+"#");
                SW.Write(txtFee.Text +      "#");
                SW.WriteLine(txtStatus.Text+"#");
                //SW.WriteLine("---------------------------------------------------------------------------------------------------------------");
                txtId.Text = txtMember.Text = txtPhone.Text = txtBook.Text = txtDateIssue.Text = txtDateReturn.Text = txtAuthor.Text = txtFee.Text = txtStatus.Text = null;

                SW.Flush();
                SW.Close();
                MessageBox.Show("Data Record SuccessFully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            Dashboard D = new Dashboard();
            this.Hide();
            D.Show();
        }


        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void txtMember_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                StreamReader SR = new StreamReader("F:\\muzammil\\ID.txt");
                string noobie = SR.ReadLine();
                int noob = Int32.Parse(noobie);
                txtId.Text = "cs" + noobie;
                SR.Close();
                txtPhone.Focus();
                StreamWriter SW = new StreamWriter("F:\\muzammil\\ID.txt");
                noob += 1;
                SW.WriteLine(noob);
                SW.Close();
            }
        }

       
           

        }
        
    }

