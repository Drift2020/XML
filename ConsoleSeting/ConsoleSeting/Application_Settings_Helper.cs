using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ConsoleSeting
{
    class Application_Settings_Helper
    {
        static Application_Settings_Helper()
        {
            ColorFonConsole = Console.BackgroundColor.ToString();
            ColorTextConsole = Console.ForegroundColor.ToString();
            size.H = Console.WindowHeight;
            size.W = Console.WindowWidth;
            StartTextConsole = "C#";
        }
        public static string ColorFonConsole { get; set; }
        public static string ColorTextConsole { get; set; }

        public static SizeWindow size = new SizeWindow();

        public static string StartTextConsole { get; set; }

        public static void Save()
        {
            XmlTextWriter xmlwriter = new XmlTextWriter("Configs.xml", Encoding.UTF8);
            if(xmlwriter!=null)
            {
                xmlwriter.WriteStartDocument();
                xmlwriter.Formatting = Formatting.Indented;
                xmlwriter.IndentChar = '\t'; // Возвращает или задает знак для отступа
                xmlwriter.Indentation = 1;
                xmlwriter.WriteStartElement("Config");
                xmlwriter.WriteStartElement("Console");

                xmlwriter.WriteStartAttribute("ColorFonConsole", null);
                xmlwriter.WriteString(ColorFonConsole);
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteStartAttribute("ColorTextConsole", null); // Записывает атрибут с заданным именем
                xmlwriter.WriteString(ColorTextConsole); // Записывает заданное текстовое содержимое атрибута
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteStartAttribute("size.H", null); // Записывает атрибут с заданным именем
                xmlwriter.WriteString(size.H.ToString()); // Записывает заданное текстовое содержимое атрибута
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteStartAttribute("size.W", null); // Записывает атрибут с заданным именем
                xmlwriter.WriteString(size.W.ToString()); // Записывает заданное текстовое содержимое атрибута
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteStartAttribute("StartTextConsole", null); // Записывает атрибут с заданным именем
                xmlwriter.WriteString(StartTextConsole); // Записывает заданное текстовое содержимое атрибута
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndElement();
                xmlwriter.Close();
            }
           

        }
        public static void Load()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Configs.xml");

            XmlElement xRoot = xDoc.DocumentElement;
         
            XmlNodeList list = xRoot.SelectNodes("Console");
            foreach (XmlNode n in list)
            {
                ColorFonConsole = (n.SelectSingleNode("@ColorFonConsole").Value);
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorFonConsole);
                Console.Clear();
                ColorTextConsole = (n.SelectSingleNode("@ColorTextConsole").Value);
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorTextConsole);

                size.H = Int32.Parse(n.SelectSingleNode("@size.H").Value);
                size.W = Int32.Parse(n.SelectSingleNode("@size.W").Value);
                Console.SetWindowSize(size.W, size.H);

                StartTextConsole = (n.SelectSingleNode("@StartTextConsole").Value);
                Console.Title = StartTextConsole;
            }
        }
    }
}
