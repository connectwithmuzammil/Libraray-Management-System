namespace LibraryManagementSystem
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.BackColor = System.Drawing.Color.White;
            this.mnuHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuShowRecord,
            this.mnuUpdate,
            this.mnuDelete,
            this.mnuUserCreate,
            this.mnuExit});
            this.mnuHome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHome.ForeColor = System.Drawing.Color.Red;
            this.mnuHome.Image = ((System.Drawing.Image)(resources.GetObject("mnuHome.Image")));
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(81, 24);
            this.mnuHome.Text = "HOME";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuAddBook.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddBook.ForeColor = System.Drawing.Color.Black;
            this.mnuAddBook.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddBook.Image")));
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(174, 22);
            this.mnuAddBook.Text = "Add_Books";
            this.mnuAddBook.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuShowRecord
            // 
            this.mnuShowRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuShowRecord.ForeColor = System.Drawing.Color.Black;
            this.mnuShowRecord.Image = ((System.Drawing.Image)(resources.GetObject("mnuShowRecord.Image")));
            this.mnuShowRecord.Name = "mnuShowRecord";
            this.mnuShowRecord.Size = new System.Drawing.Size(174, 22);
            this.mnuShowRecord.Text = "Show_Detail";
            this.mnuShowRecord.Click += new System.EventHandler(this.mnuShowRecord_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUpdate.Image = ((System.Drawing.Image)(resources.GetObject("mnuUpdate.Image")));
            this.mnuUpdate.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(174, 22);
            this.mnuUpdate.Text = "Update Record";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDelete.ForeColor = System.Drawing.Color.Black;
            this.mnuDelete.Image = ((System.Drawing.Image)(resources.GetObject("mnuDelete.Image")));
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(174, 22);
            this.mnuDelete.Text = "Delete_Record";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuUserCreate
            // 
            this.mnuUserCreate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuUserCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUserCreate.ForeColor = System.Drawing.Color.Black;
            this.mnuUserCreate.Image = ((System.Drawing.Image)(resources.GetObject("mnuUserCreate.Image")));
            this.mnuUserCreate.Name = "mnuUserCreate";
            this.mnuUserCreate.Size = new System.Drawing.Size(174, 22);
            this.mnuUserCreate.Text = "Create_User";
            this.mnuUserCreate.Click += new System.EventHandler(this.mnuUserCreate_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ForeColor = System.Drawing.Color.Black;
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(174, 22);
            this.mnuExit.Text = "Log Out";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Library Management System";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 70);
            this.panel1.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuShowRecord;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuUserCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;

    }
}