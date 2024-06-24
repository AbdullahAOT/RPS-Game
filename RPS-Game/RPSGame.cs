using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class RPSGame
    {
        private int AIScore;
        private string AIMove;
        private int roundNumber;
        public RPSGame()
        {
            AIScore = 0;
            AIMove = AIMoveGenerator();
            roundNumber = 1;
        }
        public string AIMoveGenerator()
        { 
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            if (randomNumber == 1)
            {
                return "rock";
            }
            else if(randomNumber == 2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }
        }
        public void startGame(Player player)
        {
            Console.WriteLine("Welcome to round " + roundNumber);
            if (roundNumber > 1)
            {
                AIMove = AIMoveGenerator();
            }
            string playerMove = player.chooseMove();
            int resultofCompare = compareMoves(playerMove, AIMove, player);
            Console.WriteLine($"You have chosen {playerMove}, and AI have chosen {this.AIMove}");
            if (resultofCompare == 0)
            {
                Console.WriteLine("It's a tie");
            }
            else if (resultofCompare == 1)
            {
                Console.WriteLine(player.getName() + " wins this round");
            }
            else
            {
                Console.WriteLine("AI wins this round");
            }
            Console.WriteLine($"your score: {player.getPlayerScore()}    AI score: {AIScore}");
        }
        public int compareMoves(string playerMove, string AIMove, Player player)
        {
            int result = 0;
            if (playerMove == AIMove)
            {
                player.setPlayerScore(player.getPlayerScore() + 1);
                AIScore++;
                return result;
            }
            if ((playerMove == "rock" && AIMove == "scissors") ||
                (playerMove == "scissors" && AIMove == "paper") ||
                (playerMove == "paper" && AIMove == "rock"))
            {
                player.setPlayerScore(player.getPlayerScore() + 1);
                result = 1;
            }
            else
            {
                AIScore++;
                result = 2;
            }
            roundNumber++;
            return result;
        }
        public void compareScores(int playerScore, int AIScore)
        {
            if(playerScore > AIScore)
            {
                Console.WriteLine("You won against the AI !");
            }
            else if(playerScore < AIScore)
            {
                Console.WriteLine("AI won against you !");
            }
            else
            {
                Console.WriteLine("You and the AI got the same score, it's a draw !");
            }
        }
        public int getAIScore()
        {
            return this.AIScore;
        }
    }
}
