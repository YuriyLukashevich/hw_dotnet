using System;

namespace hm_06_Task3_Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            //with boxing
            int years = 18;
            string old1 = "I am ";
            string old3 = old1 + years + ".";
            Console.WriteLine(old3);
            //without boxing
            string old2 = "I am " + years.ToString() + ".";
            Console.WriteLine(old2);
        }
    }
}
