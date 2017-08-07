using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class UpdateStudentScoresForm : Form
    {
        // Variables
        public MainForm mainForm;
        public Student student;
        public BindingList<int> scoresCopy;
        public int selectedScore;
        public int selectedIndex;
        public int lastSelectedIndex;


        // Constructor
        public UpdateStudentScoresForm(MainForm refMainForm, Student refStudent)
        {
            InitializeComponent();

            mainForm = refMainForm;
            student = refStudent;
            selectedScore = 0;
            selectedIndex = 0;
            lastSelectedIndex = 0;

            Txt_Name.Text = student.Name;
            scoresCopy = new BindingList<int>();

            // BUGFIX: created a new list and passed in the values one by one
            foreach(int score in refStudent.Scores)
            {
                scoresCopy.Add(score);
            }


            List_Scores.DataSource = scoresCopy;
        }

        // Handle index change event on Listbox
        private void List_Scores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = List_Scores.SelectedIndex;

            if(selectedIndex != -1)
            {
                lastSelectedIndex = selectedIndex;
                selectedScore = (int)List_Scores.SelectedItem;
                DisableButtons(true);
            }
            else
            {
                DisableButtons(false);
            }

        }

        // Disable and Enable Buttons
        public void DisableButtons(bool active)
        {
            Btn_Update.Enabled = active;
            Btn_Remove.Enabled = active;
        }

        // Handle Cancel Button Click
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        // Handle OK Button Click
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStudentScoresList(student, scoresCopy);
            Dispose();
        }

        // Handle Remove score Button Click
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            scoresCopy.Remove(selectedScore);
            List_Scores.ClearSelected();
        }

        // Handle Clear scores Button Click
        private void Btn_ClearScores_Click(object sender, EventArgs e)
        {
            scoresCopy.Clear();
        }

        // Handle Add and Update score Button Clicks
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            bool IsAddBtn = false;

            if(temp == Btn_Add)
            {
                IsAddBtn = true;
            }

            new AddUpdateScoreForm(this, IsAddBtn, lastSelectedIndex).Show();
        }
    }
}
