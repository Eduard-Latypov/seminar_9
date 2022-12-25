// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
System.Console.WriteLine("Введите числа, в промежутке которых нужно найти сумму!");
int num_1 = inputNumber("Введите 1-ое число: ");
int num_2 = inputNumber("Введите 2-ое число: ");
int temp = func(num_1, num_2);
System.Console.WriteLine(GetSum(num_1, num_2, temp));







int func(int num_1, int num_2)
{
    temp = 1;
    if (num_1 > num_2)
    {
        temp = -1;
    }
    return temp;
}


int GetSum(int num_1, int num_2, int temp)
{
    if (num_1 == num_2)
    {
        return num_1;
    }
    return num_1 + GetSum(num_1 + temp, num_2, temp); ;
}


int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

