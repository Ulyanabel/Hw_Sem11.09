// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);
}
int [] array = new int [5];
InputArray(array);
Console.WriteLine("["+ string.Join(",", array)+"]");

int min = array[0]; 
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            min = array[i];
        }
    Console.WriteLine("Минимальный элемент массива: "+ min);
int max = array[0]; 
    for (int i=0; i<array.Length; i++)
        {
            if (array[i] > max)
            max = array[i];
        }
    Console.WriteLine("Максимальный элемент массива: "+ max);
Console.WriteLine(max-min);