using System;

namespace Assignment_3
{
    class Concert
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int TicketPrice { get; set; }

        
        public Concert()
        {
        }

        public Concert(string title, string location, DateTime date, int ticketPrice)
        {
            Title = title;
            Location = location;
            Date = date;
            TicketPrice = ticketPrice;
        }

        public override string ToString()
        {
            return $"{Title}, {Location}, {Date.ToShortDateString()}, Ticket Price: ${TicketPrice}";
        }

        public static bool operator ==(Concert concert1, Concert concert2)
        {
            if (ReferenceEquals(concert1, null) && ReferenceEquals(concert2, null))
                return true;

            if (ReferenceEquals(concert1, null) || ReferenceEquals(concert2, null))
                return false;

            return concert1.TicketPrice == concert2.TicketPrice;
        }

        public static bool operator !=(Concert concert1, Concert concert2)
        {
            return !(concert1 == concert2);
        }

        public static bool operator <(Concert concert1, Concert concert2)
        {
            return concert1.TicketPrice < concert2.TicketPrice;
        }

        public static bool operator >(Concert concert1, Concert concert2)
        {
            return concert1.TicketPrice > concert2.TicketPrice;
        }

        public static Concert operator ++(Concert concert)
        {
            concert.TicketPrice += 5;
            return concert;
        }

        public static Concert operator --(Concert concert)
        {
            concert.TicketPrice -= 5;
            return concert;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Concert other = (Concert)obj;
            return TicketPrice == other.TicketPrice;
        }
    }
}
