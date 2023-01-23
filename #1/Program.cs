/*  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ArraysEvenNumbsAmount(int[] array)

{
    int count = 0;
    Console.Write("even numbers in array: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.Write($"{array[i]}; ");
            count += 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"amount of even numbers in your array:{count}");
}

int[] array = CreateRandomArray(6, 100, 1000);
ArraysEvenNumbsAmount(array);
Console.Write("Your array: ");
ShowArray(array); 