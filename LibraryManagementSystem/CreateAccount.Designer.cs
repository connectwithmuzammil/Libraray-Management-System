namespace LibraryManagementSystem
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ps = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.txtphoneC = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btncreateC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ps
            // 
            this.ps.AutoSize = true;
            this.ps.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ps.Location = new System.Drawing.Point(238, 215);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(63, 16);
            this.ps.TabIndex = 17;
            this.ps.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(311, 211);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(246, 22);
            this.txtPass.TabIndex = 16;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(238, 129);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(40, 16);
            this.e.TabIndex = 15;
            this.e.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(311, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(238, 174);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(46, 16);
            this.p.TabIndex = 13;
            this.p.Text = "Phone:";
            // 
            // txtphoneC
            // 
            this.txtphoneC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneC.Location = new System.Drawing.Point(311, 171);
            this.txtphoneC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphoneC.Name = "txtphoneC";
            this.txtphoneC.Size = new System.Drawing.Size(246, 22);
            this.txtphoneC.TabIndex = 12;
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(238, 92);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(64, 16);
            this.n.TabIndex = 11;
            this.n.Text = "Full Name:";
            // 
            // txtFname
            // 
            this.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(311, 92);
            this.txtFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(246, 22);
            this.txtFname.TabIndex = 10;
            // 
            // btncreateC
            // 
            this.btncreateC.BackColor = System.Drawing.Color.LimeGreen;
            this.btncreateC.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btncreateC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreateC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncreateC.Location = new System.Drawing.Point(241, 266);
            this.btncreateC.Name = "btncreateC";
            this.btncreateC.Size = new System.Drawing.Size(316, 29);
            this.btncreateC.TabIndex = 18;
            this.btncreateC.Text = "Create";
            this.btncreateC.UseVisualStyleBackColor = false;
            this.btncreateC.Click += new System.EventHandler(this.btncreateC_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InfoText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(267, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(747, -2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 35);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "B&ack";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 45);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 37);
            this.panel2.TabIndex = 22;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncreateC);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.e);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.p);
            this.Controls.Add(this.txtphoneC);
            this.Controls.Add(this.n);
            this.Controls.Add(this.txtFname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ps;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox txtphoneC;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btncreateC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}