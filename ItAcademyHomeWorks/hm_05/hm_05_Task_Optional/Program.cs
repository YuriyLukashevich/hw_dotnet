using System;

namespace hm_05_Task_Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            // начал выдавать какие-то значения на такой размерности массива
            Int64[] array1 = new Int64[10000000];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = num.Next(0, 50);
            }
            //Stopwatch for Program.Reverse
            System.Diagnostics.Stopwatch watch1 = System.Diagnostics.Stopwatch.StartNew();
            Program.Reverse(array1);
            watch1.Stop();
            Console.WriteLine($"Reverse metod: {watch1.ElapsedMilliseconds}");
            //Stopwatch for Program.My
            System.Diagnostics.Stopwatch watch2 = System.Diagnostics.Stopwatch.StartNew();
            Program.My(array1);
            watch2.Stop();
            Console.WriteLine($"My method: {watch2.ElapsedMilliseconds}");
        }

        public static void Reverse(Array array)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            Array.Reverse(array, array.GetLowerBound(0), array.Length);
        }

        public static void My(Array array)
        {
            Array.Reverse(array);
        }
    }
}
