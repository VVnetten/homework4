// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void NatPower(int a, int b)
{
    int c = a;
    for(int i = 1; i < b; i++)
    {
        c = c * a;
    }

    Console.WriteLine(c);
}
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



int num_1 = GetNumber("Введите первое число: ");
int num_2 = GetNumber("Введите второе число: ");
NatPower(num_1, num_2);