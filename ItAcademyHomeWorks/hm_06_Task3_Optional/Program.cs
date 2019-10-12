using System;

namespace hm_06_Task3_Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*насколько я понял при записи ("I am " + 18 + ".") для объединения 
             * вызывается метод String.Concat, но поскольку разные типы, число 18 
             * упаковывается, чтобы привести к объекту. 
             * При работе на одном компьютере упаковки не происходило, оно само 
             * приводило к ToString().  (net. core 3.0)
             * При работе на ноутбуке с другой версией .net core упаковка происходила. (net.core 2.1)
             * Единственное предположение, что упаковка есть(либо нету) зависит от
             * версии net. core?
             * упаковку получилось вызвать только, когда сам уже вызвал Concat. (net. core 3.0)
             * К вышеописанному прилагаю 3 скриншота.
             */
            //with boxing
            string old1 = "I am " + 18 + ".";
            Console.WriteLine(old1);
            //without boxing
            string old2 = "I am " + 18.ToString() + ".";
            Console.WriteLine(old2);
        }
    }
}
