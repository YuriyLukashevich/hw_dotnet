using System;
using System.Collections.Generic;
using System.Text;

namespace hm_08
{
    class Check_in : Hello
    {
        protected const string _yes = "да";
        protected const string _no = "нет";
        protected readonly string dangerBaggage = "наркоти";
        protected readonly string baggage = "наркоти одежда кружка деньги";
        protected readonly string handLuggage = "ноутбук книжка";

        public void Registration()
        {
            HelloMan();
            InsertName();
            Console.WriteLine($"{firstName} {patronymic}, вы проходили заранее регистрацию через интернет?");
            bool result = false;
            while (result == false)
            {
                var variant = Console.ReadLine();
                switch (variant)
                {
                    case _yes:
                        result = true;
                        Console.WriteLine($"{firstName} {patronymic}, ваш паспорт и билет приняты, спасибо.");
                        break;
                    case _no:
                        result = true;
                        Console.WriteLine($"{firstName} {patronymic}, дайте свой паспорт пожалуйста.");
                        Console.WriteLine("Спасибо, вы успешно зарегестрированы.");
                        break;
                    default:
                        Console.Write("Вы ввели неправильный вариант, введите правильный: ");
                        break;
                }
            }            
        }
    }
}
