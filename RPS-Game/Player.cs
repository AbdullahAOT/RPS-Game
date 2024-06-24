using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class Player
    {
        private string name;
        private int score;
        public Player(string name)
        {
            this.name = name;
            score = 0;
        }
        public string chooseMove()
        {
            Console.WriteLine("Make your move: ");
            string move=Console.ReadLine();
            while (move.ToLower() != "rock" && move.ToLower() != "paper" && move.ToLower() != "scissors")
            {
                Console.WriteLine("You didn't make a valid move, please enter a valid move: ");
                move = Console.ReadLine();
            }
            return move.ToLower();
        }
        public void setPlayerScore(int score)
        {
            this.score = score;
        }
        public int getPlayerScore()
        {
            return this.score;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
