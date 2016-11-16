﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratego.Forms
{
    public partial class GameScreen : Form
    {
        private string opponent, positionSelected;
        private int tempRank, tempChar = -1;
        private bool isRed, isFlag, isBomb, gameStarted = false, selected = false, myTurn, available;
        private List<Character> characters = new List<Character>();
        Thread updateCharacters2;

        public GameScreen(string opponent)
        {
            this.opponent = opponent;
            FormClosing += formClosing;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            GameScreen_ClearField();
            isRed = StartScreen.ServerConnection.isRed;
            updateCharacters2 = new Thread(updateCharacters);

        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            StartScreen.ServerConnection.disconnect();
            Environment.Exit(1);
            Application.Exit();
        }

        private void updateCharacters()
        {
            bool myOldTurn = myTurn;
            while (true)
            {
                if (gameStarted)
                {
                    myTurn = StartScreen.ServerConnection.yourTurn;
                    if (myOldTurn != myTurn)
                    {
                        if (myTurn == false)
                        {

                        }
                        else
                        {
                            characters = StartScreen.ServerConnection.characters;
                        }
                        GameScreen_Load();
                        myOldTurn = myTurn;
                        bool alive = false;
                        foreach (Character c in characters)
                        {
                            if (c.isFlag == true && c.isRed==isRed)
                            {
                                alive = true;
                            }
                        }
                        if (alive == false)
                        {
                            EndScreen end = new EndScreen();
                            end.Visible = true;
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        private void GameScreen_Load()
        {
            GameScreen_ClearField();

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].isRed != isRed)
                {
                    paint(characters[i].getPosistion());
                }
                else
                {
                    setImage(characters[i].rank, characters[i].getPosistion());
                }
            }
        }

        private void GameScreen_ClearField()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string button = "x" + i + "y" + j;
                    if (button != "x2y4" && button != "x2y5" && button != "x3y4" && button != "x3y5" && button != "x6y4" && button != "x6y5" && button != "x7y4" && button != "x7y5")
                    {
                        this.Controls[button].Text = "";
                        this.Controls[button].BackgroundImage = null;
                        this.Controls[button].BackColor = Color.Gainsboro;
                    }
                }
            }
        }

        #region CharacterButtons
        private void flag_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                flag.Visible = false;
                tempRank = 0;
                isFlag = true;
                isBomb = false;
                selected = true;
            }
        }

        private void bomb1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                bomb1.Visible = false;
                tempRank = 11;
                isFlag = false;
                isBomb = true;
                selected = true;
            }
        }

        private void bomb2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                bomb2.Visible = false;
                tempRank = 11;
                isFlag = false;
                isBomb = true;
                selected = true;
            }
        }

        private void bomb3_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                bomb3.Visible = false;
                tempRank = 11;
                isFlag = false;
                isBomb = true;
                selected = true;
            }
        }

        private void bomb4_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                bomb4.Visible = false;
                tempRank = 11;
                isFlag = false;
                isBomb = true;
                selected = true;
            }
        }

        private void bomb5_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                bomb5.Visible = false;
                tempRank = 11;
                isFlag = false;
                isBomb = true;
                selected = true;
            }
        }

        private void bomb6_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                bomb6.Visible = false;
                tempRank = 11;
                isFlag = false;
                isBomb = true;
                selected = true;
            }
        }

        private void spy_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                spy.Visible = false;
                tempRank = 1;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout1.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout2.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout3_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout3.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout4_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout4.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout5_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout5.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout6_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout6.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout7_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout7.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void scout8_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                scout8.Visible = false;
                tempRank = 2;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void miner1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                miner1.Visible = false;
                tempRank = 3;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void miner2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                miner2.Visible = false;
                tempRank = 3;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void miner3_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                miner3.Visible = false;
                tempRank = 3;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void miner4_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                miner4.Visible = false;
                tempRank = 3;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void miner5_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                miner5.Visible = false;
                tempRank = 3;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void sergeant1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                sergeant1.Visible = false;
                tempRank = 4;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void sergeant2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                sergeant2.Visible = false;
                tempRank = 4;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void sergeant3_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                sergeant3.Visible = false;
                tempRank = 4;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void sergeant4_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                sergeant4.Visible = false;
                tempRank = 4;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void lieutenant1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                lieutenant1.Visible = false;
                tempRank = 5;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void lieutenant2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                lieutenant2.Visible = false;
                tempRank = 5;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void lieutenant3_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                lieutenant3.Visible = false;
                tempRank = 5;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void lieutenant4_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                lieutenant4.Visible = false;
                tempRank = 5;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void captain1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                captain1.Visible = false;
                tempRank = 6;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void captain2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                captain2.Visible = false;
                tempRank = 6;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void captain3_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                captain3.Visible = false;
                tempRank = 6;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void captain4_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                captain4.Visible = false;
                tempRank = 6;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void major1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                major1.Visible = false;
                tempRank = 7;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void major2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                major2.Visible = false;
                tempRank = 7;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void major3_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                major3.Visible = false;
                tempRank = 7;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void colonel1_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                colonel1.Visible = false;
                tempRank = 8;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void colonel2_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                colonel2.Visible = false;
                tempRank = 8;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void general_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                general.Visible = false;
                tempRank = 9;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }

        private void marshall_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                marshall.Visible = false;
                tempRank = 10;
                isFlag = false;
                isBomb = false;
                selected = true;
            }
        }
        #endregion

        private void ConfirmSetup_Click(object sender, EventArgs e)
        {
            if (characters.Count == 40)
            {
                StartScreen.ServerConnection.characters = characters;
            StartScreen.ServerConnection.turndone = true;
            ConfirmSetup.Visible = false;
            errorlabel.Visible = false;



            while (!StartScreen.ServerConnection.setup)
            {
                Thread.Sleep(100);
            }
            characters = StartScreen.ServerConnection.characters;
            myTurn = StartScreen.ServerConnection.yourTurn;
            updateCharacters2.Start();
            GameScreen_Load();
            gameStarted = true;
            }
            else
            errorlabel.Visible = true;
        }

        private void topHalf_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string position = button.Name;

            if (!isRed && !gameStarted && selected)
            {
                for (int i = 0; i < characters.Count; i++)
                {
                    if (characters[i].getPosistion() == position)
                        return;
                }

                if (position != "x0y4" && position != "x1y4" && position != "x4y4" && position != "x5y4" && position != "x8y4" && position != "x9y4")
                {
                    characters.Add(new Character(tempRank, isBomb, isFlag, isRed, position));
                    setImage(tempRank, position);
                    selected = false;
                }
            }

            if (gameStarted && myTurn)
            {
                if (tempChar != -1 && tempRank != 0 && tempRank != 11)
                {
                    available = true;
                    for (int i = 0; i < characters.Count; i++)
                    {
                        if (characters[i].getPosistion().Equals(position))
                        {
                            if (characters[i].isRed == isRed)
                            { available = false; }
                            if (characters[i].isRed != isRed)
                            {

                                char xx = position[1];
                                int xp = Int32.Parse(xx.ToString());
                                char yy = position[3];
                                int yp = Int32.Parse(xx.ToString());


                                if (xp + 1 == characters[tempChar].getPositionX()  && characters[tempChar].getPositionY() == yp)
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                                else if (xp - 1 == characters[tempChar].getPositionX() && characters[tempChar].getPositionY() == yp)
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                                else if (characters[tempChar].getPositionX() == xp && yp - 1 == characters[tempChar].getPositionY())
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                                else if (characters[tempChar].getPositionX() == xp && yp + 1 ==characters[tempChar].getPositionY())
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                            }
                        }

                    }
                    if (available)
                    {
                        char x = position[1];
                        int xp = Int32.Parse(x.ToString());

                        char y = position[3];
                        int yp = Int32.Parse(y.ToString());

                        char xx = positionSelected[1];
                        int xs = Int32.Parse(xx.ToString());
                        char yy = positionSelected[3];
                        int ys = Int32.Parse(yy.ToString());

                        if (xs == xp - 1 && ys == yp)
                        {
                            characters[tempChar].setPosistion(position); turnIsDone();
                        }
                        else if (xs == xp + 1 && ys == yp)
                        {
                            characters[tempChar].setPosistion(position); turnIsDone();
                        }
                        else if (xs == xp && ys == yp - 1)
                        {
                            characters[tempChar].setPosistion(position); turnIsDone();
                        }
                        else if (xs == xp && ys == yp + 1)
                        {
                            characters[tempChar].setPosistion(position); turnIsDone();
                        }
                    }
                    tempChar = -1;

                }
                else
                {
                    for (int i = 0; i < characters.Count; i++)
                    {
                        if (characters[i].isRed == isRed)
                        {
                            if (characters[i].getPosistion().Equals(position))
                            {

                                tempChar = i;
                                tempRank = characters[i].rank;
                                positionSelected = position;
                                selected = true;
                                break;
                            }
                        }
                    }
                }
            }

        }

        private void downHalf_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string position = button.Name;

            if (isRed && !gameStarted && selected)
            {
                for (int i = 0; i < characters.Count; i++)
                {
                    if (characters[i].getPosistion() == position)
                        return;
                }

                if (position != "x0y4" && position != "x1y4" && position != "x4y4" && position != "x5y4" && position != "x8y4" && position != "x9y4")
                {
                    characters.Add(new Character(tempRank, isBomb, isFlag, isRed, position));
                    setImage(tempRank, position);
                    selected = false;
                }
            }

            if (gameStarted && myTurn)
            {
                if (tempChar != -1 && tempRank != 0 && tempRank != 11)
                {
                    available = true;
                    for (int i = 0; i < characters.Count; i++)
                    {
                        if (characters[i].getPosistion().Equals(position))
                        {
                            if (characters[i].isRed == isRed)
                            { available = false; }
                            if (characters[i].isRed != isRed)
                            {

                                char xx = position[1];
                                int xp = Int32.Parse(xx.ToString());
                                char yy = position[3];
                                int yp = Int32.Parse(xx.ToString());


                                if (characters[tempChar].getPositionX() == xp - 1 && characters[tempChar].getPositionY() == yp)
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                                else if (characters[tempChar].getPositionX() == xp + 1 && characters[tempChar].getPositionY() == yp)
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                                else if (characters[tempChar].getPositionX() == xp && characters[tempChar].getPositionY() == yp - 1)
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                                else if (characters[tempChar].getPositionX() == xp && characters[tempChar].getPositionY() == yp + 1)
                                {
                                    fight(characters[tempChar], characters[i]); available = false; turnIsDone();
                                }
                                
                            }
                        }

                    }
                    if (available)
                    {
                        char x = position[1];
                        int xp = Int32.Parse(x.ToString());

                        char y = position[3];
                        int yp = Int32.Parse(y.ToString());

                        char xx = positionSelected[1];
                        int xs = Int32.Parse(xx.ToString());
                        char yy = positionSelected[3];
                        int ys = Int32.Parse(yy.ToString());

                        if (xs == xp - 1 && ys == yp)
                        {
                            characters[tempChar].setPosistion(position); turnIsDone();
                        }
                        else if (xs == xp + 1 && ys == yp)
                        {
                            characters[tempChar].setPosistion(position); turnIsDone();
                        }
                        else if (xs == xp && ys == yp - 1)
                        {
                            characters[tempChar].setPosistion(position); turnIsDone();
                        }
                        else if (xs == xp && ys == yp + 1)
                        {
                            characters[tempChar].setPosistion(position);turnIsDone();

                        }
                    }
                    tempChar = -1;

                }
                else
                {
                    for (int i = 0; i < characters.Count; i++)
                    {
                        if (characters[i].isRed == isRed)
                        {
                            if (characters[i].getPosistion().Equals(position))
                            {

                                tempChar = i;
                                tempRank = characters[i].rank;
                                positionSelected = position;
                                selected = true;
                                break;
                            }
                        }
                    }
                }
            }

        }

        private void setImage(int rank, string position)
        {
            switch (rank)
            {
                case 0: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.flag1; break;
                case 1: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.spy; break;
                case 2: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.scout; break;
                case 3: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.miner; break;
                case 4: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.sergeant; break;
                case 5: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.lieutenant; break;
                case 6: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.captain; break;
                case 7: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.major; break;
                case 8: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.colonel; break;
                case 9: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.general; break;
                case 10: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.marshall; break;
                case 11: this.Controls[position].BackgroundImage = global::Stratego.Properties.Resources.bomb; break;
            }
        }

        private void paint(string position)
        {
            this.Controls[position].BackColor = Color.Red;
        }

        public void fight(Character attacker, Character defender)
        {
            switch (attacker.name)
            {
                case "Spy":
                        if (defender.name == "Marshall")
                        {
                            attacker.setPosistion(defender.position);
                            characters.Remove(defender);
                            return;
                    }
                    break;
                case "Miner":
                        if (defender.name == "Bomb")
                        {
                            attacker.setPosistion(defender.position);
                            characters.Remove(defender);
                            return;
                        }
                    break;
                default:
                    break;
            }
            switch (defender.name)
            {
                case "Bomb":
                    characters.Remove(attacker);
                    break;
                case "Flag":
                    attacker.setPosistion(defender.position);
                    characters.Remove(defender);
                    EndScreenVictory endv = new EndScreenVictory();
                    endv.Visible = true;
                    break;
                default:
                    {
                        if (attacker.rank > defender.rank)
                        {
                            characters.Remove(defender);
                            attacker.setPosistion(defender.getPosistion());
                        }

                        else if (attacker.rank < defender.rank)
                        {
                            characters.Remove(attacker);
                        }

                        else if (attacker.rank == defender.rank)
                        {
                            characters.Remove(attacker);
                            characters.Remove(defender);
                        }
                    }
                    break;
            }
        }

        private void turnIsDone()
        {
            StartScreen.ServerConnection.characters = characters;
            StartScreen.ServerConnection.turndone = true;
        }
    }
}