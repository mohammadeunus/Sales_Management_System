﻿namespace superShopManagementSystem.forms
{
    partial class salesmanHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesmanHomePage));
            this.mainPanelManagerPage = new System.Windows.Forms.Panel();
            this.buttonEntry = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.salername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanelManagerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelManagerPage
            // 
            this.mainPanelManagerPage.Controls.Add(this.buttonEntry);
            this.mainPanelManagerPage.Controls.Add(this.button1);
            this.mainPanelManagerPage.Controls.Add(this.salername);
            this.mainPanelManagerPage.Controls.Add(this.label4);
            this.mainPanelManagerPage.Controls.Add(this.panel1);
            this.mainPanelManagerPage.Controls.Add(this.logout);
            this.mainPanelManagerPage.Controls.Add(this.pictureBox1);
            this.mainPanelManagerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelManagerPage.Location = new System.Drawing.Point(0, 0);
            this.mainPanelManagerPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainPanelManagerPage.Name = "mainPanelManagerPage";
            this.mainPanelManagerPage.Size = new System.Drawing.Size(831, 488);
            this.mainPanelManagerPage.TabIndex = 9;
            this.mainPanelManagerPage.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanelManagerPage_Paint);
            // 
            // buttonEntry
            // 
            this.buttonEntry.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonEntry.Location = new System.Drawing.Point(6, 178);
            this.buttonEntry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEntry.Name = "buttonEntry";
            this.buttonEntry.Size = new System.Drawing.Size(72, 66);
            this.buttonEntry.TabIndex = 21;
            this.buttonEntry.Text = "Entry product";
            this.buttonEntry.UseVisualStyleBackColor = true;
            this.buttonEntry.Click += new System.EventHandler(this.buttonEntry_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(6, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 66);
            this.button1.TabIndex = 21;
            this.button1.Text = "customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // salername
            // 
            this.salername.AutoSize = true;
            this.salername.Location = new System.Drawing.Point(10, 43);
            this.salername.Name = "salername";
            this.salername.Size = new System.Drawing.Size(69, 15);
            this.salername.TabIndex = 7;
            this.salername.Text = "seller Name";
            this.salername.Click += new System.EventHandler(this.salername_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SELLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(85, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 466);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.logout.Location = new System.Drawing.Point(4, 450);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(78, 26);
            this.logout.TabIndex = 4;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 382);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // salesmanHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 488);
            this.Controls.Add(this.mainPanelManagerPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "salesmanHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salesmanHomePage";
            this.mainPanelManagerPage.ResumeLayout(false);
            this.mainPanelManagerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanelManagerPage;
        private PictureBox pictureBox1;
        private Button logout;
        private Panel panel1;
        private Label salername;
        private Label label4;
        private Button button1;
        private Button buttonEntry;
    }
}