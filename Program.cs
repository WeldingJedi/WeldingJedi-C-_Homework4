// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход 
// два натуральных числа (A и B) и возводит число A в степень B.
void Task25()
{
    Console.WriteLine("Please, enter integer 'A': ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, enter integer 'B'. 'A' will be raised to this power");
    int B = Convert.ToInt32(Console.ReadLine());
    int pow = 1;
    for (int i = 1; i <= B; i++)
    {
        pow *= A;
    }
    Console.WriteLine($"'A' to the power of 'B' is {pow}.");
}

//Task25();
//---------------------------------------------------------------------------//

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Task27()       // решение основано на задаче из семинара (нахождение кол-ва цифр)
{
    Console.WriteLine("Please, enter integer to get the sum of its digits: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int A = num;
    int x;
    int sum = 0;
    for (int i = 1; i < A; i++)
    {
        A = A / 10;
        for (int j = 1; j <= i; j++)
        {
            x = num % 10;
            sum = sum + x;
            num = num / 10;
        }
    }
    Console.WriteLine($"Digits sum of entered integer is {sum}");
}

//Task27();

void Task27_1()     // собственно решение через считывание кол-ва символов в строке
{
    Console.WriteLine("Please, enter integer to get the sum of its digits: ");
    string n = Console.ReadLine();
    int num = Convert.ToInt32(n);
    int sum = 0;
    for (int i = 1; i <= n.Length; i++)
    {
        int x = num % 10;
        sum = sum + x;
        num = num / 10;
    }
    Console.WriteLine($"Digits sum is {sum}");
}

//Task27_1();
//---------------------------------------------------------------------------//

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Task29()
{
    int size = 8;
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-99, 100);                                         // генерируем массив
    }
    Console.WriteLine("Generated array:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{array[i]}] ");                                        // выводим массив
    }
    Console.WriteLine("\nSorted array:");
    for (int k = 0; k < array.Length; k++)
    {
        int MinPos = k;
        for (int l = k + 1; l < array.Length; l++)
        {
            if (Math.Abs(array[l]) < Math.Abs(array[MinPos])) MinPos = l;       // сортируем по возрастанию модулей
        }
        int Temp = array[k];
        array[k] = array[MinPos];
        array[MinPos] = Temp;
        Console.Write($"[{array[k]}] ");                                        // выводим отсортированный массив
    }
    Console.WriteLine();
}

//Task29();
//---------------------------------------------------------------------------//