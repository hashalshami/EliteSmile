namespace EliteSmile
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colDoctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.colDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFileNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colDoctorId
            // 
            this.colDoctorId.DataPropertyName = "DoctorId";
            this.colDoctorId.HeaderText = "رقم الدكتور";
            this.colDoctorId.Name = "colDoctorId";
            this.colDoctorId.ReadOnly = true;
            this.colDoctorId.Visible = false;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "date";
            this.colDate.HeaderText = "التاريخ";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "phone";
            this.colPhone.HeaderText = "الهاتف";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colPlan
            // 
            this.colPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlan.DataPropertyName = "plan";
            this.colPlan.HeaderText = "الخطة العلاجية";
            this.colPlan.Name = "colPlan";
            this.colPlan.ReadOnly = true;
            // 
            // colFileNo
            // 
            this.colFileNo.DataPropertyName = "fileNo";
            this.colFileNo.HeaderText = "رقم الملف";
            this.colFileNo.Name = "colFileNo";
            this.colFileNo.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "الاسم";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "الرقم";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 60;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(769, 23);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(5);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDoctorName.Size = new System.Drawing.Size(136, 26);
            this.txtDoctorName.TabIndex = 135;
            this.txtDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDoctorName.WordWrap = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 25);
            this.dateTimePicker1.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(717, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "التاريخ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(913, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "الطبيب :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(456, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "الخطة العلاجية";
            // 
            // txtPlan
            // 
            this.txtPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPlan.Location = new System.Drawing.Point(-137, 70);
            this.txtPlan.Multiline = true;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlan.Size = new System.Drawing.Size(677, 142);
            this.txtPlan.TabIndex = 13;
            // 
            // colDoctorName
            // 
            this.colDoctorName.DataPropertyName = "DoctorName";
            this.colDoctorName.HeaderText = "اسم الطبيب";
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.ReadOnly = true;
            // 
            // txtFileNo
            // 
            this.txtFileNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFileNo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtFileNo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFileNo.Location = new System.Drawing.Point(580, 105);
            this.txtFileNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtFileNo.MaximumSize = new System.Drawing.Size(400, 27);
            this.txtFileNo.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.Size = new System.Drawing.Size(325, 25);
            this.txtFileNo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(913, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "رقم الملف";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPhone.Location = new System.Drawing.Point(580, 140);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.MaximumSize = new System.Drawing.Size(400, 27);
            this.txtPhone.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(325, 25);
            this.txtPhone.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(913, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "إسم المريض";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(913, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "رقم التواصل";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Image = global::EliteSmile.Properties.Resources.search_1;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchBtn.Location = new System.Drawing.Point(375, 12);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBtn.Size = new System.Drawing.Size(114, 46);
            this.searchBtn.TabIndex = 26;
            this.searchBtn.Text = "بحث";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.UseCompatibleTextRendering = true;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Image = global::EliteSmile.Properties.Resources.add_1;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addBtn.Location = new System.Drawing.Point(871, 12);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.addBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addBtn.Size = new System.Drawing.Size(114, 45);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "إضافة";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.UseCompatibleTextRendering = true;
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Image = global::EliteSmile.Properties.Resources._true;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editBtn.Location = new System.Drawing.Point(747, 11);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.editBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editBtn.Size = new System.Drawing.Size(114, 46);
            this.editBtn.TabIndex = 23;
            this.editBtn.Text = "تعديل";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.UseCompatibleTextRendering = true;
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.BackColor = System.Drawing.Color.White;
            this.printBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.printBtn.ForeColor = System.Drawing.Color.Black;
            this.printBtn.Image = global::EliteSmile.Properties.Resources.print;
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.printBtn.Location = new System.Drawing.Point(251, 11);
            this.printBtn.Margin = new System.Windows.Forms.Padding(5);
            this.printBtn.Name = "printBtn";
            this.printBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.printBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.printBtn.Size = new System.Drawing.Size(114, 46);
            this.printBtn.TabIndex = 12;
            this.printBtn.Text = "طباعة";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBtn.UseCompatibleTextRendering = true;
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.refreshBtn.ForeColor = System.Drawing.Color.Black;
            this.refreshBtn.Image = global::EliteSmile.Properties.Resources.refresh;
            this.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refreshBtn.Location = new System.Drawing.Point(499, 12);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.refreshBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refreshBtn.Size = new System.Drawing.Size(114, 46);
            this.refreshBtn.TabIndex = 25;
            this.refreshBtn.Text = "تحديث";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshBtn.UseCompatibleTextRendering = true;
            this.refreshBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Image = global::EliteSmile.Properties.Resources.delete;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteBtn.Location = new System.Drawing.Point(623, 12);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.deleteBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteBtn.Size = new System.Drawing.Size(114, 46);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.UseCompatibleTextRendering = true;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Controls.Add(this.printBtn);
            this.groupBox2.Controls.Add(this.refreshBtn);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(5, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(995, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colFileNo,
            this.colPlan,
            this.colPhone,
            this.colDate,
            this.colDoctorName,
            this.colDoctorId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 30);
            this.dataGridView1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.dataGridView1, "انقر بشكل مزدوج لتحديد الصف لتعديله او حذفه");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1005, 335);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDoctorName);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPlan);
            this.groupBox1.Controls.Add(this.txtFileNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(995, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(580, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.MaximumSize = new System.Drawing.Size(400, 27);
            this.txtName.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 25);
            this.txtName.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
        private System.Windows.Forms.TextBox txtFileNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;

    }
}

