using Stratego.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratego
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            FormClosing += formClosing;
            InitializeComponent();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Wil je afsluiten?", "Afsluiten", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Application.Exit();
                else
                    e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void startScreenButton_Click(object sender, EventArgs e)
        {
            StartScreen startscreen = new StartScreen(this);
            startscreen.Visible = true;
            Visible = false;
        }

        private void gameScreenButton_Click(object sender, EventArgs e)
        {
            GameScreen gamescreen = new GameScreen(this);
            gamescreen.Visible = true;
            Visible = false;
        }
    }
}
