//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] n) 
{

for(int i = 0; i<8; i++)
{
    n[i] = new Random().Next(1,100);
   
} 

}


// Console.WriteLine ( $"{a[i]}, " );
int[] a = new int[8];
PrintArray(a);
Console.WriteLine($"[{String.Join(",", a)}]");