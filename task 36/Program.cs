// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System.Reflection;

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] RandomNumbersArray(int min, int max, int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {

        arr[i] = rnd.Next(min, max + 1);

    }
    return arr;
}

int OddIndex(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i %2 == 1)
        {
            result = result + arr[i];
        }

    }
    return result;
}



 void PrintArray(int[] arr)
 {
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    
}

int minnumber = Prompt("Введите минимальный элемент массива = ");

int maxnumber = Prompt("Введите максимальный элемент массива = ");
if(minnumber>maxnumber)
{
    Console.WriteLine("Некорректный ввод.");
    return;
}


int sizenumber = Prompt("Введите длину массива ");

int[] array = RandomNumbersArray(minnumber, maxnumber, sizenumber);


int oddIndex = OddIndex(array);

Console.Write(" [");
PrintArray(array);
Console.Write("] -> ");
Console.WriteLine($"{oddIndex}");
