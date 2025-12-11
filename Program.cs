const string ResourcePath = "..\\..\\..\\data\\helsinki.txt";
const string OutputPath = "..\\..\\..\\data\\helsinki2.txt";

List<Pontszerzo> magyarok = [];

using StreamReader sr = new(ResourcePath);
while (!sr.EndOfStream) magyarok.Add(new(sr.ReadLine().Split(' ')));

Console.WriteLine($"pontszerzo helyezesek szama: {magyarok.Count} db");

Console.WriteLine("megszerzett ermek szama");
Console.WriteLine($"\tarany: {magyarok.Count(p => p.Helyezes == 1)} db");
Console.WriteLine($"\tezust: {magyarok.Count(p => p.Helyezes == 2)} db");
Console.WriteLine($"\tbronz: {magyarok.Count(p => p.Helyezes == 3)} db");

var opsum = magyarok.Sum(p => p.OlimpiaiPont);
Console.WriteLine($"megszerzett olimpiai pontok osszesen: {opsum} pont");

int uesz = magyarok.Count(p => p.Helyezes <= 3 && p.Sportag == "uszas");
int tesz = magyarok.Count(p => p.Helyezes <= 3 && p.Sportag == "torna");
if (uesz == tesz) Console.WriteLine("uszas es torna sportagakban egyenlo volt az ermek szama");
else Console.WriteLine($"{(uesz > tesz ? "uszas" : "torna")} sportagban szereztek tobb ermet");

using StreamWriter sw = new(OutputPath);
foreach (var m in magyarok)
{
    string san = m.Sportag.Contains("kajak") ? "kajak-kenu" : m.Sportag;
    sw.WriteLine($"{m.Helyezes} {m.SportolokSzama} {m.OlimpiaiPont} {san} {m.Versenyszam}");
}
Console.WriteLine($"helsinki2.txt kesz! ({OutputPath})");

var mssz = magyarok.MaxBy(p => p.SportolokSzama);
Console.WriteLine($"legtobb erintett sportolo: \n{mssz}");
