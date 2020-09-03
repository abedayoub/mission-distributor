namespace MissionDistributor
{
    partial class Manage_Volunteer
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
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PositionCB = new System.Windows.Forms.ComboBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positions = new MissionDistributor.Positions();
            this.positionTableAdapter = new MissionDistributor.PositionsTableAdapters.PositionTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Join_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BloodCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DOB_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.altPhone_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name_txt.Location = new System.Drawing.Point(894, 41);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(234, 26);
            this.Name_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(715, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volunteer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(128, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volunteer ID:";
            // 
            // ID_txt
            // 
            this.ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ID_txt.Location = new System.Drawing.Point(292, 110);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(214, 26);
            this.ID_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(128, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Volunteer Position:";
            // 
            // PositionCB
            // 
            this.PositionCB.DataSource = this.positionBindingSource;
            this.PositionCB.DisplayMember = "Name";
            this.PositionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PositionCB.FormattingEnabled = true;
            this.PositionCB.Location = new System.Drawing.Point(292, 197);
            this.PositionCB.Name = "PositionCB";
            this.PositionCB.Size = new System.Drawing.Size(214, 28);
            this.PositionCB.TabIndex = 6;
            this.PositionCB.ValueMember = "ID";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.positions;
            // 
            // positions
            // 
            this.positions.DataSetName = "Positions";
            this.positions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(477, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Volunteers Manager v.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.altPhone_txt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.phone_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DOB_date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Address_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BloodCB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Add_Btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Join_Date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Name_txt);
            this.groupBox1.Controls.Add(this.PositionCB);
            this.groupBox1.Controls.Add(this.ID_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 606);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Volunteer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Add_Btn
            // 
            this.Add_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Add_Btn.Location = new System.Drawing.Point(571, 547);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(151, 44);
            this.Add_Btn.TabIndex = 11;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(128, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Join Date:";
            // 
            // Join_Date
            // 
            this.Join_Date.Location = new System.Drawing.Point(292, 289);
            this.Join_Date.Name = "Join_Date";
            this.Join_Date.Size = new System.Drawing.Size(214, 22);
            this.Join_Date.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(719, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blood Type:";
            // 
            // BloodCB
            // 
            this.BloodCB.FormattingEnabled = true;
            this.BloodCB.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "B+",
            "B-",
            "O+",
            "O-",
            "N/A"});
            this.BloodCB.Location = new System.Drawing.Point(894, 175);
            this.BloodCB.Name = "BloodCB";
            this.BloodCB.Size = new System.Drawing.Size(234, 24);
            this.BloodCB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(719, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address:";
            // 
            // Address_txt
            // 
            this.Address_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Address_txt.Location = new System.Drawing.Point(894, 243);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(234, 26);
            this.Address_txt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(719, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "DOB:";
            // 
            // DOB_date
            // 
            this.DOB_date.Location = new System.Drawing.Point(894, 106);
            this.DOB_date.Name = "DOB_date";
            this.DOB_date.Size = new System.Drawing.Size(234, 22);
            this.DOB_date.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(719, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone Number:";
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phone_txt.Location = new System.Drawing.Point(894, 317);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(234, 26);
            this.phone_txt.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(719, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Alternative Phone:";
            // 
            // altPhone_txt
            // 
            this.altPhone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.altPhone_txt.Location = new System.Drawing.Point(896, 384);
            this.altPhone_txt.Name = "altPhone_txt";
            this.altPhone_txt.Size = new System.Drawing.Size(234, 26);
            this.altPhone_txt.TabIndex = 21;
            // 
            // Manage_Volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Manage_Volunteer";
            this.Text = " Manage Volunteer";
            this.Load += new System.EventHandler(this.Manage_Volunteer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PositionCB;
        private Positions positions;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private PositionsTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Join_Date;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BloodCB;
        private System.Windows.Forms.TextBox altPhone_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DOB_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Address_txt;
    }
}