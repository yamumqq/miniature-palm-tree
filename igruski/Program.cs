using System.ComponentModel.Design;

namespace igruski
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер операции:\r\n1.Игра 'угадай число'\r\n2.Таблица умножения\r\n3.Вывод делителей числа\r\n4.Выход");  
            string vibor = Console.ReadLine();
            switch (vibor)
            {
                case "1":
                    Ugadaika();
                    break;
                    case "2":
                    Console.WriteLine("Таблица умножения до 10:");
                    Tablitsa();
                    break;
                    case "3":
                    Nahoddelitel();
                    break;
                    case "4":
                    Environment.Exit(0);
                    break;
                    default: Console.WriteLine("Выберите правильный вариант ответа");
                    break;
                    
            }
        }
        static void Ugadaika()
        {
            Random random = new Random();
            int chisl = random.Next(101);
            int popitka = 0;
            Console.WriteLine("Попробуй угадать число от 1 до 100");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int ugad))
                {
                    popitka++;
                    if (ugad < chisl)
                    {
                        Console.WriteLine("Попробуй число побольше");
                    }
                    else if (ugad > chisl)
                    {
                        Console.WriteLine("Переборщил. Попробуй меньше");
                    }
                    else
                    {
                        Console.WriteLine("Поздравляю вы угадали число " +  chisl + ". Число попыток: " + popitka);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                }
            }
        }
        static void Tablitsa()
        {
            int[,] umnozh = new int[11, 11];
            for (int perv = 1; perv < 11; perv++)
            {
                for (int vtor = 1; vtor< 11; vtor++)
                {
                    umnozh[perv, vtor] = perv * vtor;
                    Console.Write(umnozh[perv, vtor] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Nahoddelitel()
        {
            Console.WriteLine("Введите целое число");
            if (int.TryParse(Console.ReadLine(), out int chisl))
            {
                Console.WriteLine("Делители числа " + chisl + ":");
                for (int i = 1; i <= chisl; i++)
                {
                    if (chisl % i == 0)
                    {
                        Console.Write   (i + " ");
                    }
                    
                    
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Введите целое число");
            }
        }
    }
}