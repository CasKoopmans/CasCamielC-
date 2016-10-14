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
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var StartScreen = new StartScreen();
            StartScreen.Closed += (s, args) => this.Close();
            StartScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GameScreen = new GameScreen();
            GameScreen.Closed += (s, args) => this.Close();
            GameScreen.Show();
        }
    }
}
