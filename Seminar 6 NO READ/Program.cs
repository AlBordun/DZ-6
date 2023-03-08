/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
44 -> 101100
3 -> 11
2 -> 10


static int ReadInt(string prompt) 
{
    Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

static int[] ConvertToBinary(int value)
{
    int count = 0;
    int value2 = value;
    while (value2 > 0)
    {
        value2 /= 2;
        count++;
    }
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = value % 2;
        value /= 2;
    }
    Array.Reverse(result);
    return result;
}

static void PrintArray(int[] array)
{
    Console.WriteLine(string.Join("", array));
}

static void Main(string[] args)
{
    int num = ReadInt("Введите число: ");
    int[] binaryNum = ConvertToBinary(num);
    PrintArray(binaryNum);
}
*/

/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5-> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int num)
{
    if (num == 0) return;
    GetBinaryView(num / 2);
    System.Console.Write(num % 2);
}

int N = ReadInt("Введите число");
GetBinaryView(N); */

/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5-> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Fibo(int N)
{
    Console.Write("0 1 ");
    int a = 0, b = 1;
    for (int i = 2; i < N; i++)
    {
        int result = a + b;
        a = b;
        b = result;
        Console.Write(result + " ");
    }
}

int N = ReadInt("Input number: ");
Fibo(N);*/

/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}


int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] array = GenArray(9, -9, 9);
PrintArray(array);

int[] newArray = CopyArray(array);
PrintArray(newArray);