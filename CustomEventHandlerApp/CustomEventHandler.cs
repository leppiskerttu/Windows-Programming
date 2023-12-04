using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Assigment5Delegate
{
    class CustomEventHandler
    {
        static StringBuilder log = new StringBuilder();
        // Luodaan SortedList,nimellä ja CustomEvent-oliolla.
        SortedList<string, CustomEvent> events;


        //constructor
        public CustomEventHandler()
        {
            events = new SortedList<string, CustomEvent>();
            log.Append($"{DateTime.Now}");
        }


        // Lisää uuden tapahtuman kokoelmaan.
        // Palauttaa ilmoituksen tapahtuman lisäämisestä.
        public string AddEvent(string name, string type, string location, DateTime date, double price)
        {
            CustomEvent newEvent = new CustomEvent(name, type, location, date, price);
            events[name] = newEvent;
            return $"Event added: {name}. Events in collection: {events.Count}";
        }


        // Etsii tapahtuman nimen perusteella ja palauttaa sen tiedot.
        public string SearchEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach (CustomEvent customEvent in events.Values)
            {
                if (customEvent.Name.Equals(name)||customEvent.Type().Equals(type)||customEvent.Location().Equals(location)||customEvent.Date().Equals(date)||customEvent.Price().Equals(price))
                {
                    return $"Event searched: {customEvent}";
                }
            }
            return "";
        }


        // Päivittää tapahtuman tiedot nimen perusteella.
        public string UpdateEvent(string name, string type, string location, DateTime date, double price)
        {
            if (events.Keys.Contains(name)) 
            {
                CustomEvent oldEvent = events[name];
                events[name] = new CustomEvent(name, type, location, date, price);
                return $"Event updated. Old event: {oldEvent}";
            }
            return "";
        }


        // Poistaa tapahtuman nimen perusteella ja palauttaa poistetun tapahtuman tiedot.
        public string DeleteEvent(string name, string type, string location, DateTime date, double price)
        {
            for (int i = 0; i < events.Count; i++)
            {
                if (events.ContainsKey(name))
                {
                    CustomEvent deletedEvent = events[name];
                    events.Remove(name);
                    return $"Event deleted: {deletedEvent}";
                }
            }
            return null;
        }

        // Käsittelee tapahtuman määritellyn käsittelijäfunktion (HandleEvent) avulla ja palauttaa sen tuloksen.
        public string HandleEvent(HandleEvent handleEvent, string name, string type, string location, DateTime date, double price)
        {
 
            //return handleEvent.Invoke(name, type, location, date, price);

            string result = handleEvent.Invoke(name, type, location, date, price);
            log.AppendLine(result + Environment.NewLine);
            return result;


        }

        // Palauttaa kaikki tapahtumat
        public string DisplayALLEvents()
        {
            StringBuilder all = new StringBuilder();
            foreach (CustomEvent events in events.Values)
            {
                all.Append(events.ToString() + Environment.NewLine);
            }
            return all.ToString();
        }
        // Palauttaa lokin (log)
        public static string Log
        {   
            get
            {
                return log.ToString();
            }
           
        }
    }
}