Dictionary<int, string> emp = new Dictionary<int, string>();  //declaration

emp.Add(1, "Aadil"); //add value on it
emp.Add(2, "Sahil");
emp.Add(3, "Akil");
//emp.Add(1, "ahmed"); //doesnt allow duplication same key cannot be there

Console.WriteLine(emp[3]); //access by key

emp.Remove(1);


//loop through key and value
foreach(KeyValuePair<int,string> e in emp)
{
    Console.WriteLine($"key:{e.Key}  value:{e.Value} ");
}

//loop throw key
foreach(int key in emp.Keys)
{
    Console.WriteLine(key);
}

//loop through values 
foreach(string val in emp.Values)
{
    Console.WriteLine(val);
}


