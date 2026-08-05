//one diamentional array

////declaration of array

//int[] arr = new int[10];
//arr = [10, 20, 30]; //intialization

//Console.WriteLine(arr[1]); //access with index;


////declaration and intialization together
//int[] ex = { 10, 20, 30, 40, 50, 60, 70 };


//for (int i = 0; i <= ex.Length; i++)
//{
//    Console.WriteLine(ex[i]);
//} //print whole array  



//// for each loop
//foreach(int val in ex)
//{
//    Console.WriteLine(val);
//}




//Two Diamentional Arrays

//int[,] ar =
//{
//    {100,200,300 },
//    {300,400,500 },
//    {300,400,500 }

//}; //declaration and intialization

//Console.WriteLine(ar[0,1]); //access

////loop 2-d array
//Console.WriteLine(ar.GetLength(0)); //row count
//Console.WriteLine(ar.GetLength(1)); //column count 

//for(int row=0; row < ar.GetLength(0); row++)
//{
//    for(int col = 0; col < ar.GetLength(1); col++)
//    {
//        Console.Write(ar[row,col] + " ");
//    }
//    Console.WriteLine();
//}


//jaggedarray 

int[][] jArr =
{
    [10,20],
    [10,20,30],
    [30,40,50,60]
}; //declaration and intialization

Console.WriteLine(jArr[0].Length); //length of column  by row
Console.WriteLine(jArr.Length); //length of rows

//loop through jagged array
for(int row = 0; row < jArr.Length; row++)
{
    for(int col = 0; col < jArr[row].Length; col++)
    {
        Console.Write(jArr[row][col] + " ");
    }
    Console.WriteLine();
}

