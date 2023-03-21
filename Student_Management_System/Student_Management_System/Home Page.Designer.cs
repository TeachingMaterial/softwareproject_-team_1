namespace Student_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Fees_button = new System.Windows.Forms.Button();
            this.studentpro_button = new System.Windows.Forms.Button();
            this.attendance_button = new System.Windows.Forms.Button();
            this.timetab_button = new System.Windows.Forms.Button();
            this.course_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 74);
            this.label1.TabIndex = 6;
            this.label1.Text = "Learning Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(954, 630);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 100);
            this.button6.TabIndex = 7;
            this.button6.Text = "LOG OUT";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Fees_button
            // 
            this.Fees_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Fees_button.BackgroundImage = global::Student_Management_System.Properties.Resources.fees_removebg_preview;
            this.Fees_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Fees_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fees_button.Location = new System.Drawing.Point(50, 400);
            this.Fees_button.Name = "Fees_button";
            this.Fees_button.Size = new System.Drawing.Size(300, 150);
            this.Fees_button.TabIndex = 3;
            this.Fees_button.Text = "Fees";
            this.Fees_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fees_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Fees_button.UseVisualStyleBackColor = false;
            this.Fees_button.Click += new System.EventHandler(this.button4_Click);
            this.Fees_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // studentpro_button
            // 
            this.studentpro_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentpro_button.BackgroundImage = global::Student_Management_System.Properties.Resources.profile_removebg_preview;
            this.studentpro_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.studentpro_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentpro_button.Location = new System.Drawing.Point(450, 400);
            this.studentpro_button.Name = "studentpro_button";
            this.studentpro_button.Size = new System.Drawing.Size(300, 150);
            this.studentpro_button.TabIndex = 4;
            this.studentpro_button.Text = "Student Profile";
            this.studentpro_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentpro_button.UseVisualStyleBackColor = false;
            this.studentpro_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // attendance_button
            // 
            this.attendance_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            //this.attendance_button.BackgroundImage = global::Student_Management_System.Properties.Resources.attendance_removebg_preview__1_1;
            this.attendance_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.attendance_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance_button.Location = new System.Drawing.Point(850, 175);
            this.attendance_button.Name = "attendance_button";
            this.attendance_button.Size = new System.Drawing.Size(300, 150);
            this.attendance_button.TabIndex = 2;
            this.attendance_button.Text = "Attendance";
            this.attendance_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attendance_button.UseVisualStyleBackColor = false;
            // 
            // timetab_button
            // 
            this.timetab_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.timetab_button.BackgroundImage = global::Student_Management_System.Properties.Resources.Timetable_removebg_preview;
            this.timetab_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.timetab_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetab_button.Location = new System.Drawing.Point(450, 175);
            this.timetab_button.Name = "timetab_button";
            this.timetab_button.Size = new System.Drawing.Size(300, 150);
            this.timetab_button.TabIndex = 1;
            this.timetab_button.Text = "Time table";
            this.timetab_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.timetab_button.UseVisualStyleBackColor = false;
            this.timetab_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // course_button
            // 
            this.course_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.course_button.BackgroundImage = global::Student_Management_System.Properties.Resources.courses_removebg_preview1;
            this.course_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.course_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.course_button.Location = new System.Drawing.Point(50, 175);
            this.course_button.Name = "course_button";
            this.course_button.Size = new System.Drawing.Size(300, 150);
            this.course_button.TabIndex = 0;
            this.course_button.Text = "Course";
            this.course_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.course_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.course_button.UseVisualStyleBackColor = false;
            this.course_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Fees_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentpro_button);
            this.Controls.Add(this.attendance_button);
            this.Controls.Add(this.timetab_button);
            this.Controls.Add(this.course_button);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button studentpro_button;
    }
}

