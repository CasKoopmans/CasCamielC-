using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    public class Character
    {
        public int rank { get; }
        public bool isBomb { get; }
        public bool isFlag { get; }
        public string name { get; }
        public int x { set; get; }
        public int y { set; get; }
        public bool isRed;
        public string position;

        public Character(int rank, bool isBomb, bool isFlag, bool isRed, string position)
        {
            this.rank = rank;
            this.isBomb = isBomb;
            this.isFlag = isFlag;
            this.isRed = isRed;
            setPosistion(position);
            switch (rank)
            {
                case 1: name = "Spy"; break;
                case 2: name = "Scout"; break;
                case 3: name = "Miner"; break;
                case 4: name = "Sergeant"; break;
                case 5: name = "Lieutenant"; break;
                case 6: name = "Captain"; break;
                case 7: name = "Major"; break;
                case 8: name = "Colonel"; break;
                case 9: name = "General"; break;
                case 10: name = "Marshall"; break;
                default: Console.WriteLine("not a valid rank"); break;
            }
            if (isBomb)
                name = "Bomb";
            if (isFlag)
                name = "Flag";
        }
        public string getPosistionXY()
        {
            return "x" + x + "y" + y;
        }

        public int getPositionX()
        {
            char x = position[1];
            int xx = Int32.Parse(x.ToString());
            return xx;
        }

        public int getPositionY()
        {
            char y = position[3];
            int yy = Int32.Parse(y.ToString());
            return yy;
        }

        public string getPosistion()
        {
            return position;
        }

        public void setPosistion(string posistion)
        {
            position = posistion;
        }

    }
}
