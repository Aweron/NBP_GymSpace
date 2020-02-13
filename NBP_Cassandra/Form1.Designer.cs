namespace NBP_Cassandra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManageMember = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGyms = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnManageWorkout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnManageMember);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members";
            // 
            // btnManageMember
            // 
            this.btnManageMember.Location = new System.Drawing.Point(6, 19);
            this.btnManageMember.Name = "btnManageMember";
            this.btnManageMember.Size = new System.Drawing.Size(106, 37);
            this.btnManageMember.TabIndex = 0;
            this.btnManageMember.Text = "Manage Members";
            this.btnManageMember.UseVisualStyleBackColor = true;
            this.btnManageMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGyms);
            this.groupBox2.Location = new System.Drawing.Point(138, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gyms";
            // 
            // btnGyms
            // 
            this.btnGyms.Location = new System.Drawing.Point(6, 19);
            this.btnGyms.Name = "btnGyms";
            this.btnGyms.Size = new System.Drawing.Size(106, 37);
            this.btnGyms.TabIndex = 0;
            this.btnGyms.Text = "Manage Gyms";
            this.btnGyms.UseVisualStyleBackColor = true;
            this.btnGyms.Click += new System.EventHandler(this.btnGyms_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnManageWorkout);
            this.groupBox3.Location = new System.Drawing.Point(264, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 66);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Workouts";
            // 
            // btnManageWorkout
            // 
            this.btnManageWorkout.Location = new System.Drawing.Point(6, 19);
            this.btnManageWorkout.Name = "btnManageWorkout";
            this.btnManageWorkout.Size = new System.Drawing.Size(106, 37);
            this.btnManageWorkout.TabIndex = 0;
            this.btnManageWorkout.Text = "Manage Workouts";
            this.btnManageWorkout.UseVisualStyleBackColor = true;
            this.btnManageWorkout.Click += new System.EventHandler(this.btnManageWorkout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 89);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGyms;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnManageWorkout;
    }
}

