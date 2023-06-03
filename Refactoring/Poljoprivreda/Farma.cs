using System.Runtime.Intrinsics.X86;

namespace Poljoprivreda;

public class Farma
{
    public string NazivMjesta { get; set; }
    public List<Polje> Polja { get; set; }

    public decimal OdrediPovrsinu()
    {
        // this is ok...
        // return Polje.Sum(polje => polje.PovrsinaHa);
        // but this is safer for an empty enumerable
        return Polja.Aggregate(0m, (suma, polje) => suma + polje.PovrsinaHa);
    }

    public decimal IzracunajDobit()
    {
        return Polja.Aggregate(0m, (suma, polje) => suma + polje.IzracunajDobit());
    }
}
