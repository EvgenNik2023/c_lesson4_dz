// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int Input()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Input();

int Sum(int number)
{
    int sum = 0;
    if (number < 0) number *= -1;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int sum = Sum(number);

Console.WriteLine("Сумма цифр числа = " + sum);
