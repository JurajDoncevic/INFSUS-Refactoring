namespace Flota;

public class Plovilo
{
    public string Naziv { get; set; }
    public int SnagaMotora { get; set; }
    public Kapetan Kapetan { get; set; }

    // lokacija
    public Lokacija Lokacija { get; set; }

    public double UdaljenostOdLokacije(Lokacija lokacija)
    {
        return Lokacija.UdaljenostOd(lokacija);
    }
    public void ProvjeriSOSLokaciju(Lokacija lokacija)
    {
        // Upisi koor lokacije u GPS
        // Motori na 100%
        // ...
    }
}
