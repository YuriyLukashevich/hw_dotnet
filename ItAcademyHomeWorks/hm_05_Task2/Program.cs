using System;

namespace hm_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mass();
        }

        static void Mass()
        {
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length - 1; i++)
            {
                Console.Write($"Insert {i + 1} array element: ");
                if (Int32.TryParse(Console.ReadLine(), out mass[i])) ;
                else
                    Console.WriteLine("incorrect input");
            }
            Console.WriteLine($"mass: {string.Join(", ", mass)}");
            Console.Write("Insert new array element: ");
            try
            {
                int newElement = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert position of new array element, enter from 1 to 10:  ");
                int position = Convert.ToInt32(Console.ReadLine());

                foreach (int i in mass)
                {
                    if (position == i)
                    {
                        if (position == mass.Length)
                        {
                            mass[mass.Length] = newElement;
                        }
                        else
                        {
                            for (int j = mass.Length - 1; j >= position; j--)
                            {
                                if (j == position)
                                    mass[position] = newElement;
                                else
                                    mass[j] = mass[j - 1];
                            }
                        }
                    }
                }
                Console.WriteLine($"changed mass: {string.Join(", ", mass)}");
            }
            catch
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}
