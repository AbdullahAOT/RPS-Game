using Xunit;
using System.Runtime.CompilerServices;
using RPS_Game;
using System.Xml.Linq;
using System.Text;
namespace RPS_GameTest
{
    public class UnitTest1
    {
        [Fact]
        public void DetermineWinnerTest()
        {
            Player player = new Player("Abdulrahman");
            RPSGame game = new RPSGame();
            int result = game.compareMoves("rock", "scissors", player);
            Assert.Equal(1, result);
        }
        [Fact]
        public void ScoreCheckTest()
        {
            Player player = new Player("Kareem");
            RPSGame game = new RPSGame();
            int result = game.compareMoves("rock", "scissors", player);
            Assert.Equal(1, player.getPlayerScore());
            Assert.Equal(0, game.getAIScore());
        }
    }
}