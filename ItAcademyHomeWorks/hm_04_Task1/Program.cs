using System;

namespace hm_04_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numberLetter = 122; numberLetter>=97; numberLetter--)
            {
                Console.WriteLine(Convert.ToChar(numberLetter));
            }
        }
    }
}
