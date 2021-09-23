using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("А1.1");
            string Nsecond=Console.ReadLine();
            decimal nsecond = Convert.ToDecimal(Nsecond);
            decimal nhours = nsecond / 3600;
            int Nhours = (int)nhours;
            decimal nminuts=(nsecond % 3600) / 60;
            int Nminuts = (int)nminuts;
            decimal NSecond= nsecond % 60;
            int nSecond=(int)NSecond;
            Console.WriteLine(Nhours);
            Console.WriteLine(Nminuts);
            Console.WriteLine(NSecond);
           

            Console.WriteLine("А1.2");
            decimal sideA = 543;
            decimal sideB = 130;
            decimal Srectangle = sideA * sideB;
            decimal square = 130;
            decimal Ssquare =  square* square;
            decimal nsquare = Srectangle / Ssquare;
            nsquare = (int)nsquare;
            Console.WriteLine(nsquare);
            
            Console.WriteLine("А1.3");
            int n = int.Parse(Console.ReadLine());
            int x = n % 12;
            Console.WriteLine(x + 1);
            
            Console.WriteLine("А1.4");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal tens = number / 10;
            tens = (int)tens;
            decimal one = number % 10;
            decimal summ = one + tens;
            decimal proizv = one * tens;
            Console.WriteLine("a) "+tens);
            Console.WriteLine("б) " + one);
            Console.WriteLine("в) " + summ);
            Console.WriteLine("г) " + proizv);
          
            Console.WriteLine("А1.5");
            decimal threeNum = decimal.Parse(Console.ReadLine());
            decimal num1 = threeNum / 100;
            num1 = (int)num1;
            decimal twonum = threeNum % 100;
            string Num1 = Convert.ToString(num1);
            string twoNum = Convert.ToString(twonum);
            string newnum = string.Concat(twoNum, Num1);//метод Concat принимает два или более параметров, позволяя объединять строки
            Console.WriteLine(newnum);
          
            Console.WriteLine("А1.6");

            for (int x1 = 100; x1 < 1000; x1++)
            {
                { if ((x1 % 10).ToString() + ((x1 - x % 10) / 10).ToString() == "237")
                    Console.WriteLine(x1);
                }
            }
            Console.ReadKey();
            
              Console.WriteLine("А1.7");
              Console.WriteLine("Введите a2");
              int a2 = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите a1");
              int a1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите b1");
              int b1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите b2");
              int b2 = int.Parse(Console.ReadLine());
              string onechislo = string.Concat(a2, a1);
              string twochislo = string.Concat(b2, b1);
              int sum = int.Parse(onechislo) + int.Parse(twochislo);
              int desyatok = sum / 10;
              int edinic = sum % 10;
              Console.WriteLine("Число десятков "+desyatok);
              Console.WriteLine("Число единиц "+edinic);
            
              Console.WriteLine("А1.8");
              Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            int num;
            if (k % 3 == 0)
            {
                num = (k / 3) % 10;
                Console.WriteLine("k-тая цифра = " + num);

            }
            if (k % 3 == 1)
            {
                num = 1;//  k-тые цифры всегда равны 1
                Console.WriteLine("k-тая цифра = " + num);
            }
            if (k % 3 == 2)
            {
                num= (k+2)/30;
                Console.WriteLine("k-тая цифра = " + num );
            }
          
              Console.WriteLine("А1.9");
              bool A, B, C, a, b, c;
              A = true;
              B = false;
              C = false;
              a = A ^ B;
              b = A & B;
              c = B ^ C;
              Console.WriteLine($"{a}, {b}, {c}");
           
            Console.WriteLine("А1.10");
              for (int X = 0; X <= 1; X++)
                  for (int Y = 0; Y <= 1; Y++)
                      for (int Z = 0; Z <= 1; Z++)
                         Console.WriteLine( $"a){!(Convert.ToBoolean(X) ^ Convert.ToBoolean(Y)) & (!Convert.ToBoolean(X) ^ !Convert.ToBoolean(Z))} {X} {Y} {Z}");

              for (int X = 0; X <= 1; X++)
                for (int Y = 0; Y <= 1; Y++)
                    for (int Z = 0; Z <= 1; Z++)
                        Console.WriteLine($"б){!(!(Convert.ToBoolean(X)) & Convert.ToBoolean(Y)) ^ (Convert.ToBoolean(X) & !Convert.ToBoolean(Z))} {X} {Y} {Z}");
            for (int X = 0; X <= 1; X++)
                for (int Y = 0; Y <= 1; Y++)
                    for (int Z = 0; Z <= 1; Z++)
                        Console.WriteLine($"б){((Convert.ToBoolean(X)) ^ !(Convert.ToBoolean(Y))) & !(Convert.ToBoolean(X) ^ !Convert.ToBoolean(Z))} {X} {Y} {Z}");
          
            Console.ReadKey();
        }
    }
}
