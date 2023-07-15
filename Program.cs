// Функция для ввода:
int Input()
{
    string input = Console.ReadLine();
    int rezult = Convert.ToInt32(input);
    return rezult;
}

// Задача №19: Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом:
void Task19()
{
    Console.WriteLine("Введите пятизначное число: ");
    int number = Input();
    int f_digit = number / 10000;
    int s_digit = (number - f_digit * 10000) / 1000;
    int t_digit = (number - f_digit * 10000 - s_digit * 1000) / 100;
    int fo_digit = (number - f_digit * 10000 - s_digit * 1000 - t_digit * 100) / 10;
    int fif_digit = (number - f_digit * 10000 - s_digit * 1000 - t_digit * 100 - fo_digit * 10);

    if (f_digit == fif_digit & s_digit == fo_digit)
    {
        Console.WriteLine("Введённое пятизначное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введённое пятизначное число не является палиндромом");
    }
    Console.WriteLine("Если хотите продолжить, нажмите 1");
    Console.WriteLine("Если хотите закончить, нажмите 2");
    int v = Input();
    if (v == 1)
    {
        Task();
    }
    else
    {
        Console.WriteLine("END");
    }
}

// Задача №21: Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве:
void Task21()
{
    Console.WriteLine("Введите координаты первой точки A: ");
    Console.Write("x = ");
    int number1 = Input();
    Console.Write("y = ");
    int number2 = Input();
    Console.Write("z = ");
    int number3 = Input();

    Console.WriteLine("Введите координаты второй точки B: ");
    Console.Write("x = ");
    int number4 = Input();
    Console.Write("y = ");
    int number5 = Input();
    Console.Write("z = ");
    int number6 = Input();

    Console.Write("Расстояние между точками А и В равняется: ");
    double rezult = Math.Sqrt(Math.Pow((number4 - number1), 2) + Math.Pow((number5 - number2), 2) + Math.Pow((number6 - number3), 2));
    rezult = Math.Round(rezult, 2);
    Console.WriteLine(rezult);
    Console.WriteLine("Если хотите продолжить, нажмите 1");
    Console.WriteLine("Если хотите закончить, нажмите 2");
    int v = Input();
    if (v == 1)
    {
        Task();
    }
    else
    {
        Console.WriteLine("END");
    }
}

// Задача №23: Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Task23()
{
    Console.WriteLine("Введите число N: ");
    int number = Input();
    int i = 1;
    Console.WriteLine("Таблица кубов чисел от 1 до N:");
    while (i <= number)
    {
        Console.WriteLine($"({i})^3 = {Math.Pow(i, 3)}");
        i = i + 1;
    }
    Console.WriteLine("Если хотите продолжить, нажмите 1");
    Console.WriteLine("Если хотите закончить, нажмите 2");
    int v = Input();
    if (v == 1)
    {
        Task();
    }
    else
    {
        Console.WriteLine("END");
    }
}

// Для выбора программы (Функция):
void Task()
{
    Console.WriteLine("Выберите программу:");
    int number = Input();
    if (number == 19)
    {
        Task19();
    }
    else if (number == 21)
    {
        Task21();
    }
    else if (number == 23)
    {
        Task23();
    }
    else
    {
        Console.WriteLine("Ошибка (такой программы не существует)");
    }
}

// Для выбора программы:
Console.WriteLine("Выберите программу:");
int number = Input();
if (number == 19)
{
    Task19();
}
else if (number == 21)
{
    Task21();
}
else if (number == 23)
{
    Task23();
}
else
{
    Console.WriteLine("Ошибка (такой программы не существует)");
}
