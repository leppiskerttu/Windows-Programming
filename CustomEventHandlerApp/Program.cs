using Assigment5Delegate;

internal class Program
{


    static void Main()
    {
        //Luodaan CustomEventHandler-luokan instanssi, joka hoitaa tapahtumien hallinnan.
        CustomEventHandler handler = new CustomEventHandler();


        //Luodaan delegaatit, jotka liittyvät eri toimintoihin (lisääminen, haku, päivittäminen, poistaminen).
        HandleEvent add = new HandleEvent(handler.AddEvent);
        HandleEvent search = new HandleEvent(handler.SearchEvent);
        HandleEvent update = new HandleEvent(handler.UpdateEvent);
        HandleEvent delete = new HandleEvent(handler.DeleteEvent);

        //Käytetään "add"-delegaattia lisätäkseen tapahtumia ja tulostetaan tulokset.
        Console.WriteLine("1. Add Event");
        Console.WriteLine(handler.HandleEvent(add, "Jääkiekkopeli", "Urheilu", "Sähko Areena", new DateTime(2023, 11, 15), 20.00));
        Console.WriteLine(handler.HandleEvent(add, "Keikka", "Musiikki", "Leipätehdas", new DateTime(2023, 12, 10), 25.00));
        Console.WriteLine(handler.HandleEvent(add, "Jalkapallopeli", "Urheilu", "Hietalahden Stadion", new DateTime(2024, 2, 5), 15.00));

        // Näytetään kaikki tapahtumat.
        Console.WriteLine("2. Display all events");
        Console.WriteLine(handler.DisplayALLEvents());

        // Käytetään "search"-delegaattia etsimään tapahtumia ja tulostetaan hakutulokset.
        Console.WriteLine("3. Search Event");
        Console.WriteLine(handler.HandleEvent(search, "Jääkiekkopeli", "Urheilu", "Sähko Areena", new DateTime(2023, 11, 15), 20.00));
        Console.WriteLine(handler.HandleEvent(search, "Ruokailu", "Kasuaali", "Ravintola Serveri", new DateTime(2023, 12, 31), 3.50));

        // Käytetään "update"-delegaattia päivittämään tapahtumia ja tulostetaan päivitykset.
        Console.WriteLine("4. Update Event");
        Console.WriteLine(handler.HandleEvent(update, "Jääkiekkopeli", "muutos", "testitesti", new DateTime(2023, 11, 15), 130.00));
        Console.WriteLine(handler.HandleEvent(update, "Jalkapallopeli", "päivitys", "boomboom", new DateTime(2024, 2, 5), 45.00));

        // Käytetään "delete"-delegaattia poistamaan tapahtumia ja tulostetaan poistetut tapahtumat.
        Console.WriteLine("5. Delete Event");
        Console.WriteLine(handler.HandleEvent(delete, "Keikka", "Musiikki", "Leipätehdas", new DateTime(2023, 12, 10), 25.00)); 

        // Näytetään päivitetty tapahtumalista.
        Console.WriteLine("6. Updated list");
        Console.WriteLine("\n" + handler.DisplayALLEvents());


        Console.WriteLine(CustomEventHandler.Log);
    }
}

