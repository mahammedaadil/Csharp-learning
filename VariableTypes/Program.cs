

//whole type

int a; //declaration
a = 10; //intialization


//double --> float type values

double b;
b = 10.5;

//boolean

bool isAvailable = true;

//char
char c = 'A'; // only single character allowed 

//string 

string d = "hello guys"; //multiple chars allowed



//concatanation

string e = "hello";
string f = e + " world";

Console.WriteLine(f);

//implicit type conversion
int g = 10;
Console.WriteLine("hello" + g); // automatic converts g into string ,performed by compiler

//explicit type conversion
Console.WriteLine("hello" + g.ToString()); //explicitely convert by self

//interpolation
Console.WriteLine($"hello {g}");

//constant vars
const double PI = 3.14;
Console.WriteLine($"pi value {PI}");