using System.ComponentModel;
using System;

namespace Lesson5_12._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
              {
               //ДЗ 2
               Console.WriteLine("Введите число A и B (A<B) : ");
             int A=int.Parse(Console.ReadLine());
             int B=int.Parse(Console.ReadLine());
             int summa=0;
             Console.Write($"Нечетное число между {A} и {B} : ");
             for(int i=A+1; i<B; ++i)
             { summa+=i;
                  if(i%2==1)
                  Console.Write($"{i} ");
              }
              Console.WriteLine();
               Console.WriteLine($"Сумма чисел расположен между число {A} и {B} равен : {summa}");
           }
           
           {
            //ДЗ 3;
             Console.WriteLine("\nПрямоугольник");
             for(int i=0; i<8; ++i)
             { 
                 for(int j=0; j<29; ++j)
                 { 
                     if(i==0||i==7||j==0||j==28)Console.Write("*");
                     else Console.Write(" ");
                 }
                 Console.WriteLine();
             }
          Console.WriteLine("\nПрямоугольный треугольник");
          for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 13; j++)
                    if (i == 6 || j == 0 || i * 2 == j) System.Console.Write("*");
                    else System.Console.Write(" ");
                System.Console.WriteLine();
            }
            System.Console.WriteLine("\nРавносторонний треугольник");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 13; j++)
                    if (i == 6 || j + i == 6 || j - i == 6) System.Console.Write("*");
                    else System.Console.Write(" ");
                System.Console.WriteLine();
            }
            System.Console.WriteLine("\nРомб");
            { for(int i=1; i<=13; ++i)
             { 
                 for(int j=1; j<=13; ++j)
                 {   
                     if(i<=7)
                     {
                     if(6+i==j||8-i==j)Console.Write("*");
                     else Console.Write(" ");
                     }
                     else 
                     {
                     if(i-6==j||20-i==j)Console.Write("*");
                     else Console.Write(" ");
                     }
                 }
                 Console.WriteLine("");
             }
                 
          }
           {
               //ДЗ 4
               Console.WriteLine();
            Console.Write("Ваш начальный вклад равен 1000, введите желаемые процент : ");
            float p=float.Parse(Console.ReadLine());
            float S=1000;
            int k=0;
            while(S<=1100)
            { 
                S+=S*p/100;
                ++k;
            }
            Console.WriteLine();
            Console.WriteLine($"Ваш вклад после {k} месяцов равно : {S}");
           }

       }
     }
        }
    }

