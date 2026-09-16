namespace BossKampf.Charaktere;

public class Magier : Charakter
{
    public int Mana = 50;

    public Magier(string name) : base(name, 80, 10) { }

    public override int SpezialAngriff()
    {
        if (Mana < 20)
        {
            Console.WriteLine(Name + " hat kein Mana mehr und greift normal an.");
            return NormalerAngriff();
        }

        Mana = Mana - 20;
        int schaden = Angriff * 3;
        Console.WriteLine(Name + " wirkt einen Feuerball fuer " + schaden + " Schaden! (Mana: " + Mana + ")");
        return schaden;
    }
}
