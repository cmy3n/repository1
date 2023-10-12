string a;
int oper;

do
{
    Console.WriteLine("Выбирите действие: ");
    Console.WriteLine("1. Угадай число ");
    Console.WriteLine("2. Таблица умножения  ");
    Console.WriteLine("3. Вывод делителей числа ");
    Console.WriteLine("4. Выйти из программы ");

    a = Console.ReadLine();
    oper = Convert.ToInt32(a);

    if (oper == 1)
    {
        Console.WriteLine(" ");
        string abc;
        int num2;

        Random randomizer = new Random();
        int num = randomizer.Next(1, 100);
        Console.WriteLine("Угадайте число от 1 до 100 за 10 попыток: ");

        for (int attempt = 0; attempt < 10; attempt++)
        {
            string b = Console.ReadLine();
            num2 = Convert.ToInt32(b);

            if (num > num2)
            {
                Console.WriteLine("Попробуйте больше");
            }

            else if (num < num2)
            {
                Console.WriteLine("Попробуйте меньше");
            }

            else if (num == num2)
            {
                Console.WriteLine("Вы угадали!");
                break;
            }
        }

        Console.WriteLine(" ");
    }

    else if (oper == 2)
    {
        Console.WriteLine(" ");
        List<int> table = new List<int>();
        Console.WriteLine("Таблица умножения:");
        for (int z = 1; z != 10; z++)
        {
            for (int x = 1; x != 10; x++)
            {
                table.Add(x * z);
                if (table[x - 1] > 9) Console.Write(table[x - 1] + "  ");
                else Console.Write(table[x - 1] + "   ");
            }
            table.Clear();
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }

    else if (oper == 3)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Введите число: ");
        string c = Console.ReadLine();
        int num3 = Convert.ToInt32(c);

        Console.WriteLine("Число " + num3 + " без остатка делится на: ");

        for (int i = 1; i != num3; i++)
        {
            if (num3 % i == 0)
            {
                Console.WriteLine(num3 / i);
            }
        }
        Console.WriteLine('1');
        Console.WriteLine(" ");
    }

    else if (oper == 4)
    {
        Console.WriteLine(" ");
        Console.WriteLine("бб");
        Console.WriteLine(" ");
    }

    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Некорректное действие.");
        Console.WriteLine(" ");
    }
}
while (oper != 4);


