class MultimediaFacade
{
    private DVDPlayer dvdPlayer;
    private Projector projector;
    private AudioSystem audioSystem;

    public MultimediaFacade()
    {
        dvdPlayer = new DVDPlayer();
        projector = new Projector();
        audioSystem = new AudioSystem();
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Starting to watch a movie: " + movie);
        dvdPlayer.TurnOn();
        projector.TurnOn();
        audioSystem.TurnOn();
        dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Ending the movie");
        dvdPlayer.TurnOff();
        projector.TurnOff();
        audioSystem.TurnOff();
    }
}
