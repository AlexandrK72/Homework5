// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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


int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;

    }
    return count;
}



 void PrintArray(int[] arr)
 {
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    
}



int minnumber = Prompt("Введите миннимальное трехзначное положительное число = ");

int maxnumber = Prompt("Введите максимальное трехзначное положительное число = ");


int sizenumber = Prompt("Введите длину массива ");

if (99 < minnumber && minnumber < 1000 && 99 < maxnumber && maxnumber < 1000)
{

int[] array = RandomNumbersArray(minnumber, maxnumber, sizenumber);




    int evenNumbers = EvenNumbers(array);

    Console.Write(" [");
    PrintArray(array);
    Console.Write("] -> ");
    Console.WriteLine($"{evenNumbers}");
}
else Console.WriteLine("Ошибка. Введите положительное трехзначное число");

