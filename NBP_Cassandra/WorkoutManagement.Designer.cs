namespace NBP_Cassandra
{
    partial class WorkoutManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBy = new System.Windows.Forms.GroupBox();
            this.radDate = new System.Windows.Forms.RadioButton();
            this.radWorkoutID = new System.Windows.Forms.RadioButton();
            this.radMemberID = new System.Windows.Forms.RadioButton();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbExercise = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.radGet = new System.Windows.Forms.RadioButton();
            this.radDel = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkoutID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGym = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataWorkouts = new System.Windows.Forms.DataGridView();
            this.btnAllWorkouts = new System.Windows.Forms.Button();
            this.WorkoutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpBy.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkouts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpBy);
            this.groupBox1.Controls.Add(this.btnGenerateID);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.cmbExercise);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.radGet);
            this.groupBox1.Controls.Add(this.radDel);
            this.groupBox1.Controls.Add(this.radAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWorkoutID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGym);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMemberID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 354);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workouts";
            // 
            // grpBy
            // 
            this.grpBy.Controls.Add(this.radDate);
            this.grpBy.Controls.Add(this.radWorkoutID);
            this.grpBy.Controls.Add(this.radMemberID);
            this.grpBy.Location = new System.Drawing.Point(127, 0);
            this.grpBy.Name = "grpBy";
            this.grpBy.Size = new System.Drawing.Size(104, 93);
            this.grpBy.TabIndex = 21;
            this.grpBy.TabStop = false;
            this.grpBy.Text = "Get by";
            this.grpBy.Visible = false;
            // 
            // radDate
            // 
            this.radDate.AutoSize = true;
            this.radDate.Location = new System.Drawing.Point(6, 65);
            this.radDate.Name = "radDate";
            this.radDate.Size = new System.Drawing.Size(48, 17);
            this.radDate.TabIndex = 2;
            this.radDate.TabStop = true;
            this.radDate.Text = "Date";
            this.radDate.UseVisualStyleBackColor = true;
            this.radDate.CheckedChanged += new System.EventHandler(this.radDate_CheckedChanged);
            // 
            // radWorkoutID
            // 
            this.radWorkoutID.AutoSize = true;
            this.radWorkoutID.Location = new System.Drawing.Point(6, 19);
            this.radWorkoutID.Name = "radWorkoutID";
            this.radWorkoutID.Size = new System.Drawing.Size(80, 17);
            this.radWorkoutID.TabIndex = 31;
            this.radWorkoutID.TabStop = true;
            this.radWorkoutID.Text = "Workout ID";
            this.radWorkoutID.UseVisualStyleBackColor = true;
            this.radWorkoutID.CheckedChanged += new System.EventHandler(this.radWorkoutID_CheckedChanged);
            // 
            // radMemberID
            // 
            this.radMemberID.AutoSize = true;
            this.radMemberID.Location = new System.Drawing.Point(6, 42);
            this.radMemberID.Name = "radMemberID";
            this.radMemberID.Size = new System.Drawing.Size(77, 17);
            this.radMemberID.TabIndex = 1;
            this.radMemberID.TabStop = true;
            this.radMemberID.Text = "Member ID";
            this.radMemberID.UseVisualStyleBackColor = true;
            this.radMemberID.CheckedChanged += new System.EventHandler(this.radMemberID_CheckedChanged);
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
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yy";
            this.dtpDate.Location = new System.Drawing.Point(6, 218);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(118, 257);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(107, 20);
            this.dtpEnd.TabIndex = 9;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(6, 257);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(106, 20);
            this.dtpStart.TabIndex = 8;
            // 
            // cmbExercise
            // 
            this.cmbExercise.FormattingEnabled = true;
            this.cmbExercise.Items.AddRange(new object[] {
            "Chest",
            "Back",
            "Shoulders",
            "Triceps",
            "Biceps",
            "Forearms",
            "Abs",
            "Legs",
            "Cardio",
            "Other"});
            this.cmbExercise.Location = new System.Drawing.Point(6, 296);
            this.cmbExercise.Name = "cmbExercise";
            this.cmbExercise.Size = new System.Drawing.Size(219, 21);
            this.cmbExercise.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Exercise:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(6, 323);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // radGet
            // 
            this.radGet.AutoSize = true;
            this.radGet.Location = new System.Drawing.Point(6, 42);
            this.radGet.Name = "radGet";
            this.radGet.Size = new System.Drawing.Size(86, 17);
            this.radGet.TabIndex = 1;
            this.radGet.TabStop = true;
            this.radGet.Text = "Get Workout";
            this.radGet.UseVisualStyleBackColor = true;
            this.radGet.CheckedChanged += new System.EventHandler(this.radGet_CheckedChanged);
            // 
            // radDel
            // 
            this.radDel.AutoSize = true;
            this.radDel.Location = new System.Drawing.Point(6, 65);
            this.radDel.Name = "radDel";
            this.radDel.Size = new System.Drawing.Size(100, 17);
            this.radDel.TabIndex = 2;
            this.radDel.TabStop = true;
            this.radDel.Text = "Delete Workout";
            this.radDel.UseVisualStyleBackColor = true;
            this.radDel.CheckedChanged += new System.EventHandler(this.radDel_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(6, 19);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(88, 17);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add Workout";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "End Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Workout ID:";
            // 
            // txtWorkoutID
            // 
            this.txtWorkoutID.Location = new System.Drawing.Point(6, 101);
            this.txtWorkoutID.Name = "txtWorkoutID";
            this.txtWorkoutID.Size = new System.Drawing.Size(138, 20);
            this.txtWorkoutID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gym:";
            // 
            // txtGym
            // 
            this.txtGym.Location = new System.Drawing.Point(6, 179);
            this.txtGym.Name = "txtGym";
            this.txtGym.Size = new System.Drawing.Size(219, 20);
            this.txtGym.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(6, 140);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(219, 20);
            this.txtMemberID.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataWorkouts);
            this.groupBox4.Controls.Add(this.btnAllWorkouts);
            this.groupBox4.Location = new System.Drawing.Point(249, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(646, 354);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All Workouts";
            // 
            // dataWorkouts
            // 
            this.dataWorkouts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkoutID,
            this.MemberID,
            this.Gym,
            this.Date,
            this.Start,
            this.End,
            this.Exercise});
            this.dataWorkouts.Location = new System.Drawing.Point(118, 16);
            this.dataWorkouts.Name = "dataWorkouts";
            this.dataWorkouts.RowHeadersWidth = 24;
            this.dataWorkouts.Size = new System.Drawing.Size(522, 330);
            this.dataWorkouts.TabIndex = 1;
            // 
            // btnAllWorkouts
            // 
            this.btnAllWorkouts.Location = new System.Drawing.Point(6, 19);
            this.btnAllWorkouts.Name = "btnAllWorkouts";
            this.btnAllWorkouts.Size = new System.Drawing.Size(106, 23);
            this.btnAllWorkouts.TabIndex = 0;
            this.btnAllWorkouts.Text = "Show All Workouts";
            this.btnAllWorkouts.UseVisualStyleBackColor = true;
            this.btnAllWorkouts.Click += new System.EventHandler(this.btnAllWorkouts_Click);
            // 
            // WorkoutID
            // 
            this.WorkoutID.HeaderText = "ID";
            this.WorkoutID.Name = "WorkoutID";
            this.WorkoutID.ReadOnly = true;
            this.WorkoutID.Width = 33;
            // 
            // MemberID
            // 
            this.MemberID.HeaderText = "Member ID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 50;
            // 
            // Gym
            // 
            this.Gym.HeaderText = "Gym";
            this.Gym.Name = "Gym";
            this.Gym.ReadOnly = true;
            this.Gym.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 54;
            // 
            // End
            // 
            this.End.HeaderText = "End";
            this.End.Name = "End";
            this.End.ReadOnly = true;
            this.End.Width = 54;
            // 
            // Exercise
            // 
            this.Exercise.HeaderText = "Exercise";
            this.Exercise.Name = "Exercise";
            this.Exercise.ReadOnly = true;
            this.Exercise.Width = 75;
            // 
            // WorkoutManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 376);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "WorkoutManagement";
            this.Text = "Workout Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBy.ResumeLayout(false);
            this.grpBy.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkouts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton radGet;
        private System.Windows.Forms.RadioButton radDel;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkoutID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGym;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.ComboBox cmbExercise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataWorkouts;
        private System.Windows.Forms.Button btnAllWorkouts;
        private System.Windows.Forms.GroupBox grpBy;
        private System.Windows.Forms.RadioButton radDate;
        private System.Windows.Forms.RadioButton radWorkoutID;
        private System.Windows.Forms.RadioButton radMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkoutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gym;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercise;
    }
}