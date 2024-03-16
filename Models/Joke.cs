namespace JokesApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public required string JokeQuestion { get; set; }
        public required string JokeAnswer { get; set; }
    }
}
