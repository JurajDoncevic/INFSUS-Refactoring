namespace Flota;

public class Flota
{
    public string Naziv { get; set; }
    public List<Plovilo> Plovila { get; set; }


    public void ZoviUPomocNajblizeFlotinoPlovilo(Plovilo unesrecenoPlovilo)
    {
        Plovilo najblizePlovilo = DohvatiNajblizeFlotinoPlovilo(unesrecenoPlovilo.Lokacija);

        // najblize plovilo flote neka provjeri lokaciju
        najblizePlovilo.ProvjeriSOSLokaciju(unesrecenoPlovilo.Lokacija);
    }

    private Plovilo DohvatiNajblizeFlotinoPlovilo(Lokacija lokacija)
    {
        Plovilo najblizePlovilo = Plovila.First(); // uvijek ima plovila u Floti
        double najblizaUdaljenost = najblizePlovilo.UdaljenostOdLokacije(lokacija);

        // pronadi najblize plovilo unesrecenom plovilu
        foreach (var flotinoPlovilo in Plovila)
        {

            if (flotinoPlovilo.UdaljenostOdLokacije(lokacija) < najblizaUdaljenost)
            {
                najblizaUdaljenost = flotinoPlovilo.UdaljenostOdLokacije(lokacija);
                najblizePlovilo = flotinoPlovilo;
            }
        }

        return najblizePlovilo;
    }
}
