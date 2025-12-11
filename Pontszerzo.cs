class Pontszerzo
{
    public int Helyezes { get; set; }
    public int SportolokSzama { get; set; }
    public string Sportag { get; set; }
    public string Versenyszam { get; set; }
    public int OlimpiaiPont => 
        Helyezes == 1 
        ? 7 
        : 7 - Helyezes;

    public override string ToString() =>
        $"\tHelyezés: {Helyezes}.\n" +
        $"\tSportág: {Sportag}\n" +
        $"\tVersenyszám: {Versenyszam}\n" +
        $"\tSportolók száma: {SportolokSzama} fő";

    public Pontszerzo(string[] splits)
    {
        Helyezes = int.Parse(splits[0]);
        SportolokSzama = int.Parse(splits[1]);
        Sportag = splits[2];
        Versenyszam = splits[3];
    }

}