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
        => Plovila.Aggregate(
            (_1, _2) => 
                _1.UdaljenostOdLokacije(lokacija) > _2.UdaljenostOdLokacije(lokacija) 
                ? _2 
                : _1
            );
}
