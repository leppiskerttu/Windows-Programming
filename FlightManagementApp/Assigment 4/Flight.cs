public class Flight : IComparable<Flight>
{
    // Lentoluokan ominaisuudet, jotka kuvaavat lentotietoja.
    public int Id { get; }
    public string Origin { get; }
    public string Destination { get; }
    public DateTime Date { get; }
    public double Price { get; }


    public Flight() { }

    public Flight(int id, string origin, string destination, DateTime date, double price)
    {
        // Konstruktori, joka asettaa lentotiedot luokan ominaisuuksiin.
        Id = id;
        Origin = origin;
        Destination = destination;
        Date = date;
        Price = price;
    }

    public int CompareTo(Flight other)
    {
        if (other == null)
            return 1;
        // Jos verrattava lento on null, palautetaan arvo 1, mikä osoittaa, että tämä lento on suurempi.

        if (this.Price > other.Price)
            return 1;
        else if (this.Price < other.Price)
            return -1;
        // Vertaillaan lentojen hintoja. Palautetaan 1, jos tämän lento on kalliimpi, -1 jos toinen lento on kalliimpi.

        return 0;
        // Jos hinnat ovat samat, palautetaan arvo 0 osoittaen, että lennot ovat yhtä suuret hinnan suhteen.
    }


    public override string ToString()
    {
        return $"Flight ID: {Id}\nOrigin: {Origin}\nDestination: {Destination}\nDate: {Date.ToString("MM/dd/yyyy")}\nPrice: {Price:C}\n";
    }

}
