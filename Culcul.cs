Console.WriteLine("Выберите желаемую операцию: \r\n" +
    "1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");

int a = Convert.ToInt32(Console.ReadLine());

for (; a < 9; a = Convert.ToInt32(Console.ReadLine()))
{
    if (a < 1)
    {
        Console.WriteLine("Error");
    }
    else
    {
        Console.WriteLine("Поочередно введите первую и вторую переменные");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
            Console.WriteLine("Ответ: " + (x + y));
        else if (a == 2)
            Console.WriteLine("Ответ: " + (y - x));
        else if (a == 3)
            Console.WriteLine("Ответ: " + (x * y));
        else if (a == 4)
            if (y == 0)
                Console.WriteLine("Error");
            else
                Console.WriteLine("Ответ: " + (x / y));
        else if (a == 5)
        {
            Console.WriteLine("Введите степень N для первого числа:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int res1 = 1;
            for (int i = 1; i <= n1; i++)
                res1 = res1 * x;
            Console.WriteLine("Ответ: " + res1);

            Console.WriteLine("Введите степень N для второго числа:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int res2 = 1;
            for (int i = 1; i <= n2; i++)
                res2 = res2 * x;
            Console.WriteLine("Ответ: " + res2);
        }
        else if (a == 6)
        {
            Console.WriteLine("Ответ: " + Convert.ToInt32(Math.Sqrt(x)));
            Console.WriteLine("Ответ: " + Convert.ToInt32(Math.Sqrt(y)));
        }
        else if (a == 7) //1% от числа
        {
            Console.WriteLine("Ответ: " + (x / 100));
            Console.WriteLine("Ответ: " + (y / 100));
        }
        else if (a == 8) //факториал
        {
            int fact1 = 1, i = 1;
            while (i <= x)
            {
                fact1 *= i;
                i++;
            }
            Console.WriteLine("Ответ: " + fact1);

            int fact2 = 1; i = 1;
            while (i <= y)
            {
                fact2 *= i;
                i++;
            }
            Console.WriteLine("Ответ: " + fact2);
        }
    }
    Console.WriteLine("Какая операция вас интересует?");

}