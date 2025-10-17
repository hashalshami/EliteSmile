namespace EliteSmile
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.masterPanel = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliteSmileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.masterPanel.Controls.Add(this.panelContainer);
            this.masterPanel.Controls.Add(this.topPanel);
            this.masterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterPanel.Location = new System.Drawing.Point(0, 46);
            this.masterPanel.Name = "masterPanel";
            this.masterPanel.Size = new System.Drawing.Size(1208, 383);
            this.masterPanel.TabIndex = 1001;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoSize = true;
            this.panelContainer.BackColor = System.Drawing.Color.Silver;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 42);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelContainer.Size = new System.Drawing.Size(1208, 341);
            this.panelContainer.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.topPanel.Size = new System.Drawing.Size(1208, 42);
            this.topPanel.TabIndex = 500;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1198, 38);
            this.panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Dubai", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(100, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(996, 36);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "الخطة العلاجية";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserMenuItem,
            this.PlanMenuItem,
            this.EliteSmileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1208, 46);
            this.menuStrip1.TabIndex = 1002;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1096, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserMenuItem
            // 
            this.UserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileMenuItem,
            this.LogoutMenuItem});
            this.UserMenuItem.Font = new System.Drawing.Font("Dubai", 13F, System.Drawing.FontStyle.Bold);
            this.UserMenuItem.Image = global::EliteSmile.Properties.Resources.userr;
            this.UserMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserMenuItem.Name = "UserMenuItem";
            this.UserMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.UserMenuItem.Size = new System.Drawing.Size(149, 42);
            this.UserMenuItem.Text = "ابتسامة النخبة";
            this.UserMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProfileMenuItem
            // 
            this.ProfileMenuItem.Name = "ProfileMenuItem";
            this.ProfileMenuItem.Size = new System.Drawing.Size(197, 34);
            this.ProfileMenuItem.Text = "الملف الشخصي";
            this.ProfileMenuItem.Click += new System.EventHandler(this.ProfileMenuItem_Click);
            // 
            // LogoutMenuItem
            // 
            this.LogoutMenuItem.Name = "LogoutMenuItem";
            this.LogoutMenuItem.Size = new System.Drawing.Size(197, 34);
            this.LogoutMenuItem.Text = "تسجيل الخروج";
            this.LogoutMenuItem.Click += new System.EventHandler(this.LogoutMenuItem_Click);
            // 
            // PlanMenuItem
            // 
            this.PlanMenuItem.Font = new System.Drawing.Font("Dubai", 13F, System.Drawing.FontStyle.Bold);
            this.PlanMenuItem.Image = global::EliteSmile.Properties.Resources.lamp;
            this.PlanMenuItem.Name = "PlanMenuItem";
            this.PlanMenuItem.Size = new System.Drawing.Size(139, 42);
            this.PlanMenuItem.Text = "الخطة العلاجية";
            this.PlanMenuItem.Click += new System.EventHandler(this.PlanMenuItem_Click);
            // 
            // EliteSmileMenuItem
            // 
            this.EliteSmileMenuItem.Font = new System.Drawing.Font("Dubai", 13F, System.Drawing.FontStyle.Bold);
            this.EliteSmileMenuItem.Image = global::EliteSmile.Properties.Resources.system;
            this.EliteSmileMenuItem.Name = "EliteSmileMenuItem";
            this.EliteSmileMenuItem.Size = new System.Drawing.Size(137, 42);
            this.EliteSmileMenuItem.Text = "ابتسامة النخبة";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 429);
            this.Controls.Add(this.masterPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ابتسامة النخبة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel masterPanel;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlanMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliteSmileMenuItem;
    }
}