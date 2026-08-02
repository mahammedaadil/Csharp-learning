public class oddEven { 
 public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is an even number.", number);
        }
        else
        {
            Console.WriteLine("{0} is an odd number.", number);
        }

        Console.WriteLine("end of oddEven");

    }

}

