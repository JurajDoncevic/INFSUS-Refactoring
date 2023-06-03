namespace Flota;

public class Flota
{
    public string Naziv { get; set; }
    public List<Plovilo> Plovila { get; set; }


    public void ZoviUPomocNajblizeFlotinoPlovilo(Plovilo unesrecenoPlovilo)
    {
        Plovilo najblizePlovilo = Plovila.First(); // uvijek ima plovila u Floti
        double najblizaUdaljenost = najblizePlovilo.UdaljenostOd(unesrecenoPlovilo.LokacijaX, unesrecenoPlovilo.LokacijaY);

        // pronadi najblize plovilo unesrecenom plovilu
        foreach (var flotinoPlovilo in Plovila)
        {

            if (flotinoPlovilo.UdaljenostOd(unesrecenoPlovilo.LokacijaX, unesrecenoPlovilo.LokacijaY) < najblizaUdaljenost)
            {
                najblizaUdaljenost = flotinoPlovilo.UdaljenostOd(unesrecenoPlovilo.LokacijaX, unesrecenoPlovilo.LokacijaY);
                najblizePlovilo = flotinoPlovilo;
            }
        }

        // najblize plovilo flote neka provjeri lokaciju
        najblizePlovilo.ProvjeriSOSLokaciju(unesrecenoPlovilo.LokacijaX, unesrecenoPlovilo.LokacijaY);
    }
}
