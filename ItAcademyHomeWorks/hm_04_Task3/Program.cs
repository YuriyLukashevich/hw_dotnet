using System;

namespace hm_04_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit newDeposit = new Deposit();
            Console.WriteLine("Введите сумму вклада: ");
            newDeposit.deposit = Convert.ToDouble(Console.ReadLine());
            newDeposit.IncreaseInAmount();
            newDeposit.DepositAmount();
        }
    }
}
