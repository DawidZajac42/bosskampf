namespace BossKampf.Charaktere;

public class Gegner : Charakter
{
    public Gegner(string name, int leben, int angriff) : base(name, leben, angriff) { }

    public override int SpezialAngriff()
    {
        int schaden = Angriff + 4;
        Console.WriteLine(Name + " greift wild an fuer " + schaden + " Schaden!");
        return schaden;
    }
}
