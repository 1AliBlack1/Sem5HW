// Количество четных трехзначных чисел в массиве 

Console.WriteLine("Enter array size");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
   {
       randomArray[i] = new Random().Next(99,999);
       Console.Write(randomArray[i] + " | ");
   }
}

int kol(int[] randomArray)
{
   int kol = 0;
   for (int i = 0; i < randomArray.Length; i++)
    {
      if (randomArray[i] % 2 == 0)
      kol = kol + 1;
    }
    return kol;
}

mas(a);
Console.Write($"Количество чётных чисел в массиве: {kol(randomArray)}");


//Сумма нечетных элементов

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
         randomArray[i] = new Random().Next(1,9);
        Console.Write(randomArray[i] + " | ");
    }

}

int kol(int[] randomArray)
{
     int sum = 0;
     int i = 0;
     while (i < randomArray.Length)
   {
       sum = sum + randomArray[i];
       i = i + 2;
   }
    return sum;
}

mas(a);
Console.Write($"Сумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");


Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
   Random rand = new Random();
   for (int i = 0; i < a; i++)
  {
      randomArray[i] = rand.NextDouble();
      Console.Write($" {randomArray[i]:F2}|  ");
  }

}

double raz(double[] randomArray)
{
   double min = randomArray[0];
   double max = randomArray[0];
   int i = 1;
   while (i < randomArray.Length)
   {
       if (max<randomArray[i])
       max = randomArray[i];
       if (min>randomArray[i])
       min = randomArray[i];
       i = i + 1;
   }
   return max-min;
}

mas(a);
Console.Write($"Разница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");