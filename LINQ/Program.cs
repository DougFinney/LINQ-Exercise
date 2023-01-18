namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order My Board Games:");
            var boardGamesList = new List<string>()
            {
                "Monopoly",
                "Checkers",
                "Candy Land",
                "Clue",
                "Life"
            };

            //var gamesListOrdered = boardGamesList.OrderBy(name => name.Length);

            //foreach (var game in gamesListOrdered)
            //{
            //    Console.WriteLine(game);
            //}
            boardGamesList
                    .OrderBy(name => name.Length)
                    .ToList()
                    .ForEach(Console.WriteLine);
        }
    }
}
