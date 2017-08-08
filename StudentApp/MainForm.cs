using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class MainForm : Form
    {
        // Variables
        BindingList<Student> students;
        Student selectedStudent;

        // Constructor
        public MainForm()
        {
            InitializeComponent();
            
            UpdateDataSource();
            selectedStudent = null;

            List_Students.ClearSelected();
        }

        // Assigns and Updates DateBindings
        public void UpdateDataSource()
        {
            // Reads students list from file
            students = StudentsDB.GetStudents();

            List_Students.DataSource = null;
            List_Students.DataSource = students;
            List_Students.DisplayMember = "DisplayName";
        }

        // Handle index change event on Listbox
        private void List_Students_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current student
            selectedStudent = (Student)List_Students.SelectedItem;

            if (selectedStudent != null)
            {
                // Populate textfields with values
                Txt_TotalScore.Text = selectedStudent.GetTotalScore();
                Txt_NumOfScores.Text = selectedStudent.GetScoreCount();
                Txt_AvgScore.Text = selectedStudent.GetAverageScore();

                Btn_UpdateScores.Enabled = true;
                Btn_DelStudent.Enabled = true;
            }
            else
            {
                // Clear values if no students selected
                Txt_TotalScore.Clear();
                Txt_NumOfScores.Clear();
                Txt_AvgScore.Clear();

                Btn_UpdateScores.Enabled = false;
                Btn_DelStudent.Enabled = false;
            }
        }

        // Handle Exit Button Click
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        // Handle Add student Button Click
        private void Btn_AddStudent_Click(object sender, EventArgs e)
        {
            new AddStudentForm(this, selectedStudent).Show();
        }

        // Handle Update scores Button Click
        private void Btn_UpdateScores_Click(object sender, EventArgs e)
        {
            if(selectedStudent == null)
            {
                return;
            }
            new UpdateStudentScoresForm(this, selectedStudent).Show();
        }

        // Handle Delete Button Click
        private void Btn_DelStudent_Click(object sender, EventArgs e)
        {
            students.Remove(selectedStudent);

            StudentsDB.SaveStudents(students);

            List_Students.ClearSelected();

            
        }

        // Adds new student to the list
        public void InsertUpdateStudentList(Student newStudent)
        {
            students.Add(newStudent);

            StudentsDB.SaveStudents(students);

            UpdateDataSource();
            List_Students.SetSelected(0, true);

            
        }

        // Updates student scores
        public void UpdateStudentScoresList(Student studentToUpdate, BindingList<int> newScores)
        {
            studentToUpdate.Scores = newScores;

            StudentsDB.SaveStudents(students);

            UpdateDataSource();
            List_Students.ClearSelected();

        }

    }
}
