using System;

namespace hm_05_Task1
{
    class Program
    {
        int[] mass1 = new int[10];
        int[] mass2 = new int[10];
        int[] sum = new int[10];
        Random fill = new Random();

        public void FillingAndAmount()
        {
            for (int i = 0; i < 10; i++)
            {
                mass1[i] = fill.Next(0, 100);
                Console.WriteLine($"{i + 1} element of mass1: {mass1[i]}");
                Console.Write($"insert {i + 1} element of mass2: ");
                if (Int32.TryParse(Console.ReadLine(), out mass2[i])) ;
                else
                    Console.WriteLine("incorrect input");
                sum[i] = mass1[i] + mass2[i];
            }
            Console.WriteLine($"mass1: {string.Join(", ", mass1)}");
            Console.WriteLine($"mass2: {string.Join(", ", mass2)}");
            Console.WriteLine($"sum: {string.Join(", ", sum)}");
        }

        static void Main(string[] args)
        {
            Program mass = new Program();
            mass.FillingAndAmount();
        }
    }
}
