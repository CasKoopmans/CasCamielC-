﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Character
    {
        public int rank { get; }
        public bool isBomb { get; }
        public bool isFlag { get; }
        public String name { get; }
        public int x { set; get; }
        public int y { set; get; }
        public bool isRed;

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
        public String getPosistion()
        {
            return "x" + x + "y" + y;
        }
        public void setPosistion(String posistion)
        {
            String X = posistion.Substring(2, 1);
            String Y = posistion.Substring(3, 1);
            x = Int32.Parse(X);
            y = Int32.Parse(Y);
        }

    }
}
