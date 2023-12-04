using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment5Delegate
{
    //ominaisuudet
    internal class CustomEvent
    {
        readonly string name;
        string type { get; set; }
        string location { get; set; }
        DateTime date { get; set; }
        double price { get; set; }

        public CustomEvent()
        {

        }

        public CustomEvent(string name, string type, string location, DateTime date, double price)
        {
            //constructor
            this.name = name;
            this.type = type;
            this.location = location;
            this.date = date;
            this.price = price;
        }
        public string Name

        {
            get
            {
                return this.name;

            }
        }

        public string Type()
        { return this.type; }

        public string Location()
            { return this.location; }

        public DateTime Date()
            { return this.date; }
        
        public double Price()
            { return this.price; }


        public override string ToString()
        {
            return $"{name} - {type} - {location} - {date:yyyy-MM-dd} - {price}";
        }
    }
}