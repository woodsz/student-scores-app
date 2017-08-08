using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StudentApp
{
    class StudentsDB
    {

        private const string dir = @"C:\C#.NET\Files\";
        private const string path = dir + "StudentsScores.txt";


        // Reads a file and creates a BindingList<Student>
        public static BindingList<Student> GetStudents()
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            StreamReader textIn = new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            BindingList<Student> students = new BindingList<Student>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                if (row.Contains('|'))
                {
                    string[] columns = row.Split('|');
                    Student student = new Student();
                    student.Name = columns[0];
                    student.Scores = new BindingList<int>(columns[1].Split(',').Select(int.Parse).ToList());
                    students.Add(student);
                }
                else
                {
                    Console.WriteLine("No students in file");
                }
                
            }

            textIn.Close();
            return students;

        }

        // Saves student list to a file
        public static void SaveStudents(BindingList<Student> students)
        {
            StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach(Student student in students)
            {
                textOut.Write(student.Name + '|');
                textOut.WriteLine(student.DisplayScores());
            }

            textOut.Close();
        }

    }
}
