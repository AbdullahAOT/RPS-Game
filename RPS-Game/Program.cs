namespace RPS_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Player player = new Player(name);
            RPSGame game = new RPSGame();
            while(game.getAIScore() != 3 && player.getPlayerScore() != 3)
            {
                game.startGame(player);
            }
            game.compareScores(player.getPlayerScore(), game.getAIScore());
        }
    }
}
