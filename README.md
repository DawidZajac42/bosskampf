# BossKampf

Text-Konsolenspiel in C#. Held waehlen, 3 zufaellige Gegner besiegen, dann
Endboss. Uebung zu Vererbung, weil Krieger, Magier, Schurke, Gegner und Boss
alle von der gleichen Basisklasse Charakter erben.

## Starten

Braucht .NET 8 SDK.

```
cd BossKampf
dotnet run
```

## Struktur

- Charaktere/Charakter.cs - Basisklasse
- Charaktere/Krieger.cs, Magier.cs, Schurke.cs, Gegner.cs, Boss.cs - erben davon
- Program.cs - Spiellogik
