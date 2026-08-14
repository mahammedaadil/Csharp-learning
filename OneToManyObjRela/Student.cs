using System;
using System.Collections.Generic;
using ExamSpace;

namespace College
{
    internal class Student
    {

        public int SID { get; set; }
        public string SName { get; set; }

        public List<Exam> Sexam { get; set; }
    }
}
