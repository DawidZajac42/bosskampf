namespace BossKampf.Charaktere;

public class Schurke : Charakter
{
    private Random zufall = new Random();

    public Schurke(string name) : base(name, 90, 12) { }

    public override int SpezialAngriff()
    {
        int wuerfel = zufall.Next(0, 100);

        if (wuerfel < 40)
        {
            int schaden = Angriff * 2;
            Console.WriteLine(Name + " trifft kritisch fuer " + schaden + " Schaden!");
            return schaden;
        }
        else
        {
            Console.WriteLine(Name + " greift an fuer " + Angriff + " Schaden.");
            return Angriff;
        }
    }
}
