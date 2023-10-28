using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a facade for the multimedia system
        MultimediaFacade multimediaFacade = new MultimediaFacade();

        // Watch a movie using the facade
        multimediaFacade.WatchMovie("Inception");

        // End the movie using the facade
        multimediaFacade.EndMovie();

        Console.ReadKey();
    }
}
