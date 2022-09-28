/*
Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int getPowerOfNumber(int firstNumber, int secondNumber)
{
    int result = firstNumber;
    secondNumber = Math.Abs(secondNumber);
    for (int i = 1; i < secondNumber; i++)
    {
        result = result * firstNumber;
    }
    if (secondNumber == 0)
    {
        result = 1;
    }
    return result;
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int userPower = Convert.ToInt32(Console.ReadLine());
int powerOfNumber = getPowerOfNumber(userNumber, userPower);
Console.WriteLine($"Число {userNumber} в степени {userPower} = {powerOfNumber}");