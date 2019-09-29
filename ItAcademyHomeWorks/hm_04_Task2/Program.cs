using System;

namespace hm_04_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string variant;
            Way way1 = new Way();
            Console.WriteLine("Фигуру необходимо переместить? напишите \"да\" или \"нет\" ");
            do
            {                
                variant = Console.ReadLine();
                switch (variant)
                {
                    case "да":
                        variant = "default";
                        way1.ToWay();
                        Console.WriteLine("Фигуру еще необходимо перемещать? напишите \"да\" или \"нет\" ");
                        break;
                    case "нет":
                        Console.WriteLine("Фигуру никуда перемещать не нужно");
                        break;
                    default:
                        variant = "default";
                        Console.WriteLine("Вы ввели неправильное значение, введите \"да\" или \"нет\" ");
                        break;
                }
            }
            while (variant=="default");
            
            
        }
    }
}
