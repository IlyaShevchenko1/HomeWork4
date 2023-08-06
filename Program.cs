// Home work 4.

//Task 25. Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

/*
int NumInPow(int firstNumber, int secondNumber)
{
    int result = firstNumber;
    if (secondNumber == 0 && firstNumber > 0) result = 1;
    if (secondNumber == 0 && firstNumber < 0) result = -1;
    for (int i = 2; i <= secondNumber; i++)
    {
        result = result * firstNumber;
    }
    return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power for the number: ");
int power = Convert.ToInt32(Console.ReadLine());

int result = NumInPow(number, power);
Console.WriteLine($"Result of number {number} in power {power} is {result}");

*/

//Task 27. Напишите программу, которая принимает на вход число и выдает
//сумму цифр в числе

/*

int SumInNum (int number)
{
    int res = 0;
    int remains = 0;
    while (number > 0)
    {
        remains = number % 10;
        number = number / 10;
        res = res + remains;
    }
    return res;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumInNum(number);
Console.WriteLine($"Sum of digit in the number {number} is {result}");

*/

//Task 29. Напишите программу, которая задает массив из m элементов и 
//выводит их на экран.

/*

int[] CreateAnArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} number of massive: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Input a lenghts of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateAnArray(lenght);
WriteArray(myarray);

*/