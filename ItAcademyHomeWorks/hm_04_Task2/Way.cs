using System;
using System.Collections.Generic;
using System.Text;

namespace hm_04_Task2
{
    class Way
    {
        public string way;
        public int wayFromUnicode;
        public void ToWay()
        {
            Console.WriteLine("Введите направление движения: вверх(w), вниз(s), влево(a) или вправо(d)");
            do
            {
                way = Console.ReadLine();
                wayFromUnicode = Convert.ToChar(way);
                switch (wayFromUnicode)
                {
                    case 119:
                        Console.WriteLine("двигаем фигуру вверх");
                        break;
                    case 97:
                        Console.WriteLine("двигаем фигуру влево");
                        break;
                    case 115:
                        Console.WriteLine("двигаем фигуру ввниз");
                        break;
                    case 100:
                        Console.WriteLine("двигаем фигуру вправо");
                        break;
                    default:
                        way = "default";
                        Console.WriteLine("Вы ввели неправильно значение направление, введите w, a, s или d");
                        break;
                }
            }
            while (way == "default");
        }
    }
}
