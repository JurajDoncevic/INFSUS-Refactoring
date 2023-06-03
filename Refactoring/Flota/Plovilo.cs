namespace Flota;

public class Plovilo
{
    public string Naziv { get; set; }
    public int SnagaMotora { get; set; }
    public Kapetan Kapetan { get; set; }

    // lokacija
    public double LokacijaX { get; set; } // 0 - 10000
    public double LokacijaY { get; set; } // 0 - 10000

    public double VratiLokacijuXStupnjevi()
    {
        double lokacijaXStupnjevi = 0;
        // izracun
        return lokacijaXStupnjevi;
    }

    public double VratiLokacijuYStupnjevi()
    {
        double lokacijaYStupnjevi = 0;
        // izracun
        return lokacijaYStupnjevi;
    }

    public double UdaljenostOd(double lokacijaX, double lokacijaY)
    {
        return Math.Sqrt(Math.Pow(LokacijaX - lokacijaX, 2) + Math.Pow(LokacijaY - lokacijaY, 2));
    }
        
    public void ProvjeriSOSLokaciju(double lokacijaY, double lokacijaX)
    {
        // Upisi koor lokacije u GPS
        // Motori na 100%
        // ...
    }
}
