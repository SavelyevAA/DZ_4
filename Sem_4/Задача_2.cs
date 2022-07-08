/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число Х: ");
int numX = int.Parse(Console.ReadLine()!);

int SumNumber(int numX)
{
    int count = Convert.ToString(numX).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        advance = numX - numX % 10;
        result = result + (numX - advance);
        numX = numX / 10;
    }
    return result;
}

int sumNumber = SumNumber(numX);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);