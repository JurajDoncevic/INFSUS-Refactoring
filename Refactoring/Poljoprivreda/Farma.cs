namespace Poljoprivreda;

public class Farma
{
    public string NazivMjesta { get; set; }
    public List<Polje> Polja { get; set; }

    public decimal OdrediPovrsinu()
    {
        decimal ukPovrsina = 0;
        foreach (var polje in Polja)
            ukPovrsina += polje.PovrsinaHa;
        return ukPovrsina;
    }
}
