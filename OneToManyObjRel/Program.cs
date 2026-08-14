using System;
using College;

namespace OneToManyObjRel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Console.WriteLine("Enter StudentId:");
            stud.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter StudentName:");
            stud.StudentName = Console.ReadLine();

            stud.course = new CourseDetails.Course();

            Console.WriteLine("Enter CourseId:");
            stud.course.CourseId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CourseName:");
            stud.course.CourseName = Console.ReadLine();


            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("StudentId:" +stud.StudentId);
            Console.WriteLine("StudentName:" + stud.StudentName);
            Console.WriteLine("CourseId:" + stud.course.CourseId);
            Console.WriteLine("CourseName:" + stud.course.CourseName);
        }
    }
}
