using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehnic
{
    struct NAME
    {
        string name_of_firm;
        string model;
        string seria;
        int numbe;
    }
    struct DATE
    {
        int day;
        int month;
        int year;
    }
    struct MANUFACTURE
    {
        string name_of_country;
        DATE date;
    }
    struct CHARACTERISTICS
    {
        string power;
        string additional_characteristics;
        string main_characteristics;
    }
    struct PRICE
    {
        int price_retail;
        int price_wholesale;
    }
    struct INFO_TO_CRED
    {
        string count_month;
        string prise_of_month;
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
      
        public void PrintXML()
        {

        }

    }
}
