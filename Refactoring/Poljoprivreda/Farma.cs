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
        decimal ukZarada = 0;
        foreach (var polje in Polja)
        {
            decimal zaradaZaHa = 0; // prazno polje ne donosi dobit
            switch (polje.Kultura)
            {
                case Kulture.ZOB:
                    zaradaZaHa = 1000;
                    break;
                case Kulture.ZITO:
                    zaradaZaHa = 3000;
                    break;
                case Kulture.JECAM:
                    zaradaZaHa = 2000;
                    break;
                case Kulture.PROSO:
                    zaradaZaHa = 1500;
                    break;
            }
            ukZarada += zaradaZaHa * polje.PovrsinaHa;
        }
        return ukZarada;
    }
}
