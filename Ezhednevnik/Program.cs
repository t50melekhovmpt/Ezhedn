using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezhednevnik
{
    internal class Program
    {
        static void Zametka1()
        {
            ConsoleKeyInfo key1 = Console.ReadKey();
            int position = 1;

            DateTime dateTime = new DateTime(2022, 10, 20);
            new DateTime(2022, 10, 20);
            Console.WriteLine(dateTime);
            Console.WriteLine("  1.Едааа");
            Console.WriteLine("  2.Табачка");
            ConsoleKeyInfo key2 = Console.ReadKey();

            if (position == 3 && key2.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("OPa");
                timetable1();
                Console.ReadLine();
                if (key1.Key == ConsoleKey.Enter)
                {

                    Console.Clear();
                    timetable1();
                    Console.ReadKey(key1.Key == ConsoleKey.End);
                    
                }
            }
            /*if (position == 2)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    //position = 1; 
                    timetable2();
                    Console.ReadKey(key.Key == ConsoleKey.End);
                    //Console.Clear();
                }

            }*/
        }
        static void Zametka2()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int position = 1;

            DateTime dateTime = new DateTime(2022, 05, 13);
            new DateTime(2022, 05, 13);
            Console.WriteLine(dateTime);
            Console.WriteLine("  1.ДЗ                 ");
            Console.WriteLine("  2.Свободное время    ");
            if (position == 1)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    timetable3();
                    //Console.ReadKey(key.Key == ConsoleKey.End);
                    //Console.Clear();
                }
            }
            if (position == 2)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    timetable4();
                    //Console.ReadKey(key.Key == ConsoleKey.End);
                    //Console.Clear();
                }
            }
        }
        static void timetable1()
        {
            Console.WriteLine("   Купить покушац");
            Console.WriteLine("   -----------------------------------");
            Console.WriteLine("   Описание:Зайти в магазин за дошиком");
            DateTime segodnja= new DateTime(2022,11,12);
            Console.WriteLine(segodnja);
        }
        static void timetable2()
        {
            Console.WriteLine("   Бросить курить");
            Console.WriteLine("   ------------------");
            Console.WriteLine("   Описание:Нереально");
            DateTime segodnja = new DateTime(2022, 11, 15);
            Console.WriteLine(segodnja);
        }
        static void timetable3()
        {
            Console.WriteLine("Не получить 2");
            Console.WriteLine("----------------------");
            Console.WriteLine("Описание:Сдать домашку");
            DateTime segodnja = new DateTime(2022, 11, 19);
            Console.WriteLine(segodnja);
        }
        static void timetable4()
        {
            Console.WriteLine("Кайфануть");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Описание:Пойти на концерт и получить по лицу");
            DateTime segodnja = new DateTime(2022, 11, 19);
            Console.WriteLine(segodnja);
        }
        static void Main(string[] args)
        {
            string strelochka = "->";
            ConsoleKeyInfo key = Console.ReadKey();
            int position = 1; 

            while (true)
            {

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    position = 0;
                    Console.SetCursorPosition(0, position);
                    Zametka2();
                    position = 1;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    //position = 0;
                    //Console.SetCursorPosition(0, position);
                    Zametka1();
                    //position = 1;
                    //Console.Clear();
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;  
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }             
                if (position == -1)
                {
                    position = 1;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    position = 0;
                    Console.SetCursorPosition(0, position);
                    Zametka2();
                    position = 1;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    position = 0;
                    Console.SetCursorPosition(0, position);
                    Zametka1();
                    position = 1;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine(strelochka);
                key = Console.ReadKey();

            }
        }
        
    }
    
}
