namespace Poljoprivreda;

public class Regija
{
    public string Naziv { get; set; }
    public List<Farma> Farme { get; set; }


    public decimal IzracunajDobit()
    {
        return Farme.Aggregate(0m, (suma, farma) => suma + farma.IzracunajDobit());
    }

    public decimal OdrediUkupnuPovrsinu()
    {
        // this is ok...
        // return Farme.Sum(farma => farma.OdrediPovrsinu());
        // but this is safer for an empty enumerable
        return Farme.Aggregate(0m, (suma, farma) => suma + farma.OdrediPovrsinu());
    }
}
