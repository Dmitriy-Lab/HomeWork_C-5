// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int [10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9999, 10000);   // Если выпадет чило "0", то оно не повлияет на итоговое значение суммы

    if( array[i] % 2 != 0)
    {
        sum += array[i];
    }
}

Console.WriteLine("[{0}]", String.Join(",", array));  // Для проверки
Console.WriteLine("Сумма нечетных чисел = "+sum);