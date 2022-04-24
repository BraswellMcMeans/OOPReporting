using System;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentFile myDataHandler = new StudentFile("students.txt");

            Student[] myStudents = myDataHandler.GetAllStudents();

            StudentReports reports = new StudentReports(myStudents);

            reports.PrintAllStudents();

            Utility myUtility = new Utility(myStudents);

            myUtility.Sort();

            System.Console.WriteLine("After sort -------------------------");

            reports.PrintAllStudents();

            string searchVal = "Makayla Townsend";

            int found = myUtility.Search(searchVal);
            if(found != -1)
            {
                System.Console.WriteLine("What should the credit hours be?");
                int updatedHours = int.Parse(Console.ReadLine());
                myStudents[found].SetCreditHours(updatedHours);
            }

            myDataHandler.Save(myStudents);
        }
    }
}
