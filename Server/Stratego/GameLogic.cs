using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class GameLogic
    {
        private Board board;
        public GameLogic(Board board)
        {
            this.board = board;
        }



        public void fight(Character attacker, Character defender)
        {

            switch (attacker.name)
            {
                case "Spy":
                    {
                        if (defender.name == "Marshall")
                        {
                            board.deleteEnemyCharacter(defender);
                            return;
                        }
                    }
                    break;
                case "Miner":
                    {
                        if (defender.name == "Bomb")
                        {
                            board.deleteEnemyCharacter(defender);
                            return;
                        }
                    }
                    break;
                default:
                    break;
            }
            switch (defender.name)
            {
                case "Bomb":
                    board.deleteCharacter(attacker);
                    break;
                case "Flag":
                    Console.WriteLine("YOU WIN");
                    break;
                default:
                    {
                        if (attacker.rank > defender.rank)
                            board.deleteEnemyCharacter(defender);

                        else if (attacker.rank < defender.rank)
                                board.deleteCharacter(attacker);

                        else if (attacker.rank == defender.rank)
                            {
                                board.deleteCharacter(attacker);
                                board.deleteEnemyCharacter(defender);
                            }
                    }
                    break;
            }
        }

        public bool checkAvailable(Character character, int targetX, int targetY)
        {
            int x = character.x;
            int y = character.y;

            foreach (Character other in board.getAllCharacters())
            {
                if (targetX == other.x && targetY == other.y)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
