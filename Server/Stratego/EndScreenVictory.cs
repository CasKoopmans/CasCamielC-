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
    public partial class EndScreenVictory : Form
    {
        public EndScreenVictory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartScreen.ServerConnection.disconnect();
            Environment.Exit(1);
            Application.Exit();
        }
    }
}
