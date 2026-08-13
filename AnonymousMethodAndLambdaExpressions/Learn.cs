using System;
using AnonymousMethodAndLambdaExpressions;

namespace LearningMethods
{
    internal class Learn
    {
        public static void Main()
        {
            Program p = new Program();
            Console.WriteLine(p.My(10,20));
            Console.WriteLine(p.MyLambda(10,10));
        }
    }
}
