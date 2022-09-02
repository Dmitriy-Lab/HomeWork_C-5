// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int [] array = new int [10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);

    if( array[i] % 2 == 0)
    {
        sum += 1;
    }
}

Console.WriteLine("[{0}]", String.Join(",", array));  // Для проверки
Console.WriteLine("Сумма четных чисел = "+sum);