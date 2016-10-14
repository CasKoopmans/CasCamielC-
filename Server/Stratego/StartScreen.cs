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

        private void backButon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreenlogo;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            backButon.Visible = false;
            confirmButton.Visible = false;
            usernameTextbox.Visible = false;
            password1Textbox.Visible = false;
            password2Textbox.Visible = false;
            loginButton.Visible = false;
            Register.Visible = true;
            Login.Visible = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreen;
            label3.Visible = false;
            Login.Visible = false;
            Register.Visible = false;
            confirmButton.Visible = false;
            usernameTextbox.Visible = true;
            password1Textbox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            backButon.Visible = true;
            loginButton.Visible = true;

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreen;
            Login.Visible = false;
            Register.Visible = false;
            loginButton.Visible = false;
            usernameTextbox.Visible = true;
            password1Textbox.Visible = true;
            password2Textbox.Visible = true;
            confirmButton.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            backButon.Visible = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
