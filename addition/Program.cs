public class addition
{
    public static void Main (string[] args)
    {

        int a;
        int b;
        int c;
        Console.WriteLine("enter first number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number ");
        b = Convert.ToInt32(Console.ReadLine());
        c = a + b;
        Console.WriteLine("addition : {0}", c);

    }

}
