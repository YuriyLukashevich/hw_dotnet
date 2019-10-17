using System;
using System.Collections.Generic;
using System.Text;

namespace hm_08
{
    class Hello
    {
        private const byte nineAM = 9;
        private const byte twelveAM = 12;
        private const byte fifteenPM = 15;
        private const byte twentytwoPM = 22;
        public string firstName;
        public string patronymic;
        public string lastName;
        public string NumberFlight { get; set; }
        
        public void HelloMan()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            Console.WriteLine(now);
            int time = now.Hours;
            if (time >= nineAM & time < twelveAM)
            {
                Console.Write("Доброе утро. ");
            }
            else if (time >= twelveAM & time < fifteenPM)
            {
                Console.Write("Добрый день. ");
            }
            else if (time >= fifteenPM & time < twentytwoPM)
            {
                Console.Write("Добрый вечер. ");
            }
            else
            {
                Console.Write("Доброй ночи. ");
            }
            Console.WriteLine("Вас приветствует аэропорт \"Банзай\". Представьтесь пожалуйста.");
        }

        public void InsertName()
        {
            Console.WriteLine("Введите свое имя пожалуйста: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Введите свое отчество пожалуйста: ");
            patronymic = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию пожалуйста: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Хотите указать номер своего рейса?");
            switch (Console.ReadLine())
            {
                case "да":
                    Console.WriteLine("Номер вашего рейса:");
                    NumberFlight = Console.ReadLine();
                    MyName(firstName, patronymic, lastName, NumberFlight);
                    break;
                case "нет":
                    MyName(firstName, patronymic, lastName);
                    break;
                default:
                    Console.WriteLine("Вы указали неверный вариант.");
                    MyName(firstName, patronymic, lastName);
                    break;
            }
            Console.WriteLine($"{firstName} {patronymic}, пройдите пожалуйста на регистрацию.");
        }

        public void MyName(string firstName, string patronymic, string lastName)
        {
            Console.WriteLine($"Ваше имя: {firstName}, ваше отчество: {patronymic}, ваша фамилия: {lastName}.");
        }

        public void MyName(string firstName, string patronymic, string lastName, string numberFlight )
        {
            Console.WriteLine($"Ваше имя: {firstName}, ваше отчество: {patronymic}, ваша фамилия: {lastName}, № вашего рейса: {numberFlight}.");
        }
    }
}
