using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(5, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.WindowHeight = 10;
            Console.WindowWidth = 35;

            Console.WriteLine("Привет Сергей!\nКак успехи?\nУспехи нормальные!...]\b \b");
            //Console.Clear();

            Console.ReadKey();
        }
    }
}