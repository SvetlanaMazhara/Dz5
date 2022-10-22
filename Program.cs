/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */ 

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] myArray = new int [size];
    for (int i=0; i<size; i++)
    {
        myArray[i]=new Random().Next(minValue, maxValue+1);
    }
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
Console.WriteLine ("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[]myArray=CreateRandomArray(a, min,max);
ShowArray(myArray);
