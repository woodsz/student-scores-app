using System;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class AddUpdateScoreForm : Form
    {
        // Variable
        UpdateStudentScoresForm usForm;
        int index;
        bool Adding;

        // Constructor
        public AddUpdateScoreForm(UpdateStudentScoresForm refForm, bool IsAddBtn, int refIndex)
        {
            InitializeComponent();
            usForm = refForm;
            index = refIndex;
            Adding = IsAddBtn;

            if (Adding)
            {
                Text = "Add Score Form";
                Btn_AddUpdate.Text = "Add";
            }
            else
            {
                Text = "Update Score Form";
                Btn_AddUpdate.Text = "Update";
                Txt_Score.Text = usForm.scoresCopy[index].ToString();
            }

            

        }

        // Handle Cancel Button Click
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Btn_AddUpdate_Click(object sender, EventArgs e)
        {
            int newScore = int.Parse(Txt_Score.Text);


            if (Adding)
            {
                usForm.scoresCopy.Add(newScore);
            }
            else
            {
                usForm.scoresCopy[index] = newScore;
            }

            Dispose();
        }
    }
}
