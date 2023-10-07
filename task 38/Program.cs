// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToInt32(value);
//     return result;
// }

int PromptSize(string message)
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

double DiffOfNubers(double[] arr)
{


    double result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int minpos = i;
        int maxpos = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minpos]) j = minpos;


            for (int k = j+1; k < arr.Length; k++)
            {
                if (arr[k] < arr[maxpos]) k = maxpos;

            }

        }


        double max = arr[maxpos];
        double min = arr[minpos];

        result = max - min;
        result = Math.Round(result, 2);

    }
    return result;
}



void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }

}

int minnumber = PromptSize("Введите миннимальное трехзначное положительное число = ");

int maxnumber = PromptSize("Введите максимальное трехзначное положительное число = ");


int sizenumber = PromptSize("Введите длину массива ");

double[] array = RandomNumbersArray(minnumber, maxnumber, sizenumber);


double diffOfNubers = DiffOfNubers(array);

Console.Write(" [");
PrintArray(array);
Console.Write("] -> ");
Console.WriteLine($"{diffOfNubers}");