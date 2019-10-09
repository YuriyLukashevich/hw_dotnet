using System;

namespace hm_05_Task3
{
    class Program
    {
        public static void Way1()
        {
            object[] array1 = { "object", 123, 'o', 4 };
            Console.WriteLine($"before reverse: {String.Join(", ", array1)}");
            Array.Reverse(array1);
            Console.WriteLine($"after reverse: {String.Join(", ", array1)}");
        }

        public static void Way2()
        {
            object[] array1 = new object[10];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"obj {i + 1} = ");
                array1[i] = Console.ReadLine();
            }
            Console.WriteLine($"before reverse: {String.Join(", ", array1)}");
            Array.Reverse(array1);
            Console.WriteLine($"after reverse: {String.Join(", ", array1)}");
        }

        public static void Way3()
        {
            Random fill = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array1[i] = fill.Next(0, 100);
                Console.WriteLine($"{i + 1} element of mass1: {array1[i]}");
            }
            Console.WriteLine($"before reverse: {String.Join(", ", array1)}");
            Array.Reverse(array1);
            Console.WriteLine($"after reverse: {String.Join(", ", array1)}");
        }

        public static void Way4()
        {
            try
            {
                object[] array1 = null;
                Console.WriteLine($"before reverse: {String.Join(", ", array1)}");
                Array.Reverse(array1);
                Console.WriteLine($"after reverse: {String.Join(", ", array1)}");
            }
            catch
            {
                Console.WriteLine("incorrect input");
            }
        }

        public static void Way()
        {
            int option;
            Console.WriteLine("Выберите вариант какого массива произвести реверс: ");
            Console.WriteLine("1) Уже заполненный. ");
            Console.WriteLine("2) Заполненный самостоятельно. ");
            Console.WriteLine("3) Заполненный рандомно. ");
            Console.WriteLine("4) Нулевой массив. ");
            if (Int32.TryParse(Console.ReadLine(), out option))
                switch (option)
                {
                    case 1:
                        Way1();
                        break;
                    case 2:
                        Way2();
                        break;
                    case 3:
                        Way3();
                        break;
                    case 4:
                        Way4();
                        break;
                    default:
                        Console.WriteLine("incorrect input");
                        break;
                }
            else
                Console.WriteLine("incorrect input");
        }

        static void Main(string[] args)
        {
            Way();
        }
    }
}
