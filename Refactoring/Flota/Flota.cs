namespace Flota;

public class Flota
{
    public string Naziv { get; set; }
    public List<Plovilo> Plovila { get; set; }


    public void ZoviUPomocNajblizeFlotinoPlovilo(Plovilo unesrecenoPlovilo)
    {
        Plovilo najblizePlovilo = DohvatiNajblizeFlotinoPlovilo(unesrecenoPlovilo.LokacijaX, unesrecenoPlovilo.LokacijaY);

        // najblize plovilo flote neka provjeri lokaciju
        najblizePlovilo.ProvjeriSOSLokaciju(unesrecenoPlovilo.LokacijaX, unesrecenoPlovilo.LokacijaY);
    }

    private Plovilo DohvatiNajblizeFlotinoPlovilo(double lokacijaX, double lokacijaY)
    {
        Plovilo najblizePlovilo = Plovila.First(); // uvijek ima plovila u Floti
        double najblizaUdaljenost = najblizePlovilo.UdaljenostOd(lokacijaX, lokacijaY);

        // pronadi najblize plovilo unesrecenom plovilu
        foreach (var flotinoPlovilo in Plovila)
        {

            if (flotinoPlovilo.UdaljenostOd(lokacijaX, lokacijaY) < najblizaUdaljenost)
            {
                najblizaUdaljenost = flotinoPlovilo.UdaljenostOd(lokacijaX, lokacijaY);
                najblizePlovilo = flotinoPlovilo;
            }
        }

        return najblizePlovilo;
    }
}
