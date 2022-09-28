/*
Напишите программу, в которой пользователь задает длину 
массива, элементы которого задаются в диапазоне [1,99] и выводит на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

int[] getRandomArray(int sizeOfArray)
{
    sizeOfArray = Math.Abs(sizeOfArray);
    int[] array = new int[sizeOfArray];
    for (int i = 0; i < sizeOfArray; i++)
    {
        int number = new Random().Next(1,100);
        array[i] = number;
    }
    return array;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if ( i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

Console.Write("Введите длину массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = getRandomArray(userSize);
printArray(userArray);