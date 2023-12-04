using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssigmentVfunc;

namespace AssigmentVfunc
{
    public class CustomEvent
    {
        // Fields
        private readonly string name;
        private string type;
        private string location;
        private DateTime date;
        private double price;


        // Constructor
        public CustomEvent()
        {
           
        }
        // Constructor
        public CustomEvent(string name, string type, string location, DateTime date, double price)
        {
            this.name = name;
            this.type = type;
            this.location = location;
            this.date = date;
            this.price = price;
        }

        // Properties
        public string Name
        {
            get { return this.name; }
        }

        public string Type
        {
            get { return this.type; }
            
        }

        public string Location
        {
            get { return this.location; }
            
        }

        public DateTime Date
        {
            get { return this.date; }
            
        }

        public double Price
        {
            get { return this.price; }
            

        }


        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Location: {Location}, Date: {Date:yyyy-MM-dd}, Price: {Price:C}";
        }
    }

}

