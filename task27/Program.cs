// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void GetSum (int n) {
    
    int sum = 0;
    while (n > 0)
    {
        int c = n%10;
        sum = sum + c;
        n = n/10;
    }

// int sum = n;
// int count = n/10;
// int count2 = n%10;
// for( int i = 0; i < count ; i++)
// {
//     sum = count2 + count%10;
// }

Console.WriteLine(sum);

}



int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



int num = GetNumber("Введите  число: ");
GetSum (num);