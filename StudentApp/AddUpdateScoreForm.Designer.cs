namespace StudentApp
{
    partial class AddUpdateScoreForm
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
            this.Txt_Score = new System.Windows.Forms.TextBox();
            this.Btn_AddUpdate = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: ";
            // 
            // Txt_Score
            // 
            this.Txt_Score.Location = new System.Drawing.Point(80, 22);
            this.Txt_Score.Name = "Txt_Score";
            this.Txt_Score.Size = new System.Drawing.Size(48, 20);
            this.Txt_Score.TabIndex = 0;
            // 
            // Btn_AddUpdate
            // 
            this.Btn_AddUpdate.Location = new System.Drawing.Point(13, 58);
            this.Btn_AddUpdate.Name = "Btn_AddUpdate";
            this.Btn_AddUpdate.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddUpdate.TabIndex = 1;
            this.Btn_AddUpdate.Text = "Default";
            this.Btn_AddUpdate.UseVisualStyleBackColor = true;
            this.Btn_AddUpdate.Click += new System.EventHandler(this.Btn_AddUpdate_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(94, 58);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // AddUpdateScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 96);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_AddUpdate);
            this.Controls.Add(this.Txt_Score);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUpdateScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateScoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Score;
        private System.Windows.Forms.Button Btn_AddUpdate;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}