//methods without parameters and return values


void test()
{
    Console.WriteLine("testing method in c#");
}

test();

//method without parameters but with a return value


int a;
int b;

Console.WriteLine("Enter value of A:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value of B:");
b = Convert.ToInt32(Console.ReadLine());

int test2()
{
 
    int c = a + b;
    return c;
}


int result = test2();
Console.WriteLine(result);


//method with parameters and return values
int test3(int c,int d)
{
    return c * d;
}


Console.WriteLine(test3(a,b));