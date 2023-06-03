namespace Flota;
public class Lokacija
{
    public double X { get; set; } // 0 - 10000
    public double Y { get; set; } // 0 - 10000

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
        return Math.Sqrt(Math.Pow(X - lokacija.X, 2) + Math.Pow(Y - lokacija.Y, 2));
    }
}
