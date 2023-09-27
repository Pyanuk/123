using System.Net.NetworkInformation;

void GuessOne()
{
    do
    {
        try
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
            int a = 0;
            while (a != x)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == x)
                {
                    Console.WriteLine("Вааай, уцы, ты попал!");
                    Console.WriteLine(" ");
                    break;
                }
                else if (a != x)
                {
                    if (a < x)
                        Console.WriteLine("Неправильно! Искомое число больше - " + a);
                    else if (a > x)
                        Console.WriteLine("Неправильно! Искомое число меньше - " + a);
                }
            }
            break;
        }
        catch
        {
            Console.WriteLine("Ошибка: неккоректное число");
            Console.WriteLine(" ");
        }
    }
    while (true);
}

void TableMultiply()
{
    int[,] mas = new int[11, 11];
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            int sum = i * j;
            if (i == j)
            {
                mas[i, j] = sum;
                Console.Write(mas[i, j] + "\t");
            }
            else if (i > j)
            {
                mas[i, j] = sum;
                Console.Write(mas[i, j] + "\t");
            }
            else if (i < j)
            {
                mas[i, j] = sum;
                Console.Write(mas[i, j] + "\t");
            }
        }
        Console.WriteLine("\n\n");
    }
}

void Divine()
{
    do
    {
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n\n");
            break;
        }
        catch
        {
            Console.WriteLine("Ошибка: неккоректное число");
            Console.WriteLine(" ");
        }
    }
    while (true);
}


do
{
    Console.WriteLine("Выберите игру!");
    Console.WriteLine("1. Игра 'Угадай число'");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Выйти из программы");

    Console.Write("Введите номер игры: ");
    string? choice = Console.ReadLine();

    if (choice == "4")
        break;
    else if (choice == "1")
    {
        GuessOne();
        continue;
    }
    else if (choice == "2")
    {
        TableMultiply();
        continue;
    }
    else if (choice == "3")
    {
        Divine();
        continue;
    }
    else
    {
        Console.WriteLine("Вы ошиблись в вводе номера операции!");
        Console.WriteLine(" ");
        continue;
    }
}
while (true);

