using System;

namespace hm_06_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //забил сразу стихотворение, вместо ввода c консоли, чтобы не вводить постоянно
            //строки стихотворения разделил ";"
            string verse = "Я помню чудное мгновенье:;Передо мной явилась ты,;Как мимолетное виденье,;Как гений чистой красоты.";
            string[] verse1 = verse.Split(';');
            string[] verse3 = new string[verse.Length];
            //verse before replace
            Console.WriteLine("Verse before replace: \n");
            for (int i = 0; i < verse1.Length; i++)
            {
                Console.WriteLine(verse1[i]);
            }
            //after replace "o" by "a"
            Console.WriteLine("\nVerse after replace: \n");
            for (int i = 0; i < verse1.Length; i++)
            {
                verse3[i] = verse1[i].Replace("о", "а");
                Console.WriteLine(verse3[i]);
            }
        }
    }
}
