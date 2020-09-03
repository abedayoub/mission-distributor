namespace MissionDistributor
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
            this.missionsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.missionsDistributorDataSet = new MissionDistributor.MissionsDistributorDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.missionsTypeTableAdapter = new MissionDistributor.MissionsDistributorDataSetTableAdapters.MissionsTypeTableAdapter();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDataSet = new MissionDistributor.AttendanceDataSet();
            this.attendanceTableAdapter = new MissionDistributor.AttendanceDataSetTableAdapters.AttendanceTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.volunteerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.VolunteersList = new System.Windows.Forms.DataGridView();
            this.missionsDistributorDataSet1 = new MissionDistributor.MissionsDistributorDataSet1();
            this.volunteersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volunteersTableAdapter = new MissionDistributor.MissionsDistributorDataSet1TableAdapters.VolunteersTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfVolunteeringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.TeamLeader_lbl = new System.Windows.Forms.Label();
            this.Driver_lbl = new System.Windows.Forms.Label();
            this.Volunteer1_lbl = new System.Windows.Forms.Label();
            this.Volunteer2_lbl = new System.Windows.Forms.Label();
            this.Volunteer3_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mngVol_btn = new System.Windows.Forms.Button();
            this.missionsDistributorDataSet2 = new MissionDistributor.MissionsDistributorDataSet2();
            this.volunteersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.volunteersTableAdapter1 = new MissionDistributor.MissionsDistributorDataSet2TableAdapters.VolunteersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.missionsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsDistributorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolunteersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsDistributorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsDistributorDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // missionsTypeBindingSource
            // 
            this.missionsTypeBindingSource.DataMember = "MissionsType";
            this.missionsTypeBindingSource.DataSource = this.missionsDistributorDataSet;
            this.missionsTypeBindingSource.CurrentChanged += new System.EventHandler(this.missionsTypeBindingSource_CurrentChanged);
            // 
            // missionsDistributorDataSet
            // 
            this.missionsDistributorDataSet.DataSetName = "MissionsDistributorDataSet";
            this.missionsDistributorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tintin Majuscules", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1099, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1043, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lebanese Civil Defense";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1031, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beirut Regional Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // missionsTypeTableAdapter
            // 
            this.missionsTypeTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.CurrentChanged += new System.EventHandler(this.attendanceBindingSource_CurrentChanged);
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.attendanceDataSet;
            this.attendanceBindingSource1.CurrentChanged += new System.EventHandler(this.attendanceBindingSource1_CurrentChanged);
            // 
            // attendanceDataSet
            // 
            this.attendanceDataSet.DataSetName = "AttendanceDataSet";
            this.attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Your ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(103, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Attend";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(265, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(51, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 259);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(686, 330);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Administrator Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(975, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 38);
            this.button4.TabIndex = 13;
            this.button4.Text = "Clear Attendance Sheet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1081, -21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(35, 17);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trajan Pro", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(12, 764);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Demo Version";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1406, 731);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1398, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MissionDistributor.Properties.Resources.transp_cd;
            this.pictureBox1.Location = new System.Drawing.Point(659, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1099, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "IS Division";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Volunteer3_lbl);
            this.tabPage2.Controls.Add(this.Volunteer2_lbl);
            this.tabPage2.Controls.Add(this.Volunteer1_lbl);
            this.tabPage2.Controls.Add(this.Driver_lbl);
            this.tabPage2.Controls.Add(this.TeamLeader_lbl);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1398, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Missions";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(479, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Mission Type:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1047, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sirens Up!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.volunteerDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 670);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // volunteerDataGridViewTextBoxColumn
            // 
            this.volunteerDataGridViewTextBoxColumn.DataPropertyName = "Volunteer";
            this.volunteerDataGridViewTextBoxColumn.HeaderText = "Volunteer";
            this.volunteerDataGridViewTextBoxColumn.Name = "volunteerDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.missionsTypeBindingSource;
            this.comboBox1.DisplayMember = "TypeName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(687, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "TypeID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mngVol_btn);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.VolunteersList);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1398, 702);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Admin";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // VolunteersList
            // 
            this.VolunteersList.AllowUserToAddRows = false;
            this.VolunteersList.AllowUserToDeleteRows = false;
            this.VolunteersList.AutoGenerateColumns = false;
            this.VolunteersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VolunteersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfVolunteeringDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn1});
            this.VolunteersList.DataSource = this.volunteersBindingSource1;
            this.VolunteersList.Location = new System.Drawing.Point(43, 66);
            this.VolunteersList.Name = "VolunteersList";
            this.VolunteersList.ReadOnly = true;
            this.VolunteersList.RowTemplate.Height = 24;
            this.VolunteersList.Size = new System.Drawing.Size(572, 604);
            this.VolunteersList.TabIndex = 14;
            this.VolunteersList.Visible = false;
            this.VolunteersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VolunteersList_CellContentClick);
            // 
            // missionsDistributorDataSet1
            // 
            this.missionsDistributorDataSet1.DataSetName = "MissionsDistributorDataSet1";
            this.missionsDistributorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volunteersBindingSource
            // 
            this.volunteersBindingSource.DataMember = "Volunteers";
            this.volunteersBindingSource.DataSource = this.missionsDistributorDataSet1;
            // 
            // volunteersTableAdapter
            // 
            this.volunteersTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfVolunteeringDataGridViewTextBoxColumn
            // 
            this.dateOfVolunteeringDataGridViewTextBoxColumn.DataPropertyName = "DateOfVolunteering";
            this.dateOfVolunteeringDataGridViewTextBoxColumn.HeaderText = "DateOfVolunteering";
            this.dateOfVolunteeringDataGridViewTextBoxColumn.Name = "dateOfVolunteeringDataGridViewTextBoxColumn";
            this.dateOfVolunteeringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn1
            // 
            this.positionDataGridViewTextBoxColumn1.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn1.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn1.Name = "positionDataGridViewTextBoxColumn1";
            this.positionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(38, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Volunteers List:";
            this.label8.Visible = false;
            // 
            // TeamLeader_lbl
            // 
            this.TeamLeader_lbl.AutoSize = true;
            this.TeamLeader_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamLeader_lbl.Location = new System.Drawing.Point(889, 207);
            this.TeamLeader_lbl.Name = "TeamLeader_lbl";
            this.TeamLeader_lbl.Size = new System.Drawing.Size(140, 25);
            this.TeamLeader_lbl.TabIndex = 16;
            this.TeamLeader_lbl.Text = "Team Leader";
            // 
            // Driver_lbl
            // 
            this.Driver_lbl.AutoSize = true;
            this.Driver_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_lbl.Location = new System.Drawing.Point(889, 264);
            this.Driver_lbl.Name = "Driver_lbl";
            this.Driver_lbl.Size = new System.Drawing.Size(69, 25);
            this.Driver_lbl.TabIndex = 17;
            this.Driver_lbl.Text = "Driver";
            // 
            // Volunteer1_lbl
            // 
            this.Volunteer1_lbl.AutoSize = true;
            this.Volunteer1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volunteer1_lbl.Location = new System.Drawing.Point(889, 322);
            this.Volunteer1_lbl.Name = "Volunteer1_lbl";
            this.Volunteer1_lbl.Size = new System.Drawing.Size(123, 25);
            this.Volunteer1_lbl.TabIndex = 18;
            this.Volunteer1_lbl.Text = "Volunteer 1";
            // 
            // Volunteer2_lbl
            // 
            this.Volunteer2_lbl.AutoSize = true;
            this.Volunteer2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volunteer2_lbl.Location = new System.Drawing.Point(889, 381);
            this.Volunteer2_lbl.Name = "Volunteer2_lbl";
            this.Volunteer2_lbl.Size = new System.Drawing.Size(123, 25);
            this.Volunteer2_lbl.TabIndex = 19;
            this.Volunteer2_lbl.Text = "Volunteer 2";
            // 
            // Volunteer3_lbl
            // 
            this.Volunteer3_lbl.AutoSize = true;
            this.Volunteer3_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volunteer3_lbl.Location = new System.Drawing.Point(889, 443);
            this.Volunteer3_lbl.Name = "Volunteer3_lbl";
            this.Volunteer3_lbl.Size = new System.Drawing.Size(123, 25);
            this.Volunteer3_lbl.TabIndex = 20;
            this.Volunteer3_lbl.Text = "Volunteer 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("ZapfEllipt BT", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(555, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 51);
            this.label9.TabIndex = 21;
            this.label9.Text = "Next Team:";
            // 
            // mngVol_btn
            // 
            this.mngVol_btn.Location = new System.Drawing.Point(975, 228);
            this.mngVol_btn.Name = "mngVol_btn";
            this.mngVol_btn.Size = new System.Drawing.Size(188, 38);
            this.mngVol_btn.TabIndex = 16;
            this.mngVol_btn.Text = "Manage Volunteers";
            this.mngVol_btn.UseVisualStyleBackColor = true;
            this.mngVol_btn.Visible = false;
            // 
            // missionsDistributorDataSet2
            // 
            this.missionsDistributorDataSet2.DataSetName = "MissionsDistributorDataSet2";
            this.missionsDistributorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volunteersBindingSource1
            // 
            this.volunteersBindingSource1.DataMember = "Volunteers";
            this.volunteersBindingSource1.DataSource = this.missionsDistributorDataSet2;
            // 
            // volunteersTableAdapter1
            // 
            this.volunteersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1416, 797);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Missions Distributor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.missionsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsDistributorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolunteersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsDistributorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionsDistributorDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MissionsDistributorDataSet missionsDistributorDataSet;
        private System.Windows.Forms.BindingSource missionsTypeBindingSource;
        private MissionsDistributorDataSetTableAdapters.MissionsTypeTableAdapter missionsTypeTableAdapter;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private AttendanceDataSet attendanceDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private AttendanceDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volunteerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView VolunteersList;
        private MissionsDistributorDataSet1 missionsDistributorDataSet1;
        private System.Windows.Forms.BindingSource volunteersBindingSource;
        private MissionsDistributorDataSet1TableAdapters.VolunteersTableAdapter volunteersTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfVolunteeringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label Volunteer3_lbl;
        private System.Windows.Forms.Label Volunteer2_lbl;
        private System.Windows.Forms.Label Volunteer1_lbl;
        private System.Windows.Forms.Label Driver_lbl;
        private System.Windows.Forms.Label TeamLeader_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button mngVol_btn;
        private MissionsDistributorDataSet2 missionsDistributorDataSet2;
        private System.Windows.Forms.BindingSource volunteersBindingSource1;
        private MissionsDistributorDataSet2TableAdapters.VolunteersTableAdapter volunteersTableAdapter1;
    }
}

