using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeting
{
    struct SizeWindow
    {
        public int H { get; set; }
        public int W { get; set; }
    }
    class UserInterface
        {
            private static ConsoleColor[] colors;

            static UserInterface()
            {
                colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            }
            public static void PrintColors()
            {
                for (int i = 0; i < colors.Length; i++)
                    Console.WriteLine(colors[i] + " - " + (i));
                Console.Write("Ввод:");
            }
            public static string ColorFon()
            {
                PrintColors();
                int i = 0;
                i = Convert.ToInt32(Console.ReadLine());
                Console.BackgroundColor = colors[i];
                Console.Clear();
                return colors[i].ToString();
            }
            public static string ColorText()
            {
                PrintColors();
                int i = 0;
                i = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = colors[i];
                Console.Clear();
                return colors[i].ToString();
            }
            public static SizeWindow SizeWindows()
            {
                SizeWindow Nows = new SizeWindow();
                Console.Write("width: ");
                Nows.W = Convert.ToInt32(Console.ReadLine());
                Console.Write("height: ");
                Nows.H = Convert.ToInt32(Console.ReadLine());

                Console.SetWindowSize(Nows.W, Nows.H);

                return Nows;
            }
            public static string StartText()
            {
                Console.Write("Введите новый заголовок консоли: ");
                Console.Title = Console.ReadLine();
                return Console.Title;
            }
        
    }
}
