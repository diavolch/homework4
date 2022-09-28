/*
Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int getSumOfNumber(int number) 
{
    int result = 0;
    while ( number > 0 )
    {
        result = number % 10 + result;
        number = number / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfNumber = getSumOfNumber(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} = {sumOfNumber}"); 