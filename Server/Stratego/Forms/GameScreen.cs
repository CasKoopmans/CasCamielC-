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

        public GameScreen(string opponent)
        {
            this.opponent = opponent;
            FormClosing += formClosing;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            GameScreen_ClearField();
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
    }
}
