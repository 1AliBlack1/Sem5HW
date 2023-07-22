// Количество четных трехзначных чисел в массиве 

int[] CreaterArray (int sizeAarray, int minVal, int maxVal) // метод создания и заполнения массива
{
    int [] newArray = new int[sizeAarray];
    for (int i = 0; i < sizeAarray; i++)
    {
        newArray[i] = new Random().Next(100, 999);
    }
    return newArray;
}

void PrintArray(int[] arrayToPrint) //метод вывода на печать одномерного массива
{
    int arraySize = arrayToPrint.Length;
    Console.WriteLine(arraySize);
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " | ");
    Console.WriteLine();    
}

int [] CountDigit(int [] countArray)
{
    int count = 0;
    for (int i = 0; i < countArray.Length; i++)
    {
        if (countArray[i] / 2 == 0)
        count++;       
    }

}