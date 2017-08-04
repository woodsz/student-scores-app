namespace StudentApp
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
            this.Btn_AddStudent = new System.Windows.Forms.Button();
            this.List_Students = new System.Windows.Forms.ListBox();
            this.Btn_UpdateScores = new System.Windows.Forms.Button();
            this.Btn_DelStudent = new System.Windows.Forms.Button();
            this.Txt_TotalScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NumOfScores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_AvgScore = new System.Windows.Forms.TextBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_AddStudent
            // 
            this.Btn_AddStudent.Location = new System.Drawing.Point(265, 39);
            this.Btn_AddStudent.Name = "Btn_AddStudent";
            this.Btn_AddStudent.Size = new System.Drawing.Size(90, 23);
            this.Btn_AddStudent.TabIndex = 1;
            this.Btn_AddStudent.Text = "Add...";
            this.Btn_AddStudent.UseVisualStyleBackColor = true;
            this.Btn_AddStudent.Click += new System.EventHandler(this.Btn_AddStudent_Click);
            // 
            // List_Students
            // 
            this.List_Students.FormattingEnabled = true;
            this.List_Students.Location = new System.Drawing.Point(12, 39);
            this.List_Students.Name = "List_Students";
            this.List_Students.Size = new System.Drawing.Size(247, 134);
            this.List_Students.TabIndex = 0;
            this.List_Students.SelectedIndexChanged += new System.EventHandler(this.List_Students_SelectedIndexChanged);
            // 
            // Btn_UpdateScores
            // 
            this.Btn_UpdateScores.Enabled = false;
            this.Btn_UpdateScores.Location = new System.Drawing.Point(265, 68);
            this.Btn_UpdateScores.Name = "Btn_UpdateScores";
            this.Btn_UpdateScores.Size = new System.Drawing.Size(90, 23);
            this.Btn_UpdateScores.TabIndex = 2;
            this.Btn_UpdateScores.Text = "Update...";
            this.Btn_UpdateScores.UseVisualStyleBackColor = true;
            this.Btn_UpdateScores.Click += new System.EventHandler(this.Btn_UpdateScores_Click);
            // 
            // Btn_DelStudent
            // 
            this.Btn_DelStudent.Enabled = false;
            this.Btn_DelStudent.Location = new System.Drawing.Point(265, 97);
            this.Btn_DelStudent.Name = "Btn_DelStudent";
            this.Btn_DelStudent.Size = new System.Drawing.Size(90, 23);
            this.Btn_DelStudent.TabIndex = 3;
            this.Btn_DelStudent.Text = "Delete...";
            this.Btn_DelStudent.UseVisualStyleBackColor = true;
            this.Btn_DelStudent.Click += new System.EventHandler(this.Btn_DelStudent_Click);
            // 
            // Txt_TotalScore
            // 
            this.Txt_TotalScore.Location = new System.Drawing.Point(204, 179);
            this.Txt_TotalScore.Name = "Txt_TotalScore";
            this.Txt_TotalScore.ReadOnly = true;
            this.Txt_TotalScore.Size = new System.Drawing.Size(55, 20);
            this.Txt_TotalScore.TabIndex = 4;
            this.Txt_TotalScore.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score count:";
            // 
            // Txt_NumOfScores
            // 
            this.Txt_NumOfScores.Location = new System.Drawing.Point(204, 205);
            this.Txt_NumOfScores.Name = "Txt_NumOfScores";
            this.Txt_NumOfScores.ReadOnly = true;
            this.Txt_NumOfScores.Size = new System.Drawing.Size(55, 20);
            this.Txt_NumOfScores.TabIndex = 6;
            this.Txt_NumOfScores.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Average:";
            // 
            // Txt_AvgScore
            // 
            this.Txt_AvgScore.Location = new System.Drawing.Point(204, 231);
            this.Txt_AvgScore.Name = "Txt_AvgScore";
            this.Txt_AvgScore.ReadOnly = true;
            this.Txt_AvgScore.Size = new System.Drawing.Size(55, 20);
            this.Txt_AvgScore.TabIndex = 8;
            this.Txt_AvgScore.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Exit.Location = new System.Drawing.Point(265, 228);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(90, 23);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Students:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Exit;
            this.ClientSize = new System.Drawing.Size(367, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_AvgScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_NumOfScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_TotalScore);
            this.Controls.Add(this.Btn_DelStudent);
            this.Controls.Add(this.Btn_UpdateScores);
            this.Controls.Add(this.List_Students);
            this.Controls.Add(this.Btn_AddStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddStudent;
        private System.Windows.Forms.ListBox List_Students;
        private System.Windows.Forms.Button Btn_UpdateScores;
        private System.Windows.Forms.Button Btn_DelStudent;
        private System.Windows.Forms.TextBox Txt_TotalScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NumOfScores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_AvgScore;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label4;
    }
}

