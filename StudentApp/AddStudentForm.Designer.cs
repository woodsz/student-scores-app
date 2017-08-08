namespace StudentApp
{
    partial class AddStudentForm
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
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_AddScore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Score = new System.Windows.Forms.TextBox();
            this.Txt_Scores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_ClearScores = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(78, 9);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(173, 20);
            this.Txt_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_AddScore
            // 
            this.Btn_AddScore.Location = new System.Drawing.Point(176, 33);
            this.Btn_AddScore.Name = "Btn_AddScore";
            this.Btn_AddScore.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddScore.TabIndex = 2;
            this.Btn_AddScore.Text = "Add Score";
            this.Btn_AddScore.UseVisualStyleBackColor = true;
            this.Btn_AddScore.Click += new System.EventHandler(this.Btn_AddScore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Score
            // 
            this.Txt_Score.Location = new System.Drawing.Point(78, 35);
            this.Txt_Score.Name = "Txt_Score";
            this.Txt_Score.Size = new System.Drawing.Size(64, 20);
            this.Txt_Score.TabIndex = 1;
            // 
            // Txt_Scores
            // 
            this.Txt_Scores.Location = new System.Drawing.Point(78, 61);
            this.Txt_Scores.Name = "Txt_Scores";
            this.Txt_Scores.ReadOnly = true;
            this.Txt_Scores.Size = new System.Drawing.Size(173, 20);
            this.Txt_Scores.TabIndex = 6;
            this.Txt_Scores.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scores:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_ClearScores
            // 
            this.Btn_ClearScores.Location = new System.Drawing.Point(176, 87);
            this.Btn_ClearScores.Name = "Btn_ClearScores";
            this.Btn_ClearScores.Size = new System.Drawing.Size(75, 23);
            this.Btn_ClearScores.TabIndex = 3;
            this.Btn_ClearScores.Text = "Clear Scores";
            this.Btn_ClearScores.UseVisualStyleBackColor = true;
            this.Btn_ClearScores.Click += new System.EventHandler(this.Btn_ClearScores_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(95, 142);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 4;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(176, 142);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 180);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Btn_ClearScores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Scores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Score);
            this.Controls.Add(this.Btn_AddScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_AddScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Score;
        private System.Windows.Forms.TextBox Txt_Scores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_ClearScores;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}