string myself = "mahammedaadil Ahmed paTel      ";
string myself2 = "mahammedaadil Ahmed";
Console.WriteLine(myself[0]); //string is just an array in C#
Console.WriteLine(myself.Length); // string length 


foreach(char s in myself)
{
    Console.WriteLine(s);
} //loop through foreach

for(int i = 0 ; i < myself.Length; i++)
{
    Console.WriteLine(myself[i]);
} //loop through for


Console.WriteLine(myself.ToLower()); //converts lower case
Console.WriteLine(myself.ToUpper()); //converts to upper case

Console.WriteLine(myself.Trim());//remove white spaces from start and end 

Console.WriteLine(myself.Equals(myself2)); //checks equality

Console.WriteLine(myself2.Replace("Ahmed","Patel")); //replaces the string

Console.WriteLine(myself2.IndexOf("A")); //find first occurence





