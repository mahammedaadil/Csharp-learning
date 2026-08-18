using System;
using SchoolSpace;
using SubSpace;

namespace GradeSystem
{
    internal class Program
    {

        public void SchoolInput(School schoolObj )
        {
            Console.WriteLine($"Welcome To {schoolObj.SchoolName}");
            Console.WriteLine("Enter Your ClassName:");
            schoolObj.ClassName = int.Parse(Console.ReadLine());
        }
        

        public void StudentInput(Student studentObj)
        {
            Console.WriteLine("Enter Student Name:");
            studentObj.StudentName = Console.ReadLine();
        }


 
        public void MarksInput(Subjects subObj)
        {
            
            Console.WriteLine("Enter Hindi Marks:");
            subObj.Hindi = double.Parse(Console.ReadLine());
            if (subObj.Hindi > 100 || subObj.Hindi < 0)
            {
                return;
            }
           
            Console.WriteLine("Enter English Marks:");
            subObj.English = double.Parse(Console.ReadLine());
            if (subObj.English > 100 || subObj.English < 0)
            {
                return;
            }

            Console.WriteLine("Enter Maths  Marks:");
            subObj.Maths = double.Parse(Console.ReadLine());
            if (subObj.Maths > 100 || subObj.Maths < 0)
            {
                return;
            }

            Console.WriteLine("Enter SocialScience  Marks:");
            subObj.SocialScience = double.Parse(Console.ReadLine());
            if (subObj.SocialScience > 100 || subObj.SocialScience < 0)
            {
                return;
            }

            Console.WriteLine("Enter Science  Marks:");
            subObj.Science = double.Parse(Console.ReadLine());
            if (subObj.Science > 100 || subObj.Science < 0)
            {
                return;
            }
        }

        public string GetGrade(double marks)
        {
            string grade = "";

            if (marks>=90)
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
            else if(marks >= 60)
            {
                grade = "B";
            }
            else if(marks >= 50) 
            {
                grade = "C+";
            }
            else if (marks >= 40)
            {
                grade = "C";
            }
            else
            {
                grade = "E";
            }

            return grade;
        }

        public double GetGrace(double marks)
        {
            double passingMarks = 35;
            double minimumMarks = 25;
            double graceMarks= 0;

            //handle failed scenario
            if(marks < 25)
            {
                return -1;
            }

            //between 25-35 marks condition
            if (marks >= minimumMarks && marks < passingMarks)
            {
                graceMarks = passingMarks - marks;
            }

            //when passing marks then return 0
            return graceMarks;
        }


        public string PrintWithGraceGrade(double checkMarks,string subName)
        {
            double Grace = GetGrace(checkMarks);
            string Grade = GetGrade(checkMarks);

            if (Grace == -1)
            {
               return $"Sorry You Are Failed In {subName} Your Marks :{checkMarks} And Grade:{Grade}";
            }
            else if (Grace == 0)
            {
                return $"Your Marks In {subName} :{checkMarks} And Grade:{Grade}";

            }
            else
            {
                return $"Your Marks In {subName}:{checkMarks} Grace Is:{Grace}  And Grade:{Grade}";

            }
        }

        public void PrintDetails(School schoolObj, Student studentObj, Subjects subObj)
        {

            
            double totalMarks = 500;
            string HindiMarks = PrintWithGraceGrade(subObj.Hindi,"Hindi");
            string EnglishMarks = PrintWithGraceGrade(subObj.English,"English");
            string MathsMarks = PrintWithGraceGrade(subObj.Maths,"Maths");
            string ScienceMarks = PrintWithGraceGrade(subObj.Science,"Science");
            string SocialMarks = PrintWithGraceGrade(subObj.SocialScience,"Social Science");

            Console.WriteLine($"Your School:{schoolObj.ClassName}");
            Console.WriteLine($"Your ClassName:{schoolObj.ClassName}");
            Console.WriteLine($"Your Name Is:{studentObj.StudentName}");
            Console.WriteLine(HindiMarks);
            Console.WriteLine(EnglishMarks);
            Console.WriteLine(MathsMarks);
            Console.WriteLine(ScienceMarks);
            Console.WriteLine(SocialMarks);
            double totalObtainedMarks = subObj.Hindi + subObj.English + subObj.Maths + subObj.Science + subObj.SocialScience;
            Console.WriteLine($"Total Marks:{totalObtainedMarks}/{totalMarks}");


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
