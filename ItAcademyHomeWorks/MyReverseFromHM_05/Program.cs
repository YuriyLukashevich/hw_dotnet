using System;

namespace MyReverseFromHM_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            //with 1000
            Int64[] array1 = new Int64[1000];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = num.Next(0, 50);
            }
            Console.WriteLine("With 1.000 elements");            
            Program.Reverse(array1);                        
            Program.MyReverse(array1);            
            //with 10000
            Int64[] array2 = new Int64[10000];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = num.Next(0, 50);
            }
            Console.WriteLine("With 10.000 elements");
            Program.Reverse(array2);
            Program.MyReverse(array2);
            //with 100000
            Int64[] array3 = new Int64[100000];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = num.Next(0, 50);
            }
            Console.WriteLine("With 100.000 elements");
            Program.Reverse(array3);            
            Program.MyReverse(array3);            
        }

        public static void Reverse(Int64 [] array)
        {
            System.Diagnostics.Stopwatch watch1 = System.Diagnostics.Stopwatch.StartNew();
            Array.Reverse(array);
            watch1.Stop();
            Console.WriteLine($"Reverse metod: {watch1.Elapsed}");
        }

        public static void MyReverse(Int64 [] array)
        {
            System.Diagnostics.Stopwatch watch2 = System.Diagnostics.Stopwatch.StartNew();
            Int64 num = 0;
            int j = array.Length-1;
            for (int i = 0; i < array.Length/2; i++)
            {
                num = array[j];
                array[j] = array[i];
                array[i] = num;
                j--;
            }
            watch2.Stop();
            Console.WriteLine($"My method: {watch2.Elapsed}");
        }
    }
}
