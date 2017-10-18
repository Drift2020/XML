using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeting
{
    class Start
    {
        public static void print()
        {
            Console.WriteLine("Изменить цвет фона - 1");
            Console.WriteLine("Изменить цвет текста - 2");
            Console.WriteLine("Изменить размер окна - 3");
            Console.WriteLine("Изменить заголовок - 4");
            Console.WriteLine("Сохранить настройки - 5");
            Console.WriteLine("Загрузить настройки - 6");
            Console.WriteLine("Выход - 666");
            Console.Write("Ввод:");
        }
        public static void Main()
        {
            try
            {
                bool worc = true;
                do
                {
                    try
                    {

                        print();
                        int numbers = 0;
                        numbers = Convert.ToInt32(Console.ReadLine());
                        switch (numbers)
                        {
                            case 1:
                                Console.Clear();

                                Application_Settings_Helper.ColorFonConsole = (UserInterface.ColorFon());
                                break;
                            case 2:
                                Console.Clear();
                                Application_Settings_Helper.ColorTextConsole = (UserInterface.ColorText());
                                break;
                            case 3:
                                Console.Clear();
                                Application_Settings_Helper.size = (UserInterface.SizeWindows());
                                break;
                            case 4:
                                Console.Clear();
                                Application_Settings_Helper.StartTextConsole = (UserInterface.StartText());
                                break;
                            case 5:
                                Console.Clear();
                                Application_Settings_Helper.Save();
                                break;
                            case 6:
                                Console.Clear();
                                Application_Settings_Helper.Load();
                                break;
                            case 666:
                                Console.Clear();
                                worc = false;
                                break;
                            default:
                                Console.Clear();
                                break;
                        };
                    }
                    catch (Exception ex) { Console.Clear(); Console.WriteLine(ex); }
                } while (worc);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
