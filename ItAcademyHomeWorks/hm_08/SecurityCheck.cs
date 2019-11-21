using System;
using System.Collections.Generic;
using System.Text;

namespace hm_08
{
    class SecurityCheck : Check_in
    {
        int bag = 0;
        string answer;

        public void Baggage()
        {            
            Registration();
            Console.WriteLine($"{firstName} {patronymic}, у вас есть ручная кладь?");
            answer = Console.ReadLine();
            if (answer == Yes)
            {
                bag ++;
                string[] handLuggages = handLuggage.Split(' ');
                for (int i = 0; i < handLuggages.Length; i++)
                {
                    if (handLuggages[i] == dangerBaggage)
                    {
                        Console.WriteLine("У вас найдены наркотики в вашей ручной клади, вам необходимо пройти с нами для дальнейшего разбирательства.");
                        Environment.Exit(0);                        
                    }
                }
            }               
            Console.WriteLine($"{firstName}, у вас есть багаж?");            
            answer = Console.ReadLine();
            if (answer == Yes)
            {
                bag++;
                string[] baggages = baggage.Split(' ');
                for (int i = 0; i < baggages.Length; i++)
                {
                    if (baggages[i] == dangerBaggage)
                    {
                        Console.WriteLine($"{firstName} {patronymic}, у вас найдены наркотики в вашем багаже, вам необходимо пройти с нами для дальнейшего разбирательства.");
                        Environment.Exit(0);
                    }
                }
            }
            if (bag == 0)
            {
                Console.WriteLine("Проверять нечего");
            }
            Console.WriteLine($"{firstName} {patronymic}, у вас не найдено наркотиков, можете пройти к паспортному контролю.");
        }        
    }
}
