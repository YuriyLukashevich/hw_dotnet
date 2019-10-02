using System;

namespace HW_03_Task1
{
    class Conv
    {
        public int num1;
        public int num2;
        public int sum1;
        public void Num1AndNum2Sum()
        {
            Console.WriteLine("Введите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum1 = num1 + num2;
            Console.WriteLine("sum: {0}", sum1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conv sum = new Conv();            
            sum.Num1AndNum2Sum();
        }
    }
}
