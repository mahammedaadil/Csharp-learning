Console.WriteLine("Enter First Number:");
int a = int.Parse(Console.ReadLine()); //this is way to explicit type convertion if null will give error
Console.WriteLine("Enter Second Number:");
int b = Convert.ToInt32(Console.ReadLine()); //another way we can take integer length  as per our need

int c = a / b;
Console.WriteLine(c);