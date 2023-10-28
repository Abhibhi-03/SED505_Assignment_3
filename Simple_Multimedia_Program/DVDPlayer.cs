class DVDPlayer
{
    public void TurnOn()
    {
        Console.WriteLine("DVD player is on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("DVD player is off.");
    }

    public void Play(string movie)
    {
        Console.WriteLine("Playing movie: " + movie);
    }
}
