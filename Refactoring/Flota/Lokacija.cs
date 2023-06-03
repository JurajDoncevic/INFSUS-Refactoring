namespace Flota;
public class Lokacija
{
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

    public double UdaljenostOd(Lokacija lokacija)
    {
        return Math.Sqrt(Math.Pow(LokacijaX - lokacija.LokacijaX, 2) + Math.Pow(LokacijaY - lokacija.LokacijaY, 2));
    }
}
