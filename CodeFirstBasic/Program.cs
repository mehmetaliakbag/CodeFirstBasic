using CodeFirstBasic.Data;

using (var db = new PatikaFirstDbContext())
{
    Console.WriteLine("### MOVIES ###");
    foreach(var movie in db.Movies)
    {
        Console.WriteLine($"  - {movie.Title} {movie.Genre} {movie.ReleaseYear}");
    }

    Console.WriteLine();
    Console.WriteLine("### Games ###");

    foreach (var game in db.Games)
    {
        Console.WriteLine($"  - {game.Name} {game.Platform} {game.Rating}");
    }
}

Console.ReadKey();