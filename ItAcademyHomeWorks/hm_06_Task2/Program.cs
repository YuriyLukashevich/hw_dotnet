using System;

namespace hm_06_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string words = Console.ReadLine();
            Console.WriteLine($"Исходная строка: {words}");
            //SortArray(words);
            Console.Write("delete long word: ");
            DeleteLongWord(words);
            Console.Write("replace long and short word: ");
            ReplaceLongAndShortWord(words);
            //counting
            Console.WriteLine("Подсчет букв и пунктуационных знаков: ");
            Counting(words);
            //sort
            Console.WriteLine("Сортировка от самого большего слова к меньшему: ");
            SortArray(words);
        }

        static void DeleteLongWord(string word)
        {
            string[] words = word.Split(' ');
            string longWord = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longWord.Length)
                {
                    longWord = words[i];
                }
            }
            word = word.Replace(longWord, "\b");
            Console.WriteLine(word);
        }

        static void ReplaceLongAndShortWord(string word)
        {
            string[] words = word.Split(' ');
            string longWord = "";
            string shortWord = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longWord.Length)
                {
                    longWord = words[i];
                }
                if (shortWord.Length > words[i].Length)
                {
                    shortWord = words[i];
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == longWord)
                {
                    words[i] = shortWord;
                    continue;
                }
                if (words[i] == shortWord)
                {
                    words[i] = longWord;
                    continue;
                }
            }
            Console.WriteLine(String.Join(" ", words));
        }

        static void Counting(string word)
        {
            char[] letters = word.ToCharArray();
            int numLetters = 0;
            int numSign = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLetter(letters[i]))
                {
                    numLetters++;
                }
                else if (char.IsPunctuation(letters[i]))
                {
                    numSign++;
                }
            }
            Console.WriteLine($"number of letters: {numLetters}.\nnumber of punctuation: {numSign}");
        }

        static void SortArray(string word)
        {
            Console.WriteLine($"исходная строка: {word}");
            string[] words = word.Split(' ');
            string numWord;
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Length > words[j].Length)
                    {
                        numWord = words[i];
                        words[i] = words[j];
                        words[j] = numWord;
                    }
                }
            }
            Array.Reverse(words);
            Console.WriteLine($"отсортированная строка: {String.Join(" ", words)}");
        }
    }
}
