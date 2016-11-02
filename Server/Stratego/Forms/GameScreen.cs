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
        private SelectForm selectForm;

        public GameScreen(SelectForm selectForm)
        {
            FormClosing += formClosing;
            InitializeComponent();
            this.selectForm = selectForm;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            selectForm.Visible = true;
            Dispose();
        }
    }
}
