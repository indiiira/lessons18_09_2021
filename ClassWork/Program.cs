using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Задание 1");
            string b = "sbyte";
            Console.WriteLine( b + $"[{sbyte.MinValue}, {sbyte.MaxValue}]");
            string b1 = "byte";
            Console.WriteLine(b1 + $"[{byte.MinValue}, {byte.MaxValue}]");
            string s = "short";
            Console.WriteLine(s + $"[{short.MinValue}, {short.MaxValue}]");
            string us = "ushort";
            Console.WriteLine(us + $"[{ushort.MinValue}, {ushort.MaxValue}]");
            string i = "int";
            Console.WriteLine(i + $"[{int.MinValue}, {int.MaxValue}]");
            string ui = "uint";
            Console.WriteLine(ui + $"[{uint.MinValue}, {uint.MaxValue}]");
            string l = "long";
            Console.WriteLine(l + $"[{long.MinValue}, {long.MaxValue}]");
            string ul = "ulong";
            Console.WriteLine(ul + $"[{ulong.MinValue}, {ulong.MaxValue}]");
            string f = "float";
            Console.WriteLine(ul + $"[{float.MinValue}, {float.MaxValue}]");
            string d = "double";
            Console.WriteLine(d + $"[{double.MinValue}, {double.MaxValue}]");
            string dc = "decimal";
            Console.WriteLine(dc + $"[{decimal.MinValue}, {decimal.MaxValue}]");
            

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите имя");
            string name=Console.ReadLine();
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите пин-код");
            string pinkod= Console.ReadLine();
            Console.WriteLine("Имя Город Возраст Пин-Код");
            Console.WriteLine($"{name}  {city} {age} {pinkod}");
            
            Console.WriteLine("Задание 3");
            string stroka = Console.ReadLine();
            string strokanew = "";
            foreach (var a in stroka)
            {
                if (char.IsLower(a))
                    strokanew = strokanew + char.ToUpper(a);
                else
                    strokanew = strokanew + char.ToLower(a);
            }
            Console.WriteLine(strokanew);


            Console.WriteLine("Задание 4");
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            Console.Write("Введите подстрoку: ");
            string newline = Console.ReadLine();
            Console.WriteLine((line.Length - line.Replace(newline, "").Length) / newline.Length);
          
            
            Console.WriteLine("Задание 5");
            string speedkm= Console.ReadLine();
            decimal Speed = Convert.ToDecimal(speedkm);
            decimal speedsec = (Speed * 100000) / 3600;
            
            Console.WriteLine((int)(speedsec));
            
           
            Console.WriteLine("Задание 6");
            int ageson = int.Parse(Console.ReadLine());
            int agedad = int.Parse(Console.ReadLine());
            int raznica = 0;
            while (ageson*2!=agedad &ageson>0)
            {
                raznica = raznica + 1;
                agedad = agedad - 1;
            }
            Console.WriteLine(raznica);
           
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите среднюю цену ");
            string normPrice = Console.ReadLine();
            decimal normprice = Convert.ToDecimal(normPrice);
            Console.WriteLine("Введите скидку ");
            string salePrice = Console.ReadLine();
            decimal saleprice = Convert.ToDecimal(salePrice);
            saleprice = saleprice / 100;//проценты
            Console.WriteLine("Введите стоимость отпуска");
            string holidayPrice = Console.ReadLine();
            decimal holidayprice = Convert.ToDecimal(holidayPrice);
            decimal countviski = 0;
            decimal economy = normprice * saleprice;
            countviski = holidayprice / economy;
            Console.WriteLine((int)(countviski));
            
            Console.ReadKey();
        }
    }
}
