using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class AddStudentForm: Form
    {
        MainForm mainForm;
        List<int> scores;
        Student curStudent;

        public AddStudentForm(MainForm refMainForm, Student refStudent)
        {
            InitializeComponent();

            mainForm = refMainForm;
            scores = new List<int>();
            curStudent = refStudent;
        }

        // Handle Add Score Button Click
        private void Btn_AddScore_Click(object sender, EventArgs e)
        {
            
            if(Txt_Score.Text != string.Empty)
            {
                if (IsNumeric(Txt_Score.Text))
                {
                    int value = int.Parse(Txt_Score.Text);

                    if (value >= 0 && value < 101)
                    {
                        scores.Add(value);
                        UpdateScoresDisplay();
                    }
                    else
                    {
                        MessageBox.Show("Score must be between 0 and 100.", "Input Error - Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("You have entered invalid input.", "Input Error - Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Score value connot be empty.", "Input Error - Input Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Txt_Score.Clear();
        }

        // Handle Ok Button Click
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if(Txt_Name.Text != string.Empty)
            {
                mainForm.InsertUpdateStudentList(new Student(Txt_Name.Text, scores));
                Dispose();
            }
            else
            {
                MessageBox.Show("Name value connot be empty.", "Input Error - Input Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle Clear Scores Button Click
        private void Btn_ClearScores_Click(object sender, EventArgs e)
        {
            scores.Clear();
            UpdateScoresDisplay();
        }

        // Handle Cancel Button Click
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            curStudent = null;
            scores = null;
            Dispose();
        }

        // Updates the scores text field
        private void UpdateScoresDisplay()
        {
            Txt_Scores.Clear();
            Txt_Scores.Text = DisplayScores();
        }

        // Displays all the current scores
        private string DisplayScores()
        {
            string output = "";

            foreach (var score in scores)
            {
                output += score.ToString() + " ";
            }

            return output;
        }

        // Helper method to check numeric values in strings
        public static bool IsNumeric(string input)
        {
            int number;
            return int.TryParse(input, out number);
        }


    }
}
