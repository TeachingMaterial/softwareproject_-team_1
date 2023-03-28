namespace Student_Management_System
{
    partial class Home
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

            this.homehead_label = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();

            this.Fees_button = new System.Windows.Forms.Button();
            this.studentpro_button = new System.Windows.Forms.Button();
            this.attendance_button = new System.Windows.Forms.Button();
            this.timetab_button = new System.Windows.Forms.Button();
            this.course_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 

            // homehead_label
            // 
            this.homehead_label.AutoSize = true;
            this.homehead_label.BackColor = System.Drawing.SystemColors.Window;
            this.homehead_label.Font = new System.Drawing.Font("Calisto MT", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homehead_label.Location = new System.Drawing.Point(339, 78);
            this.homehead_label.Name = "homehead_label";
            this.homehead_label.Size = new System.Drawing.Size(512, 74);
            this.homehead_label.TabIndex = 6;
            this.homehead_label.Text = "Learning Portal";
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logout_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Location = new System.Drawing.Point(960, 741);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(200, 100);
            this.logout_button.TabIndex = 7;
            this.logout_button.Text = "LOG OUT";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.Logoutbtn_Click);

            // 
            // Fees_button
            // 
            this.Fees_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Fees_button.BackgroundImage = global::Student_Management_System.Properties.Resources.fees_removebg_preview;
            this.Fees_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Fees_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            this.Fees_button.Location = new System.Drawing.Point(254, 466);

            this.Fees_button.Name = "Fees_button";
            this.Fees_button.Size = new System.Drawing.Size(300, 150);
            this.Fees_button.TabIndex = 3;
            this.Fees_button.Text = "Fees";
            this.Fees_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fees_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Fees_button.UseVisualStyleBackColor = false;
            this.Fees_button.Click += new System.EventHandler(this.Feesbtn_Click);
            // 
            // studentpro_button
            // 
            this.studentpro_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentpro_button.BackgroundImage = global::Student_Management_System.Properties.Resources.profile_removebg_preview;
            this.studentpro_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.studentpro_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.studentpro_button.Location = new System.Drawing.Point(702, 466);

            this.studentpro_button.Name = "studentpro_button";
            this.studentpro_button.Size = new System.Drawing.Size(300, 150);
            this.studentpro_button.TabIndex = 4;
            this.studentpro_button.Text = "Student Profile";
            this.studentpro_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentpro_button.UseVisualStyleBackColor = false;
            this.studentpro_button.Click += new System.EventHandler(this.Profilebtn_Click);
            // 
            // attendance_button
            // 
            this.attendance_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.attendance_button.BackgroundImage = global::Student_Management_System.Properties.Resources.attendance_removebg_preview__1_;
            this.attendance_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.attendance_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.attendance_button.Location = new System.Drawing.Point(849, 244);

            this.attendance_button.Name = "attendance_button";
            this.attendance_button.Size = new System.Drawing.Size(300, 150);
            this.attendance_button.TabIndex = 2;
            this.attendance_button.Text = "Attendance";
            this.attendance_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attendance_button.UseVisualStyleBackColor = false;
            this.attendance_button.Click += new System.EventHandler(this.Attendancebtn_Click);
            // 
            // timetab_button
            // 
            this.timetab_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.timetab_button.BackgroundImage = global::Student_Management_System.Properties.Resources.Timetable_removebg_preview;
            this.timetab_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.timetab_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<
            this.timetab_button.Location = new System.Drawing.Point(449, 244);
            this.timetab_button.Name = "timetab_button";
            this.timetab_button.Size = new System.Drawing.Size(300, 150);
            this.timetab_button.TabIndex = 1;
            this.timetab_button.Text = "Time Table";

            this.timetab_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.timetab_button.UseVisualStyleBackColor = false;
            this.timetab_button.Click += new System.EventHandler(this.Timetablebtn_Click);
            // 
            // course_button
            // 
            this.course_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.course_button.BackgroundImage = global::Student_Management_System.Properties.Resources.courses_removebg_preview1;
            this.course_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.course_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_button.ForeColor = System.Drawing.SystemColors.ControlText;

            this.course_button.Location = new System.Drawing.Point(49, 244);

            this.course_button.Name = "course_button";
            this.course_button.Size = new System.Drawing.Size(300, 150);
            this.course_button.TabIndex = 0;
            this.course_button.Text = "Course";
            this.course_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.course_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.course_button.UseVisualStyleBackColor = false;
            this.course_button.Click += new System.EventHandler(this.Coursebtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;

            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.Fees_button);
            this.Controls.Add(this.homehead_label);

            this.Controls.Add(this.studentpro_button);
            this.Controls.Add(this.attendance_button);
            this.Controls.Add(this.timetab_button);
            this.Controls.Add(this.course_button);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button course_button;
        private System.Windows.Forms.Button timetab_button;
        private System.Windows.Forms.Button attendance_button;
        private System.Windows.Forms.Button Fees_button;

        private System.Windows.Forms.Label homehead_label;
        private System.Windows.Forms.Button logout_button;

        private System.Windows.Forms.Button studentpro_button;
    }
}

