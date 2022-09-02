// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double [15];

for (int i = 0; i < array.Length; i++)  
{
    array[i] = new Random().Next(-999, 1000) + new Random().NextDouble();     // Добавляем дробную часть к вещественным числам
}

// Сначала заполняем массив случайными числами, чтобы дальше можно было приравнять 
// max и min к array[0] и далее идти перебором.
// К нулю их приравнять нельзя, так как у нас Random().Next(-999, 1000) может в теории 
// выдать, например, ряд только положительных чисел.
// В этом случае условие if( array[i] < min) никогда не наступит, и в значении min останется 0, что будет неверно.

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
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