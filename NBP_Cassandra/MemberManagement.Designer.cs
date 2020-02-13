namespace NBP_Cassandra
{
    partial class MemberManagement
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
            this.btnAllMembers = new System.Windows.Forms.Button();
            this.btnOKMember = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGym = new System.Windows.Forms.TextBox();
            this.radGetMemship = new System.Windows.Forms.RadioButton();
            this.btnOKMembership = new System.Windows.Forms.Button();
            this.radDelMemship = new System.Windows.Forms.RadioButton();
            this.datLastsUntil = new System.Windows.Forms.DateTimePicker();
            this.radAddMemship = new System.Windows.Forms.RadioButton();
            this.datLastsFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMembershipID = new System.Windows.Forms.TextBox();
            this.btnAllMemberships = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.radGetMember = new System.Windows.Forms.RadioButton();
            this.radDelMember = new System.Windows.Forms.RadioButton();
            this.radAddMember = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataMembers = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataMemships = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMembers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMemships)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllMembers
            // 
            this.btnAllMembers.Location = new System.Drawing.Point(6, 19);
            this.btnAllMembers.Name = "btnAllMembers";
            this.btnAllMembers.Size = new System.Drawing.Size(75, 23);
            this.btnAllMembers.TabIndex = 0;
            this.btnAllMembers.Text = "All Members";
            this.btnAllMembers.UseVisualStyleBackColor = true;
            this.btnAllMembers.Click += new System.EventHandler(this.btnAllMembers_Click);
            // 
            // btnOKMember
            // 
            this.btnOKMember.Location = new System.Drawing.Point(150, 205);
            this.btnOKMember.Name = "btnOKMember";
            this.btnOKMember.Size = new System.Drawing.Size(75, 23);
            this.btnOKMember.TabIndex = 7;
            this.btnOKMember.Text = "OK";
            this.btnOKMember.UseVisualStyleBackColor = true;
            this.btnOKMember.Click += new System.EventHandler(this.btnOKMember_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 140);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 179);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(219, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtGym);
            this.groupBox4.Controls.Add(this.radGetMemship);
            this.groupBox4.Controls.Add(this.btnOKMembership);
            this.groupBox4.Controls.Add(this.radDelMemship);
            this.groupBox4.Controls.Add(this.datLastsUntil);
            this.groupBox4.Controls.Add(this.radAddMemship);
            this.groupBox4.Controls.Add(this.datLastsFrom);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtMembershipID);
            this.groupBox4.Location = new System.Drawing.Point(249, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 238);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Memberships";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Gym Name:";
            // 
            // txtGym
            // 
            this.txtGym.Location = new System.Drawing.Point(6, 179);
            this.txtGym.Name = "txtGym";
            this.txtGym.Size = new System.Drawing.Size(219, 20);
            this.txtGym.TabIndex = 6;
            // 
            // radGetMemship
            // 
            this.radGetMemship.AutoSize = true;
            this.radGetMemship.Location = new System.Drawing.Point(6, 42);
            this.radGetMemship.Name = "radGetMemship";
            this.radGetMemship.Size = new System.Drawing.Size(102, 17);
            this.radGetMemship.TabIndex = 1;
            this.radGetMemship.TabStop = true;
            this.radGetMemship.Text = "Get Membership";
            this.radGetMemship.UseVisualStyleBackColor = true;
            this.radGetMemship.CheckedChanged += new System.EventHandler(this.radGetMemship_CheckedChanged);
            // 
            // btnOKMembership
            // 
            this.btnOKMembership.Location = new System.Drawing.Point(150, 205);
            this.btnOKMembership.Name = "btnOKMembership";
            this.btnOKMembership.Size = new System.Drawing.Size(75, 23);
            this.btnOKMembership.TabIndex = 7;
            this.btnOKMembership.Text = "OK";
            this.btnOKMembership.UseVisualStyleBackColor = true;
            this.btnOKMembership.Click += new System.EventHandler(this.btnOKMembership_Click);
            // 
            // radDelMemship
            // 
            this.radDelMemship.AutoSize = true;
            this.radDelMemship.Location = new System.Drawing.Point(6, 65);
            this.radDelMemship.Name = "radDelMemship";
            this.radDelMemship.Size = new System.Drawing.Size(116, 17);
            this.radDelMemship.TabIndex = 2;
            this.radDelMemship.TabStop = true;
            this.radDelMemship.Text = "Delete Membership";
            this.radDelMemship.UseVisualStyleBackColor = true;
            this.radDelMemship.CheckedChanged += new System.EventHandler(this.radDelMemship_CheckedChanged);
            // 
            // datLastsUntil
            // 
            this.datLastsUntil.CustomFormat = "dd.MM.yy";
            this.datLastsUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datLastsUntil.Location = new System.Drawing.Point(120, 140);
            this.datLastsUntil.Name = "datLastsUntil";
            this.datLastsUntil.Size = new System.Drawing.Size(105, 20);
            this.datLastsUntil.TabIndex = 5;
            // 
            // radAddMemship
            // 
            this.radAddMemship.AutoSize = true;
            this.radAddMemship.Location = new System.Drawing.Point(6, 19);
            this.radAddMemship.Name = "radAddMemship";
            this.radAddMemship.Size = new System.Drawing.Size(104, 17);
            this.radAddMemship.TabIndex = 0;
            this.radAddMemship.TabStop = true;
            this.radAddMemship.Text = "Add Membership";
            this.radAddMemship.UseVisualStyleBackColor = true;
            this.radAddMemship.CheckedChanged += new System.EventHandler(this.radAddMemship_CheckedChanged);
            // 
            // datLastsFrom
            // 
            this.datLastsFrom.CustomFormat = "dd.MM.yy";
            this.datLastsFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datLastsFrom.Location = new System.Drawing.Point(6, 140);
            this.datLastsFrom.Name = "datLastsFrom";
            this.datLastsFrom.Size = new System.Drawing.Size(105, 20);
            this.datLastsFrom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lasts From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Member ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lasts Until:";
            // 
            // txtMembershipID
            // 
            this.txtMembershipID.Location = new System.Drawing.Point(6, 101);
            this.txtMembershipID.Name = "txtMembershipID";
            this.txtMembershipID.Size = new System.Drawing.Size(219, 20);
            this.txtMembershipID.TabIndex = 3;
            // 
            // btnAllMemberships
            // 
            this.btnAllMemberships.Location = new System.Drawing.Point(6, 19);
            this.btnAllMemberships.Name = "btnAllMemberships";
            this.btnAllMemberships.Size = new System.Drawing.Size(102, 23);
            this.btnAllMemberships.TabIndex = 0;
            this.btnAllMemberships.Text = "All Memberships";
            this.btnAllMemberships.UseVisualStyleBackColor = true;
            this.btnAllMemberships.Click += new System.EventHandler(this.btnAllMemberships_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateID);
            this.groupBox1.Controls.Add(this.radGetMember);
            this.groupBox1.Controls.Add(this.radDelMember);
            this.groupBox1.Controls.Add(this.radAddMember);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMemberID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.btnOKMember);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 238);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members";
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Location = new System.Drawing.Point(150, 99);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateID.TabIndex = 4;
            this.btnGenerateID.Text = "Generate ID";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // radGetMember
            // 
            this.radGetMember.AutoSize = true;
            this.radGetMember.Location = new System.Drawing.Point(6, 42);
            this.radGetMember.Name = "radGetMember";
            this.radGetMember.Size = new System.Drawing.Size(83, 17);
            this.radGetMember.TabIndex = 1;
            this.radGetMember.TabStop = true;
            this.radGetMember.Text = "Get Member";
            this.radGetMember.UseVisualStyleBackColor = true;
            this.radGetMember.CheckedChanged += new System.EventHandler(this.radGetMember_CheckedChanged);
            // 
            // radDelMember
            // 
            this.radDelMember.AutoSize = true;
            this.radDelMember.Location = new System.Drawing.Point(6, 65);
            this.radDelMember.Name = "radDelMember";
            this.radDelMember.Size = new System.Drawing.Size(97, 17);
            this.radDelMember.TabIndex = 2;
            this.radDelMember.TabStop = true;
            this.radDelMember.Text = "Delete Member";
            this.radDelMember.UseVisualStyleBackColor = true;
            this.radDelMember.CheckedChanged += new System.EventHandler(this.radDelMember_CheckedChanged);
            // 
            // radAddMember
            // 
            this.radAddMember.AutoSize = true;
            this.radAddMember.Location = new System.Drawing.Point(6, 19);
            this.radAddMember.Name = "radAddMember";
            this.radAddMember.Size = new System.Drawing.Size(85, 17);
            this.radAddMember.TabIndex = 0;
            this.radAddMember.TabStop = true;
            this.radAddMember.Text = "Add Member";
            this.radAddMember.UseVisualStyleBackColor = true;
            this.radAddMember.CheckedChanged += new System.EventHandler(this.radAddMember_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(6, 101);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(138, 20);
            this.txtMemberID.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataMembers);
            this.groupBox2.Controls.Add(this.btnAllMembers);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 254);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // dataMembers
            // 
            this.dataMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.FirstName,
            this.LastName});
            this.dataMembers.Location = new System.Drawing.Point(6, 48);
            this.dataMembers.Name = "dataMembers";
            this.dataMembers.RowHeadersWidth = 24;
            this.dataMembers.Size = new System.Drawing.Size(219, 200);
            this.dataMembers.TabIndex = 1;
            // 
            // MemberID
            // 
            this.MemberID.HeaderText = "ID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 33;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 80;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataMemships);
            this.groupBox3.Controls.Add(this.btnAllMemberships);
            this.groupBox3.Location = new System.Drawing.Point(249, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 254);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // dataMemships
            // 
            this.dataMemships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMemships.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Gym});
            this.dataMemships.Location = new System.Drawing.Point(6, 48);
            this.dataMemships.Name = "dataMemships";
            this.dataMemships.RowHeadersWidth = 24;
            this.dataMemships.Size = new System.Drawing.Size(219, 200);
            this.dataMemships.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 33;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "From";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Until";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 53;
            // 
            // Gym
            // 
            this.Gym.HeaderText = "Gym";
            this.Gym.Name = "Gym";
            this.Gym.ReadOnly = true;
            this.Gym.Width = 54;
            // 
            // MemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "MemberManagement";
            this.Text = "Member Management";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMembers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMemships)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllMembers;
        private System.Windows.Forms.Button btnOKMember;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAllMemberships;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMembershipID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datLastsFrom;
        private System.Windows.Forms.DateTimePicker datLastsUntil;
        private System.Windows.Forms.RadioButton radGetMember;
        private System.Windows.Forms.RadioButton radDelMember;
        private System.Windows.Forms.RadioButton radAddMember;
        private System.Windows.Forms.RadioButton radGetMemship;
        private System.Windows.Forms.Button btnOKMembership;
        private System.Windows.Forms.RadioButton radDelMemship;
        private System.Windows.Forms.RadioButton radAddMemship;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.DataGridView dataMembers;
        private System.Windows.Forms.DataGridView dataMemships;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGym;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gym;
    }
}