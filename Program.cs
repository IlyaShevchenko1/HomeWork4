// Home work 4.

//Task 25. Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

int NumInPow(int firstNumber, int secondNumber)
{
    int result = firstNumber;
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


//Task 27. Напишите программу, которая принимает на вход число и выдает
//сумму цифр в числе

//Task 29. Напишите программу, которая задает массив из m элементов и 
//выводит их на экран.
