Console.WriteLine("Enter your age to check eligibility:");
int age = int.Parse(Console.ReadLine());

//if else if,else

//if (age >= 18)
//{
//    Console.WriteLine($"u are {age},u can vote");
//}
//else if (age <= 0)
//{
//    Console.WriteLine("Invalid age");
//    return;
//}
//{
//    Console.WriteLine("Sorry,u cannot vote");
//}   //works on boolean values 



//switch
switch (age)
{
    case   >= 0 and  <= 10:
        Console.WriteLine("You are under 10 or 10");
        break;

    case  >= 10 and  <= 20:
        Console.WriteLine("You are under 20 or 20");
        break;
    default:
        Console.WriteLine("Your age is greater than 20");
        break;
}