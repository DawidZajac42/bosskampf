namespace BossKampf.Charaktere;

public abstract class Charakter
{
    public string Name;
    public int MaxLeben;
    public int Leben;
    public int Angriff;

    public Charakter(string name, int leben, int angriff)
    {
        Name = name;
        MaxLeben = leben;
        Leben = leben;
        Angriff = angriff;
    }

    public bool LebtNoch()
    {
        if (Leben > 0)
        {
            return true;
        }
        return false;
    }

    public abstract int SpezialAngriff();

    public int NormalerAngriff()
    {
        return Angriff;
    }

    public void ErleideSchaden(int schaden)
    {
        Leben = Leben - schaden;
        if (Leben < 0)
        {
            Leben = 0;
        }
    }

    public void ZeigeStatus()
    {
        Console.WriteLine(Name + ": " + Leben + "/" + MaxLeben + " HP");
    }

    public void LevelUp(int lebenPlus, int angriffPlus)
    {
        MaxLeben = MaxLeben + lebenPlus;
        Leben = Leben + lebenPlus;
        Angriff = Angriff + angriffPlus;
    }
}
