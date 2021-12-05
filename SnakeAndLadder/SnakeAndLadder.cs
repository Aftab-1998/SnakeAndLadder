using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class SnakeAndLadder
    {
        private int playerPosition;
        private Random objRandom;
        private int DieRolled;
        public SnakeAndLadder()
        {
            objRandom = new Random();
        }

        public void StartGame()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position {0}", playerPosition);
            RollADie();
        }
        private void RollADie()
        {
            DieRolled = objRandom.Next(1, 7);
            playerPosition = playerPosition + DieRolled;
            int PlayerPosition = 0;
            Console.WriteLine("Player Position: {0}", PlayerPosition);

        }

        

    }
}
       