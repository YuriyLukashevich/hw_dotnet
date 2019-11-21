using System;
using System.Collections.Generic;
using System.Text;

namespace hm_08
{
    class PassportControl : SecurityCheck
    {
        public void CheckPassport()
        {
            Baggage();
            Random num = new Random();
            Console.WriteLine("Идет проверка вашей личности.");
            Console.WriteLine("Проверка паспорта:");
            //с вероятность 1 к 2 окажется, что паспорт в розыске или виза недействительна и далее проход закрыт.
            int variant1 = num.Next(1, 2);
            if (variant1 == 2)
            {
                Console.WriteLine("Ваш паспорт в розыске");
                Environment.Exit(0); 
            }
            else
                Console.WriteLine("Ваш паспорт в порядке.");
            Console.WriteLine("Проверка визы: ");
            variant1 = num.Next(1, 2);
            if (variant1 == 1)
            {
                Console.WriteLine("Ваша виза недействительна");
                Environment.Exit(0);
            }
            else
                Console.WriteLine("Ваша виза в порядке.");
            Console.WriteLine($"{firstName} {patronymic}, вы прошли все проверки, удачного полета!");
        }
    }
}
