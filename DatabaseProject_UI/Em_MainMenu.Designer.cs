namespace DatabaseProject_UI
{
    partial class Em_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Em_MainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Datepanel = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Transaction_btn = new System.Windows.Forms.Button();
            this.Appointment_btn = new System.Windows.Forms.Button();
            this.Job_btn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LogoPBox = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Logout_btn = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.Datepanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.Logout_btn);
            this.panelMenu.Controls.Add(this.Datepanel);
            this.panelMenu.Controls.Add(this.Transaction_btn);
            this.panelMenu.Controls.Add(this.Appointment_btn);
            this.panelMenu.Controls.Add(this.Job_btn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 586);
            this.panelMenu.TabIndex = 0;
            // 
            // Datepanel
            // 
            this.Datepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Datepanel.Controls.Add(this.Datelbl);
            this.Datepanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Datepanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.Datepanel.Location = new System.Drawing.Point(0, 535);
            this.Datepanel.Name = "Datepanel";
            this.Datepanel.Size = new System.Drawing.Size(221, 51);
            this.Datepanel.TabIndex = 0;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(21, 13);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(48, 20);
            this.Datelbl.TabIndex = 0;
            this.Datelbl.Text = "label1";
            // 
            // Transaction_btn
            // 
            this.Transaction_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Transaction_btn.FlatAppearance.BorderSize = 0;
            this.Transaction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transaction_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Transaction_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transaction_btn.Location = new System.Drawing.Point(0, 207);
            this.Transaction_btn.Name = "Transaction_btn";
            this.Transaction_btn.Size = new System.Drawing.Size(221, 60);
            this.Transaction_btn.TabIndex = 3;
            this.Transaction_btn.Text = "Transactions";
            this.Transaction_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Transaction_btn.UseVisualStyleBackColor = true;
            this.Transaction_btn.Click += new System.EventHandler(this.Transaction_btn_Click);
            // 
            // Appointment_btn
            // 
            this.Appointment_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appointment_btn.FlatAppearance.BorderSize = 0;
            this.Appointment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Appointment_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appointment_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Appointment_btn.Location = new System.Drawing.Point(0, 147);
            this.Appointment_btn.Name = "Appointment_btn";
            this.Appointment_btn.Size = new System.Drawing.Size(221, 60);
            this.Appointment_btn.TabIndex = 2;
            this.Appointment_btn.Text = "Appointments";
            this.Appointment_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Appointment_btn.UseVisualStyleBackColor = true;
            this.Appointment_btn.Click += new System.EventHandler(this.Appointment_btn_Click);
            // 
            // Job_btn
            // 
            this.Job_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Job_btn.FlatAppearance.BorderSize = 0;
            this.Job_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Job_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Job_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Job_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Job_btn.Location = new System.Drawing.Point(0, 87);
            this.Job_btn.Name = "Job_btn";
            this.Job_btn.Size = new System.Drawing.Size(221, 60);
            this.Job_btn.TabIndex = 1;
            this.Job_btn.Text = "Jobs";
            this.Job_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Job_btn.UseVisualStyleBackColor = true;
            this.Job_btn.Click += new System.EventHandler(this.Job_btn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.LogoPBox);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(221, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // LogoPBox
            // 
            this.LogoPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoPBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPBox.Image")));
            this.LogoPBox.InitialImage = null;
            this.LogoPBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPBox.Name = "LogoPBox";
            this.LogoPBox.Size = new System.Drawing.Size(221, 86);
            this.LogoPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPBox.TabIndex = 1;
            this.LogoPBox.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(156)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(221, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(788, 86);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(328, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(221, 86);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(788, 500);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_btn.Location = new System.Drawing.Point(0, 267);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(221, 60);
            this.Logout_btn.TabIndex = 4;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Em_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 586);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Em_MainMenu";
            this.Text = "Em_MainMenu";
            this.Load += new System.EventHandler(this.Em_MainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.Datepanel.ResumeLayout(false);
            this.Datepanel.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox LogoPBox;
        private System.Windows.Forms.Button Job_btn;
        private System.Windows.Forms.Button Transaction_btn;
        private System.Windows.Forms.Button Appointment_btn;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel Datepanel;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Logout_btn;
    }
}