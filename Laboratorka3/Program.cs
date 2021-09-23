using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka3
{
    struct BankInfo
    {
        public int Identification;
        public string Type;
        public int Balance;

        public void DisplayInfo()//метод
        {
            Console.WriteLine($"Identification={Identification} Type={Type} Balanse={Balance}");
        }
    }
    public enum Bank
    {
        SavingCount,
        ActualCount,
    }
    public enum University
    {
        КГУ,
        КАИ,
        КХТИ
    }
    public struct Worker
    {
        public University university;
        public string Name;
        public void DisplayInfo()//метод
        {
            Console.WriteLine($"Name={Name} Univerity={university}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Bank SavingCount = Bank.SavingCount;
            Console.WriteLine(SavingCount);
            Bank ActualCount = Bank.ActualCount;
            Console.WriteLine(ActualCount);

            Console.WriteLine("Задание 2");
            BankInfo user;//имя переменной
            user.Identification = 45;
            user.Type = "Сберегательный";
            user.Balance = 23457;
            user.DisplayInfo();


            Console.WriteLine("Домашнее задание 3.1");
            Worker InfoAboutUniversity;//имя переменной
            Console.WriteLine("Введите имя");
            InfoAboutUniversity.Name = Console.ReadLine();
            Console.WriteLine("Выберите вуз=КГУ(0),КАИ(1).КХТИ(2)");
            int i = int.Parse(Console.ReadLine());
            InfoAboutUniversity.university = (University)(i);

            InfoAboutUniversity.DisplayInfo();
            Console.ReadKey();
        }
    }
}
    

