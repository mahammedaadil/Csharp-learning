//declaration of array

int[] arr = new int[10];
arr = [10, 20, 30]; //intialization

Console.WriteLine(arr[1]); //access with index;


//declaration and intialization together
int[] ex = { 10, 20, 30, 40, 50, 60, 70 };


for (int i = 0; i <= ex.Length; i++)
{
    Console.WriteLine(ex[i]);
} //print whole array  

 

// for each loop
foreach(int val in ex)
{
    Console.WriteLine(val);
}