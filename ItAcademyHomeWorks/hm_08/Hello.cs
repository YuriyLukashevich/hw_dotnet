using System;
using System.Collections.Generic;
using System.Text;

namespace hm_08
{
    class Hello
    {
        private const byte NineAM = 9;
        private const byte TwelveAM = 12;
        private const byte FifteenPM = 15;
        private const byte TwentytwoPM = 22;
        public string firstName;
        public string patronymic;
        public string lastName;
        public string NumberFlight { get; set; }

        public Hello()
        {

        }

        public Hello(string firstName, string patronymic, string lastName)
        {
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.lastName = lastName;
        }

        public Hello(string firstName, string patronymic, string lastName, string numberFlight)
        {
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.lastName = lastName;
            this.NumberFlight = numberFlight;
        }

        public void HelloMan()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            Console.WriteLine(now);
            int time = now.Hours;
            if (time >= NineAM & time < TwelveAM)
            {
                Console.Write("Доброе утро. ");
            }
            else if (time >= TwelveAM & time < FifteenPM)
            {
                Console.Write("Добрый день. ");
            }
            else if (time >= FifteenPM & time < TwentytwoPM)
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
