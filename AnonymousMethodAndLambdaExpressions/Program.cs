using System;


namespace AnonymousMethodAndLambdaExpressions
{
    public delegate int MyDelegate(int a, int b);
    internal class Program
    {
       public MyDelegate My = delegate (int a, int b)
        {
            return a + b;
        }; //anonymous function.


        public MyDelegate MyLambda = (int a, int b) =>
        {
            return a * b;
        }; //lambda expression.


    }
}
