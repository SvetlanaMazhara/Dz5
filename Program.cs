/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.  

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
int count =0;
int Findcount(int[]array)
{
for (int i=0;i<array.Length;i++)
 { 
 if (array[i]%2==0) 
   {
     count=count+1;   
   }  
 }
  return count;
}
int[]myArray=CreateRandomArray(a, min,max);
ShowArray(myArray);
Findcount(myArray);
Console.WriteLine ($"Количество четных элементов в массиве {count}");

Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

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

int Sum=0;
int Findsum(int[]array)
{
    {
    for (int i=1;i<array.Length;i=i+2)
    Sum=Sum+array[i];
    }
return Sum;
}

int[]myArray=CreateRandomArray(a, min,max);
ShowArray(myArray);
Findsum(myArray);
Console.WriteLine ($"Сумма элементов на нечетных позициях массива {Sum}");
*/