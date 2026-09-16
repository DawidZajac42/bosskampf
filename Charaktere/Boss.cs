namespace BossKampf.Charaktere;

public class Boss : Charakter
{
    public Boss(string name, int leben, int angriff) : base(name, leben, angriff) { }

    public override int SpezialAngriff()
    {
        int schaden = Angriff + 8;
        Console.WriteLine(Name + " holt aus und macht " + schaden + " Schaden!");
        return schaden;
    }
}
