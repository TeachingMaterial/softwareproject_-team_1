namespace Student_Management_System
{
    partial class Attendance
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassAttended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLectures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendancePercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "My Attendance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleID,
            this.ModuleName,
            this.ClassAttended,
            this.TotalLectures,
            this.AttendancePercentage});
            this.dataGridView1.Location = new System.Drawing.Point(229, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 795);
            this.dataGridView1.TabIndex = 1;
            // 
            // ModuleID
            // 
            this.ModuleID.HeaderText = "Module ID";
            this.ModuleID.MinimumWidth = 6;
            this.ModuleID.Name = "ModuleID";
            this.ModuleID.Width = 97;
            // 
            // ModuleName
            // 
            this.ModuleName.HeaderText = "Module Name";
            this.ModuleName.MinimumWidth = 6;
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Width = 125;
            // 
            // ClassAttended
            // 
            this.ClassAttended.HeaderText = "Class Attended";
            this.ClassAttended.MinimumWidth = 6;
            this.ClassAttended.Name = "ClassAttended";
            this.ClassAttended.Width = 125;
            // 
            // TotalLectures
            // 
            this.TotalLectures.HeaderText = "Total Lectures";
            this.TotalLectures.MinimumWidth = 6;
            this.TotalLectures.Name = "TotalLectures";
            this.TotalLectures.Width = 125;
            // 
            // AttendancePercentage
            // 
            this.AttendancePercentage.HeaderText = "Attendance Percentage";
            this.AttendancePercentage.MinimumWidth = 6;
            this.AttendancePercentage.Name = "AttendancePercentage";
            this.AttendancePercentage.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(970, 741);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassAttended;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLectures;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendancePercentage;
        private System.Windows.Forms.Button button1;
    }
}

