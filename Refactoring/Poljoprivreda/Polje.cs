namespace Poljoprivreda;

public abstract class Polje
{
    public decimal PovrsinaHa { get; set; }
    public abstract decimal ZaradaZaHa { get; }

    public decimal IzracunajDobit()
    {
        return ZaradaZaHa * PovrsinaHa;
    }
}
