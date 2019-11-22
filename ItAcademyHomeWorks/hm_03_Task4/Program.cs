using System;

namespace HW_03_Task4
{
    class Conv
    {
        public int num1;
        public int num2;
        public int sum1;
        public int sum2;
        public int variant;
        public string operator1;
        public void Num1AndNum2Sum()
        {
            Console.WriteLine("Введите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        public void InsertOperator()
        {
            Console.WriteLine("Введите, что необходимо сделать +(сложение) или -(вычитание)");
            do
            {
                operator1 = Console.ReadLine();
                if (operator1 == "+")
                {
                    sum1 = num1 + num2;
                }
                else if (operator1 == "-")
                {
                    Console.WriteLine("Какое число из какого необходимо вычесть, введите 1 или 2");
                    Console.WriteLine("1) Вычесть из первого числа второе");
                    Console.WriteLine("2) Вычесть из второго числа первое");
                    do
                    {
                        variant = Convert.ToInt32(Console.ReadLine());
                        if (variant != 1 & variant != 2)
                        {
                            Console.WriteLine("Вы ввели неверный вариант, введите 1 или 2");
                        }
                    }
                    while (variant != 1 & variant != 2);
                    if (variant == 1)
                    {
                        sum1 = num1 - num2;
                    }
                    else
                    {
                        sum1 = num2 - num1;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный символ. Введите + или -");
                }
            }
            while (operator1 != "+" & operator1 != "-");
        }
        public void Compare()
        {
            Console.WriteLine("Введите результат вычисления: ");
            sum2 = Convert.ToInt32(Console.ReadLine());
            if (sum2 == sum1)
            {
                Console.WriteLine("Результат вычисления правильный");
            }
            else
            {
                Console.WriteLine("Результат вычисления неправильный");
                if (sum2 > sum1)
                {
                    Console.WriteLine("Результат вычисления должен быть меньше");
                }
                else
                {
                    Console.WriteLine("Результат вычисления должен быть больше");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conv sum = new Conv();
            sum.Num1AndNum2Sum();
            sum.InsertOperator();
            sum.Compare();
        }
    }
}
