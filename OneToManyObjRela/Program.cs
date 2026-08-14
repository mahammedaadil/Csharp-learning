using System;
using System.Collections.Generic;
using College;
using ExamSpace;

namespace OneToManyObjRela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();

            Console.WriteLine("Enter StudentId:");
            stud.SID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter StudentName:");
            stud.SName = Console.ReadLine();


            stud.Sexam = new List<Exam>();

            string choice;
            do
            {
                Console.WriteLine("Enter SubjectCode:");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubjectName:");
                string subName = Console.ReadLine();
                Console.WriteLine("Enter SubjectMarks:");
                int subMarks = int.Parse(Console.ReadLine());

                Exam exam = new Exam
                {
                    
                    SubCode=code,
                    SubName=subName,
                    SubMarks=subMarks
                };

                stud.Sexam.Add(exam);

                Console.WriteLine("Write STOP to Stop Adding New Subject Marks:");   
                choice = Console.ReadLine().ToUpper();
            } while (choice != "STOP");

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"ID:{stud.SID} Name:{stud.SName} ");

            foreach(Exam item in stud.Sexam)
            {
                Console.WriteLine($"SubjectCode:{item.SubCode} SubjectName:{item.SubName} SubjectMarks:{item.SubMarks}");
            }
        }
    }
}
