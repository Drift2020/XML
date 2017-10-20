using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tehnic
{
    struct NAME
    {
        public string name_of_firm;
        public string model;
        public string seria;
        public int number;
    }
    struct DATE
    {
        public int day;
        public int month;
        public int year;
    }
    struct MANUFACTURE
    {
        public string name_of_country;
        public  DATE date;
    }
    struct CHARACTERISTICS
    {
        public string power;
        public string additional_characteristics;
        public string main_characteristics;
    }
    struct PRICE
    {
        public int price_retail;
        public int price_wholesale;
    }
    struct INFO_TO_CRED
    {
        public int count_month;
        public int prise_of_month;
    }
    class Storeg
    {
         NAME name;
         MANUFACTURE manufacture;
         CHARACTERISTICS characteristics;
         PRICE price;
         INFO_TO_CRED info_to_cred;
      public Storeg(NAME name, MANUFACTURE manufacture, CHARACTERISTICS characteristics, PRICE price, INFO_TO_CRED info_to_cred)
      {
            this.name = name;
            this.manufacture = manufacture;
            this.characteristics = characteristics;
            this.price = price;
            this.info_to_cred = info_to_cred;
      }
      
        public void PrintXML(XmlTextWriter xmlwriter)
        {
            xmlwriter.WriteStartElement("product");

            xmlwriter.WriteStartAttribute("name_is_firm", null); // Записывает атрибут с заданным именем
            xmlwriter.WriteString(name.name_of_firm); // Записывает заданное текстовое содержимое атрибута
            xmlwriter.WriteEndAttribute(); // Закрывает атрибут

            xmlwriter.WriteStartAttribute("model", null);
            xmlwriter.WriteString(name.model);
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteStartElement("manufacture");
           
            xmlwriter.WriteStartAttribute("name_of_country", null);
            xmlwriter.WriteString(manufacture.name_of_country);
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteStartElement("date");

            xmlwriter.WriteStartAttribute("day", null);
            xmlwriter.WriteString(manufacture.date.day.ToString());
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteStartAttribute("month", null);
            xmlwriter.WriteString(manufacture.date.month.ToString());
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteStartAttribute("year", null);
            xmlwriter.WriteString(manufacture.date.year.ToString());
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteEndElement();
            xmlwriter.WriteEndElement();


            xmlwriter.WriteStartElement("characteristics");

            xmlwriter.WriteStartAttribute("power", null);
            xmlwriter.WriteString(characteristics.power);
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteStartElement("additional_characteristics");
            xmlwriter.WriteString(characteristics.additional_characteristics);
            xmlwriter.WriteEndElement();

            xmlwriter.WriteStartElement("main_characteristics");
            xmlwriter.WriteString(characteristics.main_characteristics);
            xmlwriter.WriteEndElement();

            xmlwriter.WriteEndElement();

            xmlwriter.WriteStartElement("price");

            xmlwriter.WriteStartAttribute("price_retail", null);
            xmlwriter.WriteString(price.price_retail.ToString());
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteStartAttribute("price_wholesale", null);
            xmlwriter.WriteString(price.price_wholesale.ToString());
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteEndElement();

            xmlwriter.WriteStartElement("info_to_cred");

            xmlwriter.WriteStartAttribute("count_month", null);
            xmlwriter.WriteString(info_to_cred.count_month.ToString());
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteStartAttribute("prise_of_month", null);
            xmlwriter.WriteString(info_to_cred.prise_of_month.ToString());
            xmlwriter.WriteEndAttribute();

            xmlwriter.WriteEndElement();


            xmlwriter.WriteEndElement(); // Закрывает один элемент
        }

    }
}
