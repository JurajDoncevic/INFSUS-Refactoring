namespace Poljoprivreda;

public class Polje
{
    public decimal PovrsinaHa { get; set; }
    public Kulture Kultura { get; set; }

    public decimal IzracunajDobit()
    {
        decimal zaradaZaHa = 0; // prazno polje ne donosi dobit
        switch (Kultura)
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
        return zaradaZaHa * PovrsinaHa;
    }
}
