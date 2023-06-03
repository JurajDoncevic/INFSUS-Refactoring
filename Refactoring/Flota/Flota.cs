namespace Flota;

public class Flota
{
    public string Naziv { get; set; }
    public List<Plovilo> Plovila { get; set; }


    public void ZoviUPomocNajblizeFlotinoPlovilo(Plovilo unesrecenoPlovilo)
    {
        Plovilo najblizePlovilo = DohvatiNajblizeFlotinoPlovilo(unesrecenoPlovilo);

        // najblize plovilo flote neka provjeri lokaciju
        najblizePlovilo.ProvjeriSOSLokaciju(unesrecenoPlovilo.LokacijaX, unesrecenoPlovilo.LokacijaY);
    }

    private Plovilo DohvatiNajblizeFlotinoPlovilo(Plovilo plovilo)
    {
        Plovilo najblizePlovilo = Plovila.First(); // uvijek ima plovila u Floti
        double najblizaUdaljenost = najblizePlovilo.UdaljenostOd(plovilo.LokacijaX, plovilo.LokacijaY);

        // pronadi najblize plovilo unesrecenom plovilu
        foreach (var flotinoPlovilo in Plovila)
        {

            if (flotinoPlovilo.UdaljenostOd(plovilo.LokacijaX, plovilo.LokacijaY) < najblizaUdaljenost)
            {
                najblizaUdaljenost = flotinoPlovilo.UdaljenostOd(plovilo.LokacijaX, plovilo.LokacijaY);
                najblizePlovilo = flotinoPlovilo;
            }
        }

        return najblizePlovilo;
    }
}
