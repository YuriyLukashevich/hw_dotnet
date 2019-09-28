using System;

namespace HW_03_Task2
{
    class Conv
    {
        public int num1;
        public int num2;
        public int sum1;
        public int sum2;
        public void Num1AndNum2Sum()
        {
            Console.WriteLine("Введите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());            
            sum1 = num1 + num2;
            
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
                Console.WriteLine("Результат вычисления равен {0}", sum1);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conv sum = new Conv();
            sum.Num1AndNum2Sum();
            sum.Compare();
        }
    }
}
