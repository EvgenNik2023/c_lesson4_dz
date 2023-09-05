// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Input1()
{
    Console.Write("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}
int Input2()
{
    Console.Write("Введите степень числа: ");
    int B = Convert.ToInt32(Console.ReadLine());
    return B;
}
int A = Input1();
int B = Input2();

int Result(int A, int B)
{
    int result = 1;

    for(int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}


int prod = Result(A, B);
Console.WriteLine(prod);
