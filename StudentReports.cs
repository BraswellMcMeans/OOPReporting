using System;
namespace FileHandling
{
    public class StudentReports
    {
        private Student[] myStudents;

        public StudentReports(Student[] myStudents)
        {
            this.myStudents = myStudents;
        }

        public void PrintAllStudents()
        {
            for(int i = 0; i < Student.GetCount(); i++)
            {
                Console.WriteLine(myStudents[i].ToString());
            }
        }
    }
}