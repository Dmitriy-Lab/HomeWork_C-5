// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double [15];
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-999, 1000)+ new Random().NextDouble();     // Добавляем дробную часть к числам

    if( array[i] > max)
    {
        max = array[i];
    }
     if( array[i] < min)
    {
        min = array[i];
    }
}
double answer = max - min;

Console.WriteLine("[{0}]", String.Join(",", array));                         // Для проверки
Console.WriteLine("Max: "+max+" Min: "+min);                                 // Для проверки
Console.WriteLine("Разница = "+answer);