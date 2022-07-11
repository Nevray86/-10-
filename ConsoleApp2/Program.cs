using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example001
{/// <summary>
/// создаем массив из 10 чисел
/// </summary>
    class Keeper
    {
        public int[] Array = new int[10];
        public Keeper()
        {
            for (int i = 0; i < 10; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }
        }
       /// <summary>
       /// функция выводит массив на экран
       /// </summary>
        public void Print()
        {
            for (int i = 0; i < Array.Length; i ++)
            {
                 Console.Write(Array[i]); Console.Write(".");
            }
            Console.Write("\n");
        }
        /// <summary>
        /// функция сортирует массив
        /// </summary>
        public void Sort()
        {
            int tmp = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Array[j] < Array[j + 1])
                    {
                        tmp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = tmp;
                    }

                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            var Massiv = new Keeper();
            Massiv.Print();
            //Massiv.Rand();
           // Massiv.Print();
            Massiv.Sort();
            Massiv.Print();
        }
    }
}