using Gamestore.Client.Models;

namespace Gamestore.Client;

public static class GameClient 
{
    private static readonly List<Game> games = new() {
        new Game() {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateTime(1991, 2, 1)
        },
        new Game() {
            Id = 2,
            Name = "War Fighter III",
            Genre = "Strategy",
            Price = 21.99M,
            ReleaseDate = new DateTime(1995, 3, 5)
        },
        new Game() {
            Id = 3,
            Name = "Street Fighter IV",
            Genre = "Sport",
            Price = 30.99M,
            ReleaseDate = new DateTime(2001, 2, 1)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = (games.Max(game => game.Id)) + 1;
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        var game = new Game();

        if (id > 0)
        {
            game = games.FirstOrDefault(game => game.Id == id);
        }

        return game ?? throw new Exception("Game wasn't found");
    }

    public static void  UpdateGame(Game game)
    {
        if (game is not null)
        {
            var gameFound = GetGame(game.Id);
            
            gameFound.Name = game.Name;
            gameFound.Price = game.Price;
            gameFound.Genre = game.Genre;
            gameFound.ReleaseDate = game.ReleaseDate;
            
        }
    }

    public static void DeleteGame(int id)
    {
        var game = GetGame(id);

        if (game is not null)
        {
            games.Remove(game);
        }
    }
}