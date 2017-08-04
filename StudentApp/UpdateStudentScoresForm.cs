using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class UpdateStudentScoresForm : Form
    {
        MainForm mainForm;
        Student student;
        BindingList<int> scoresCopy;
        int selectedScore;


        public UpdateStudentScoresForm(MainForm refMainForm, Student refStudent)
        {
            InitializeComponent();

            mainForm = refMainForm;
            student = refStudent;
            selectedScore = 0;

            Txt_Name.Text = student.Name;
            scoresCopy = student.Scores;
            List_Scores.DataSource = scoresCopy;

            scoresCopy.Add(100);

        }

        // Handle index change event on Listbox
        private void List_Scores_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedScore = (int)List_Scores.SelectedItem;
        }

        // Handle Cancel Button Click
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        // Handle OK Button Click
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            student.Scores = scoresCopy;
            mainForm.UpdateDataSource();
            Dispose();
        }
    }
}
