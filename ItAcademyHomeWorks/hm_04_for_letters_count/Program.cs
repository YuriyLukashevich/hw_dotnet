using System;

namespace hm_04_for_letters_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            Console.WriteLine("Введите любое слово");
            String word = Console.ReadLine();
            for(int i=0; i<word.Length; i++)
            {
                if (word[i] == 'а')
                {
                    quantity ++;
                }                
            }
            Console.WriteLine($"Количество букв \"а\" в слове {word} равно: {quantity}");
        }
    }
}
