using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace StudentApp
{
    public class Student
    {
        // Properties
        public string Name { get; set; }
        public BindingList<int> Scores { get; set; }

        // Display name for list box
        public string DisplayName
        {
            get
            {
                return Name + "\t" + DisplayScores();
            }
        }

        // Constructor
        public Student(string name, List<int> scores = null)
        {
            this.Name = name;
            this.Scores = new BindingList<int>(scores);
        }

        // Print out scores
        public string DisplayScores()
        {
            if (Scores == null)
                return "";

            string scoreText = "";

            for (int i = 0; i < Scores.Count; i++)
            {
                if (i > 0)
                {
                    scoreText += ", " + Scores[i];
                }
                else
                {
                    scoreText += Scores[i];
                }
            }

            scoreText = scoreText.Trim();

            return scoreText;
        }

        // Print total scores
        public string GetTotalScore()
        {
            if (Scores.Count() > 1)
            {
                return Scores.Sum().ToString(); 
            }

            return "";
        }

        // Print count of scores
        public string GetScoreCount()
        {
            return Scores.Count.ToString();
        }

        // Print average score
        public string GetAverageScore()
        {
            if(Scores.Count() > 1)
            {
                return Scores.Average().ToString();

            }

            return "";
        }
    }
}
