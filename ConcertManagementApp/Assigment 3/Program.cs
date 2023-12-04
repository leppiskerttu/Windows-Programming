using System;
using System.Collections;
using Assignment_3;

namespace Assigment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList concerts = new ArrayList() {

            new Concert("Title 1", "Location 1", new DateTime(2023, 6, 26), 300),
            new Concert("Title 2", "Location 2", new DateTime(2022, 6, 27), 350),
            new Concert("Title 3", "Location 3", new DateTime(2021, 6, 28), 400),
            new Concert("Title 4", "Location 4", new DateTime(2020, 6, 29), 250),
            new Concert("Title 5", "Location 5", new DateTime(2019, 6, 30), 300)};



            Console.WriteLine("Printing out concerts:");
            foreach(Concert c in concerts) {
                Console.WriteLine(c);
            }

            Console.WriteLine("Comparing concerts:");

            Console.WriteLine("Concert 1 == Concert 2: " +( (Concert)concerts[0] == (Concert)concerts[1]));

            /*
            Console.WriteLine("Concert 1 != Concert 2: " + (concert1 != concert2));  // true
            Console.WriteLine("Concert 1 < Concert 2: " + (concert1 < concert2));    // true
            Console.WriteLine("Concert 1 > Concert 2: " + (concert1 > concert2));    // false
            Console.WriteLine("Concert 3 > Concert 4: " + (concert3 > concert4));    // false
            Console.WriteLine("Concert 5 > Concert 1: " + (concert5 > concert1));    // false
            */
            
            Console.WriteLine("Incrementing Concert 1 price by 5");
            Concert concert1 = (Concert)concerts[0];
            concert1++;
            Console.WriteLine("Concert 1: " + concert1.ToString());



            Console.WriteLine("Decrementing Concert 2 price by 5");
            Concert concert2 = (Concert)concerts[1];
            concert2--;
            Console.WriteLine("Concert 2: " + concert2.ToString());


            Console.WriteLine("Sorting concerts:");

            for (int i = 0; i < concerts.Count; i++)
            {
                for (int j = i + 1; j < concerts.Count; j++)
                {



                    if ((Concert)concerts[i] > (Concert)concerts[j])
                    {
                        var temp1 = concerts[i];
                        concerts[i] = concerts[j];
                        concerts[j] = temp1;
                    }
                }
            }
            foreach (Concert concert in concerts)
            {
                Console.WriteLine(concert.ToString());
            }
        }
            }
        }
