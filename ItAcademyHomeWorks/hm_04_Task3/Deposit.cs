using System;
using System.Collections.Generic;
using System.Text;

namespace hm_04_Task3
{
    class Deposit
    {
        public double deposit;
        //массивы, чтобы забить данные за каждый месяц в году по приросту и накопленной сумме
        public double [] increase = new double [12];
        public double [] depositAmount = new double[12];
        public double depositForIncrease;
        public double depositForAmount;

        public void IncreaseInAmount()
        {
            depositForIncrease = deposit;
            for(int i = 0; i < 12; i++)
            {
                increase[i] = depositForIncrease * 0.02;                
                depositForIncrease += increase[i];
                //чтобы вывести только до с 1 по 10 месяц
                if (i < 10)
                {
                    Console.WriteLine($"Прирост за {i + 1}-ый месяц составил: {increase[i]}");
                }
            }
        }
        public void DepositAmount()
        {
            depositForAmount = deposit;
            for (int i = 0; i < 12; i++)
            {
                depositAmount[i] = depositForAmount + increase[i];
                depositForAmount += increase[i];
                //чтобы вывести сумму вклада с 3 по 12 месяц
                if (i >= 2)
                {
                    Console.WriteLine($"Сумма вклада через {i + 1} месяцев составит: {depositAmount[i]}");
                }
            }
        }
    }
}
