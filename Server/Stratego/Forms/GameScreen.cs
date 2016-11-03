using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratego.Forms
{
    public partial class GameScreen : Form
    {
        private string opponent;
        private int tempRank;
        private bool isRed, isFlag, isBomb, gameStarted = false;
        private List<Character> characters = new List<Character>();

        public GameScreen(string opponent)
        {
            this.opponent = opponent;
            FormClosing += formClosing;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            GameScreen_ClearField();
            isRed = StartScreen.ServerConnection.isRed;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            StartScreen.ServerConnection.disconnect();
            Application.Exit();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void GameScreen_ClearField()
        {
            for(int i = 0; i<10; i++)
            {
                for(int j=0; j < 10; j++)
                {
                    string button = "x" + i + "y" + j;
                    if (button != "x2y4" && button != "x2y5" && button != "x3y4" && button != "x3y5" && button != "x6y4" && button != "x6y5" && button != "x7y4" && button != "x7y5")
                    {
                        this.Controls[button].Text = "";
                        this.Controls[button].BackgroundImage = null;
                    }
                }
            }
        }

        #region CharacterButtons
        private void flag_Click(object sender, EventArgs e) 
        {
            flag.Visible = false;
            tempRank = 0;
            isFlag = true;
            isBomb = false;
        }

        private void bomb1_Click(object sender, EventArgs e)
        {

        }

        private void bomb2_Click(object sender, EventArgs e)
        {

        }

        private void bomb3_Click(object sender, EventArgs e)
        {

        }

        private void bomb4_Click(object sender, EventArgs e)
        {

        }

        private void bomb5_Click(object sender, EventArgs e)
        {

        }

        private void bomb6_Click(object sender, EventArgs e)
        {

        }

        private void spy_Click(object sender, EventArgs e)
        {

        }

        private void scout1_Click(object sender, EventArgs e)
        {

        }

        private void scout2_Click(object sender, EventArgs e)
        {

        }

        private void scout3_Click(object sender, EventArgs e)
        {

        }

        private void scout4_Click(object sender, EventArgs e)
        {

        }

        private void scout5_Click(object sender, EventArgs e)
        {

        }

        private void scout6_Click(object sender, EventArgs e)
        {

        }

        private void scout7_Click(object sender, EventArgs e)
        {

        }

        private void scout8_Click(object sender, EventArgs e)
        {

        }

        private void miner1_Click(object sender, EventArgs e)
        {

        }

        private void miner2_Click(object sender, EventArgs e)
        {

        }

        private void miner3_Click(object sender, EventArgs e)
        {

        }

        private void miner4_Click(object sender, EventArgs e)
        {

        }

        private void miner5_Click(object sender, EventArgs e)
        {

        }

        private void sergeant1_Click(object sender, EventArgs e)
        {

        }

        private void sergeant2_Click(object sender, EventArgs e)
        {

        }

        private void sergeant3_Click(object sender, EventArgs e)
        {

        }

        private void sergeant4_Click(object sender, EventArgs e)
        {

        }

        private void lieutenant1_Click(object sender, EventArgs e)
        {

        }

        private void lieutenant2_Click(object sender, EventArgs e)
        {

        }

        private void lieutenant3_Click(object sender, EventArgs e)
        {

        }

        private void lieutenant4_Click(object sender, EventArgs e)
        {

        }

        private void captain1_Click(object sender, EventArgs e)
        {

        }

        private void captain2_Click(object sender, EventArgs e)
        {

        }

        private void captain3_Click(object sender, EventArgs e)
        {

        }

        private void captain4_Click(object sender, EventArgs e)
        {

        }

        private void major1_Click(object sender, EventArgs e)
        {

        }

        private void major2_Click(object sender, EventArgs e)
        {

        }

        private void major3_Click(object sender, EventArgs e)
        {

        }

        private void colonel1_Click(object sender, EventArgs e)
        {

        }

        private void colonel2_Click(object sender, EventArgs e)
        {

        }

        private void general_Click(object sender, EventArgs e)
        {

        }

        private void marshall_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttons
        private void x0y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x0y0");
        }

        private void x1y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x1y0");
        }

        private void x2y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x2y0");
        }

        private void x3y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x3y0");
        }

        private void x4y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x4y0");
        }

        private void x5y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x5y0");
        }

        private void x6y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x6y0");
        }

        private void x7y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x7y0");
        }

        private void x8y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x8y0");
        }

        private void x9y0_Click(object sender, EventArgs e)
        {
            topHalfClick("x9y0");
        }

        private void x0y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x0y1");
        }

        private void x1y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x1y1");
        }

        private void x2y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x2y1");
        }

        private void x3y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x3y1");
        }

        private void x4y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x4y1");
        }

        private void x5y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x5y1");
        }

        private void x6y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x6y1");
        }

        private void x7y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x7y1");
        }

        private void x8y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x8y1");
        }

        private void x9y1_Click(object sender, EventArgs e)
        {
            topHalfClick("x9y1");
        }

        private void x0y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x0y2");
        }

        private void x1y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x1y2");
        }

        private void x2y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x2y2");
        }

        private void x3y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x3y2");
        }

        private void x4y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x4y2");
        }

        private void x5y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x5y2");
        }

        private void x6y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x6y2");
        }

        private void x7y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x7y2");
        }

        private void x8y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x8y2");
        }

        private void x9y2_Click(object sender, EventArgs e)
        {
            topHalfClick("x9y2");
        }

        private void x0y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x0y3");
        }

        private void x1y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x1y3");
        }

        private void x2y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x2y3");
        }

        private void x3y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x3y3");
        }

        private void x4y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x4y3");
        }

        private void x5y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x5y3");
        }

        private void x6y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x6y3");
        }

        private void x7y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x7y3");
        }

        private void x8y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x8y3");
        }

        private void x9y3_Click(object sender, EventArgs e)
        {
            topHalfClick("x9y3");
        }

        private void x0y4_Click(object sender, EventArgs e)
        {
            topHalfClick("x0y4");
        }

        private void x1y4_Click(object sender, EventArgs e)
        {
            topHalfClick("x1y4");
        }

        private void x4y4_Click(object sender, EventArgs e)
        {
            topHalfClick("x4y4");
        }

        private void x5y4_Click(object sender, EventArgs e)
        {
            topHalfClick("x5y4");
        }

        private void x8y4_Click(object sender, EventArgs e)
        {
            topHalfClick("x8y4");
        }

        private void x9y4_Click(object sender, EventArgs e)
        {
            topHalfClick("x9y4");
        }

        private void x0y5_Click(object sender, EventArgs e)
        {
            downHalfClick("x0y5");
        }

        private void x1y5_Click(object sender, EventArgs e)
        {
            downHalfClick("x1y5");
        }

        private void x4y5_Click(object sender, EventArgs e)
        {
            downHalfClick("x4y5");
        }

        private void x5y5_Click(object sender, EventArgs e)
        {
            downHalfClick("x5y5");
        }

        private void x8y5_Click(object sender, EventArgs e)
        {
            downHalfClick("x8y5");
        }

        private void x9y5_Click(object sender, EventArgs e)
        {
            downHalfClick("x9y5");
        }

        private void x0y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x0y6");
        }

        private void x1y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x1y6");
        }

        private void x2y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x2y6");
        }

        private void x3y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x3y6");
        }

        private void x4y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x4y6");
        }

        private void x5y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x5y6");
        }

        private void x6y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x6y6");
        }

        private void x7y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x7y6");
        }

        private void x8y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x8y6");
        }

        private void x9y6_Click(object sender, EventArgs e)
        {
            downHalfClick("x9y6");
        }

        private void x0y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x0y7");
        }

        private void x1y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x1y7");
        }

        private void x2y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x2y7");
        }

        private void x3y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x3y7");
        }

        private void x4y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x4y7");
        }

        private void x5y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x5y7");
        }

        private void x6y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x6y7");
        }

        private void x7y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x7y7");
        }

        private void x8y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x8y7");
        }

        private void x9y7_Click(object sender, EventArgs e)
        {
            downHalfClick("x9y7");
        }

        private void x0y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x0y8");
        }

        private void x1y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x1y8");
        }

        private void x2y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x2y8");
        }

        private void x3y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x3y8");
        }

        private void x4y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x4y8");
        }

        private void x5y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x5y8");
        }

        private void x6y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x6y8");
        }

        private void x7y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x7y8");
        }

        private void x8y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x8y8");
        }

        private void x9y8_Click(object sender, EventArgs e)
        {
            downHalfClick("x9y8");
        }

        private void x0y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x0y9");
        }

        private void x1y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x1y9");
        }

        private void x2y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x2y9");
        }

        private void x3y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x3y9");
        }

        private void x4y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x4y9");
        }

        private void x5y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x5y9");
        }

        private void x6y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x6y9");
        }

        private void x7y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x7y9");
        }

        private void x8y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x8y9");
        } 

        private void x9y9_Click(object sender, EventArgs e)
        {
            downHalfClick("x9y9");
        }

        private void ConfirmSetup_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void topHalfClick(string position)
        {
            if (!isRed && !gameStarted)
            {
                characters.Add(new Character(tempRank, isBomb, isFlag, isRed, position));
            }
        }

        private void downHalfClick(string position)
        {
            if (isRed && !gameStarted)
            {
                characters.Add(new Character(tempRank, isBomb, isFlag, isRed,position));
            }
        }
    }
}