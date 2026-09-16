using BossKampf.Charaktere;

Console.WriteLine("=== BOSS KAMPF ===");
Console.WriteLine("Waehle deinen Helden:");
Console.WriteLine("1) Krieger");
Console.WriteLine("2) Magier");
Console.WriteLine("3) Schurke");
Console.Write("> ");

string? eingabe = Console.ReadLine();

Charakter held;
if (eingabe == "2")
{
    held = new Magier("Mira");
}
else if (eingabe == "3")
{
    held = new Schurke("Kai");
}
else
{
    held = new Krieger("Bjorn");
}

Random zufall = new Random();
string[] monsterNamen = { "Harpie", "Troll", "Ork", "Oger", "Zyklop" };

int runde = 1;
while (runde <= 3)
{
    int zufallsZahl = zufall.Next(0, monsterNamen.Length);
    string name = monsterNamen[zufallsZahl];
    int gegnerLeben = 40 + runde * 15;
    int gegnerAngriff = 8 + runde * 2;
    Gegner gegner = new Gegner(name, gegnerLeben, gegnerAngriff);

    Console.WriteLine("");
    Console.WriteLine("--- Kampf " + runde + " von 3: " + held.Name + " gegen " + gegner.Name + " ---");

    bool gewonnen = Kaempfen(held, gegner);

    if (gewonnen == false)
    {
        Console.WriteLine("");
        Console.WriteLine("Spiel vorbei.");
        return;
    }

    held.LevelUp(15, 2);
    Console.WriteLine(held.Name + " wird staerker! (+15 Leben, +2 Angriff)");
    held.ZeigeStatus();

    runde = runde + 1;
}

Console.WriteLine("");
Console.WriteLine("Der Endboss erscheint!");
Boss boss = new Boss("Drache", 160, 14);

bool sieg = Kaempfen(held, boss);
if (sieg)
{
    Console.WriteLine("");
    Console.WriteLine(held.Name + " hat " + boss.Name + " besiegt! Spiel gewonnen!");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Spiel vorbei.");
}


bool Kaempfen(Charakter spieler, Charakter feind)
{
    while (spieler.LebtNoch() && feind.LebtNoch())
    {
        Console.Write("Angriff (1 = normal, 2 = spezial): ");
        string? antwort = Console.ReadLine();

        int schaden;
        if (antwort == "2")
        {
            schaden = spieler.SpezialAngriff();
        }
        else
        {
            schaden = spieler.NormalerAngriff();
        }

        feind.ErleideSchaden(schaden);

        if (feind.LebtNoch() == false)
        {
            Console.WriteLine(feind.Name + " wurde besiegt!");
            return true;
        }

        int feindWuerfel = zufall.Next(0, 100);
        int feindSchaden;
        if (feindWuerfel < 35)
        {
            feindSchaden = feind.SpezialAngriff();
        }
        else
        {
            feindSchaden = feind.NormalerAngriff();
        }

        spieler.ErleideSchaden(feindSchaden);

        Console.WriteLine("");
        spieler.ZeigeStatus();
        feind.ZeigeStatus();
        Console.WriteLine("");

        if (spieler.LebtNoch() == false)
        {
            Console.WriteLine(spieler.Name + " wurde besiegt...");
            return false;
        }
    }

    return spieler.LebtNoch();
}
