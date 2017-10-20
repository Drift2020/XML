using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Tehnic
{
    class Start
    {
        static List<Storeg> list = new List<Storeg>();

        static void Add()
        {
            NAME name;
            Console.Write("Please, enter name of firm:");
            name.name_of_firm= Console.ReadLine();

            Console.Write("Please, enter model:");
            name.model = Console.ReadLine();

            Console.Write("Please, enter seria:");
            name.seria = Console.ReadLine();

            Console.Write("Please, enter number:");
            name.number=Int32.Parse(Console.ReadLine());

            MANUFACTURE manufacture;
            Console.Write("Please, enter name of country:");
            manufacture.name_of_country = Console.ReadLine();

            Console.Write("Please, enter day:");
            manufacture.date.day = Int32.Parse(Console.ReadLine());

            Console.Write("Please, enter month:");
            manufacture.date.month = Int32.Parse(Console.ReadLine());

            Console.Write("Please, enter year:");
            manufacture.date.year = Int32.Parse(Console.ReadLine());

            CHARACTERISTICS characteristics;
            Console.Write("Please, enter power:");
            characteristics.power = Console.ReadLine();

            Console.Write("Please, enter additional characteristics:");
            characteristics.additional_characteristics = Console.ReadLine();

            Console.Write("Please, enter main characteristics:");
            characteristics.main_characteristics = Console.ReadLine();

            PRICE price;
            Console.Write("Please, enter price retail:");
            price.price_retail = Int32.Parse(Console.ReadLine());

            Console.Write("Please, enter price wholesale:");
            price.price_wholesale = Int32.Parse(Console.ReadLine());

            INFO_TO_CRED info_to_cred;
            Console.Write("Please, enter count month:");
            info_to_cred.count_month = Int32.Parse(Console.ReadLine());

            Console.Write("Please, enter prise of month:");
            info_to_cred.prise_of_month = Int32.Parse(Console.ReadLine());


            Storeg temp = new Storeg(name, manufacture, characteristics, price, info_to_cred);
            list.Add(temp);

        }
        static void PrintToXML()
        {
            // XmlTextWriter представляет средство записи, предоставляющее способ быстрого прямого создания XML-файлов 
            XmlTextWriter xmlwriter = new XmlTextWriter("../../prise_liist.xml", Encoding.UTF8);
            xmlwriter.WriteStartDocument();// Записывает объявление XML с номером версии 1.0
            // Formatting определяет способ форматирования выходных данных
            xmlwriter.Formatting = Formatting.Indented; //Форматирует отступы в дочерних элементах в соответствии с параметрами настройки IndentChar и Indentation


            xmlwriter.IndentChar = '\t'; // Возвращает или задает знак для отступа
            xmlwriter.Indentation = 1; // Возвращает или задает количество записываемых IndentChars для каждого уровня в иерархии

            xmlwriter.WriteStartElement("technics"); // Записывает указанный открывающий тег
          foreach(Storeg e in list)
            {
                e.PrintXML(xmlwriter);
            }
            


            xmlwriter.WriteEndElement();
            Console.WriteLine("Данные сохранены в XML-файл");
            xmlwriter.Close();
        }
        static void PrintMenu()
        {
            Console.Write("1. Add\n2.Print to XML\nPlease, enter number:");
        }
        static void Main(string[] args)
        {
            try {
                int number;
                do {
                    Console.Clear();
                    PrintMenu();
                    number =Int32.Parse(Console.ReadLine());
                    switch(number)
                    {
                        case 1:
                            Add();
                            Console.Clear();
                            break;
                        case 2:
                            PrintToXML();
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
