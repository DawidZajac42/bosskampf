namespace BossKampf.Charaktere;

public class Krieger : Charakter
{
    private int wutstufe = 0;

    public Krieger(string name) : base(name, 120, 15) { }

    public override int SpezialAngriff()
    {
        wutstufe = wutstufe + 1;
        int schaden = Angriff + wutstufe * 5;
        Console.WriteLine(Name + " wird wuetend und macht " + schaden + " Schaden!");
        return schaden;
    }
}
