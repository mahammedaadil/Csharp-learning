using System;
using System.Collections.Generic;
using SchoolSpace;
using SubSpace;

namespace GradeSystem
{
    internal class Program
    {
        List<double> graceEligibilityList = new List<double>();
        double maxGraceMarks = 10;
        double totalGraceMarksCheck = 0;
        public void SchoolInput(School schoolObj)
        {
            Console.WriteLine($"Welcome To {schoolObj.SchoolName}");
            Console.Write("Enter Your ClassName:");
            schoolObj.ClassName = int.Parse(Console.ReadLine());
        }
        public void StudentInput(Student studentObj)
        {
            Console.Write("Enter Student Name:");
            studentObj.StudentName = Console.ReadLine();
        }
        public void MarksInput(Subjects subObj)
        {
            Console.Write("Enter Hindi Marks:");
            subObj.Hindi = double.Parse(Console.ReadLine());
            if (subObj.Hindi > 100 || subObj.Hindi < 0)
            {
                return;
            }
            CheckGraceEligibility(subObj.Hindi);

            Console.Write("Enter English Marks:");
            subObj.English = double.Parse(Console.ReadLine());
            if (subObj.English > 100 || subObj.English < 0)
            {
                return;
            }
            CheckGraceEligibility(subObj.English);

            Console.Write("Enter Maths  Marks:");
            subObj.Maths = double.Parse(Console.ReadLine());
            if (subObj.Maths > 100 || subObj.Maths < 0)
            {
                return;
            }
            CheckGraceEligibility(subObj.Maths);

            Console.Write("Enter SocialScience  Marks:");
            subObj.SocialScience = double.Parse(Console.ReadLine());
            if (subObj.SocialScience > 100 || subObj.SocialScience < 0)
            {
                return;
            }
            CheckGraceEligibility(subObj.SocialScience);

            Console.Write("Enter Science  Marks:");
            subObj.Science = double.Parse(Console.ReadLine());
            if (subObj.Science > 100 || subObj.Science < 0)
            {
                return;
            }
            CheckGraceEligibility(subObj.Science);

            Console.Clear();


        }
        public void CheckGraceEligibility(double marks)
        {
            if (marks >= 25 && marks < 35)
            {
                graceEligibilityList.Add(marks);
                double requiredGrace = 35 - marks;
                maxGraceMarks -= requiredGrace;
            }

        }
        public string GetGrade(double marks)
        {
            string grade = "";
            if (marks >= 90)
            {
                grade = "A+";
            }
            else if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 70)
            {
                grade = "B+";
            }
            else if (marks >= 60)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C+";
            }
            else if (marks >= 40)
            {
                grade = "C";
            }
            else if(marks >= 35)
            {
                grade = "E";
            } else
            {
                grade = "F";
            }
            return grade;
        }
        public double GetGrace(double marks)
        {
            double passingMarks = 35;
            double minimumMarks = 25;
            double graceMarks = 0;
            int graceCount = graceEligibilityList.Count;

            if (marks < minimumMarks || graceCount > 2)
            {
                return -1;
            }
            if (marks < passingMarks)
            {
                if (maxGraceMarks < 0) return -1;
                graceMarks = passingMarks - marks;
                totalGraceMarksCheck += graceMarks;
                return graceMarks;
            }
            return graceMarks;
        }
        public string PrintWithGraceGrade(double checkMarks, string subName)
        {
            double grace = GetGrace(checkMarks);
            string grade = GetGrade(checkMarks+ grace);

            if (grace == -1)
            {
                return $"Sorry You Are Failed In {subName} Your Marks :{checkMarks} And Grade:{grade}";
            }
            else if (grace == 0)
            {
                return $"Your Marks In {subName} :{checkMarks} And Grade:{grade}";
            }
            else
            {
                return $"Your Marks In {subName}:{checkMarks} Grace Is:{grace}  And Grade:{grade}";
            }

        }

        public void PrintDetails(School schoolObj, Student studentObj, Subjects subObj)
        {
            double totalMarks = 500;
            List<double> graceMarksWeHaveGiven = new List<double>();

            string HindiMarks = PrintWithGraceGrade(subObj.Hindi, "Hindi");
            string EnglishMarks = PrintWithGraceGrade(subObj.English, "English");
            string MathsMarks = PrintWithGraceGrade(subObj.Maths, "Maths");
            string ScienceMarks = PrintWithGraceGrade(subObj.Science, "Science");
            string SocialMarks = PrintWithGraceGrade(subObj.SocialScience, "Social Science");
            Console.WriteLine($"Your School:{schoolObj.SchoolName}");
            Console.WriteLine($"Your ClassName:{schoolObj.ClassName}");
            Console.WriteLine($"Your Name Is:{studentObj.StudentName}");
            Console.WriteLine(HindiMarks);
            Console.WriteLine(EnglishMarks);
            Console.WriteLine(MathsMarks);
            Console.WriteLine(ScienceMarks);
            Console.WriteLine(SocialMarks);
            double totalObtainedMarks = subObj.Hindi + subObj.English + subObj.Maths + subObj.Science + subObj.SocialScience;
            Console.WriteLine($"Obtained Marks:{totalObtainedMarks}/{totalMarks}");
        }


        static void Main(string[] args)
        {

            Program pgObj = new Program();
            School school = new School();
            Student student = new Student();
            Subjects sub = new Subjects();

            pgObj.SchoolInput(school);
            pgObj.StudentInput(student);
            pgObj.MarksInput(sub);
            pgObj.PrintDetails(school, student, sub);

        }
    }
}
