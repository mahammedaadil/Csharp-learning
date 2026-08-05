
//current date
DateTime dt = DateTime.Now;

Console.WriteLine(dt);

//format date
Console.WriteLine(dt.ToString("dd-mm-yyyy"));
Console.WriteLine(dt.ToString("hh-mm-ss"));

//get year,month,today,etc
int year = dt.Year;
Console.WriteLine(year);

int month = dt.Month;
Console.WriteLine(month);

int today = dt.Day;
Console.WriteLine(today);

//calc difference
DateTime currentDay = DateTime.Today;
DateTime afterTwoDays = currentDay.AddDays(3);

Console.WriteLine(currentDay);
Console.WriteLine(afterTwoDays);