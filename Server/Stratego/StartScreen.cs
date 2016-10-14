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
    public partial class StartScreen : Form
    {
        enum state { start = 0, login = 1, register = 2 }
        private int currentState;
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
