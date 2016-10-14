using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Character
    {
        public int rank { get; }
        public bool isBomb { get; }
        public bool isFlag { get; }
        public String name { get; }
        public int x { set; get;}
        public int y { set; get; }

        public Character(int rank, bool isBomb, bool isFlag)
        {
            this.rank = rank;
            this.isBomb = isBomb;
            this.isFlag = isFlag;            
            switch (rank)
            {
                case 1: name = "Spy";break;
                case 2: name = "Scout";break;
                case 3: name = "Miner";break;
                case 4: name = "Sergeant";break;
                case 5: name = "Lieutenant";break;
                case 6: name = "Captain";break;
                case 7: name = "Major";break;
                case 8: name = "Colonel";break;
                case 9: name = "General";break;
                case 10: name = "Marshal";break;
                default: Console.WriteLine("not a valid rank");break;
            }
            if (isBomb)
                name = "Bomb";
            if (isFlag)
                name = "Flag";
        }


    }
}
