// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int m = inputNumber("Введите 1-ое значение: ");
int n = inputNumber("Введите 2-ое значение: ");
System.Console.WriteLine(AkkermanFunc(m, n));


int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m != 0 && n == 0)
        return AkkermanFunc(m - 1, 1);
    if (m > 0 && n > 0)
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    return AkkermanFunc(m, n);
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


// Я без понятия, что это такое и как работает, но я нашел формулу в инете и подставил значения в своем 
// коде, все заработало, но я как и говорил выше без малейшего понятия, что это такое, как оно работает и 
// зачем вообще ОНО нужно)) Надеюсь мне в будущем ОНО никогда не понадобится))) 
// Справедливости ради скажу, что прочитал несколько форумов посвященных понятию функции Аккермана, 
// но так ничего и не понял! Смею преположить, что челу нечем было заняться (видать не было жены и детей) 
// и он решил такую хрень придумать))