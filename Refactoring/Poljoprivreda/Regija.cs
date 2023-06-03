namespace Poljoprivreda;

public class Regija
{
    public string Naziv { get; set; }
    public List<Farma> Farme { get; set; }


    public decimal IzracunajDobit()
    {
        decimal ukZarada = 0;
        foreach(var farma in Farme)
        {
            foreach(var polje in farma.Polja)
            {
                decimal zaradaZaHa = 0; // prazno polje ne donosi dobit
                switch (polje.Kultura)
                {
                    case Kulture.ZOB: zaradaZaHa = 1000;
                        break;
                    case Kulture.ZITO: zaradaZaHa = 3000;
                        break;
                    case Kulture.JECAM: zaradaZaHa = 2000;
                        break;
                    case Kulture.PROSO: zaradaZaHa = 1500;
                        break;
                }
                ukZarada += zaradaZaHa * polje.PovrsinaHa;
            }
        }

        return ukZarada;
    }

    public decimal OdrediUkupnuPovrsinu()
    {
        decimal ukPovrsina = 0;
        foreach (var farma in Farme)
            ukPovrsina += farma.OdrediPovrsinu();
        return ukPovrsina;
    }
}
