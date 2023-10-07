// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


double[] RandomNumbersArray(int min, int max, int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {

        arr[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
        arr[i] = Math.Round(arr[i], 2);

    }
    return arr;
}

double MinNumber(double[] arr)
{

    double minnum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {

        if (minnum > arr[i])
        {
            minnum = arr[i];

        }
    }
    return minnum;
}


double MaxNumber(double[] arr)
{
    double maxnum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {

        if (maxnum < arr[i])
        {
            maxnum = arr[i];

        }
    }
    return maxnum;
}



void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
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

double[] array = RandomNumbersArray(minnumber, maxnumber, sizenumber);


double diffOfNubers = MaxNumber(array) - MinNumber(array);
diffOfNubers = Math.Round(diffOfNubers, 2);

Console.Write(" [");
PrintArray(array);
Console.Write("] -> ");
Console.WriteLine($"{MaxNumber(array)} - {MinNumber(array)} = {diffOfNubers}");