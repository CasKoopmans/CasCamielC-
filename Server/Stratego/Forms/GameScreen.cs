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
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
