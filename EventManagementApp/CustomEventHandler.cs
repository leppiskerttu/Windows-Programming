using AssigmentVfunc;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentVfunc
{
    public class CustomEventHandler
    {
        private SortedList<string, CustomEvent> events;
        private static StringBuilder log = new StringBuilder();

        public CustomEventHandler()
        {
            events = new SortedList<string, CustomEvent>();
            log.AppendLine($"{DateTime.Now} - Log initialized");
        }

        // Hae tapahtuma
        public string SearchEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach (CustomEvent customEvent in events.Values)
            {
                // Vertaa jokaista hakuparametria 
                if (customEvent.Name.Equals(name) ||
                    customEvent.Type.Equals(type) ||
                    customEvent.Location.Equals(location) ||
                    customEvent.Date.Equals(date) ||
                    customEvent.Price.Equals(price))
                {
                    string result = $"Event searched: {customEvent}";
                    log.AppendLine(result);
                    return result;
                }
            }
            return "";
        }

        // Lisää tapahtuman
        public string AddEvent(string name, string type, string location, DateTime date, double price)
        {
            // Luo uusi tapahtuma
            CustomEvent newEvent = new CustomEvent(name, type, location, date, price);
            // Lisää tapahtuma
            events.Add(name, newEvent);
            string result = $"Event added: {newEvent}";
            log.AppendLine(result);
            return result;
        }

        // Func delegate joka ottaa DateTime ja CustomEvent parametereinä ja palauttaa string
        public void HandleEvent(Func<DateTime, CustomEvent, string> funcObject,DateTime specificDate)
        {
            //DateTime specificDate = DateTime.Parse("2023-11-09");

            foreach (var customEvent in events.Values)
            {
                string result = funcObject.Invoke(specificDate, customEvent);
                Console.WriteLine(result);
                log.AppendLine(result);
            }
        }
       
        // Action delegate joka ottaa double ja CustomEvent parametereinä
        public void HandleEvent(Action<double, CustomEvent> actionObject,double maxPrice)
        {
            foreach (var customEvent in events.Values)
            {
                // Invokea käytetään suorittamaan delegaatti
                actionObject.Invoke(maxPrice, customEvent);
                string result = $"Action invoked on event: {customEvent}";
                log.AppendLine(result);
            }
        }

        // Predicate delegate joka ottaa CustomEvent parametrinä 
        public void HandleEvent(Predicate<CustomEvent> predicateObject)
        {
            foreach (var customEvent in events.Values)
            {
                if (predicateObject.Invoke(customEvent))
                {
                    string result = $"{customEvent.Name} - Location Match: {customEvent.Location}";
                    log.AppendLine(result);
                }
            }
        }

        public static string Log
        {
            get
            {
                return log.ToString();
            }
        }
    }
}