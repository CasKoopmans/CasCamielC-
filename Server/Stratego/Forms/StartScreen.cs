using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using Stratego.Forms;

namespace Stratego
{
    public partial class StartScreen : Form
    {
        private IPAddress ipAddres = IPAddress.Parse("127.0.0.1");

        public StartScreen()
        {
            FormClosing += formClosing;
            InitializeComponent(); 
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreenlogo;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            noCharacterLabel.Visible = false;
            noCharacterLabel2.Visible = false;
            noCharacterLabel3.Visible = false;
            ipLabel.Visible = false;
            backButon.Visible = false;
            confirmButton.Visible = false;
            confirmIP.Visible = false;
            usernameTextbox.Visible = false;
            password1Textbox.Visible = false;
            password2Textbox.Visible = false;
            usernameTextbox.Text = "";
            password1Textbox.Text = "";
            password2Textbox.Text = "";
            ipTextbox.Text = "";
            loginButton.Visible = false;
            Register.Visible = true;
            Login.Visible = true;
            ChangeIP.Visible = true;
            ipTextbox.Visible = false;
            invalidIPLabel.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreen;
            Login.Visible = false;
            Register.Visible = false;
            ChangeIP.Visible = false;
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
            ChangeIP.Visible = false;
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
            label8.Visible = false;
            label7.Visible = false;
            if(usernameTextbox.Text == "")
            {
                label8.Visible = true;
                return;
            }
            ServerConnection serverConnection = new ServerConnection(ipAddres);
            if(!serverConnection.login(usernameTextbox.Text, password1Textbox.Text))
            {
                label7.Visible = true;
            }
            else
            {
                GameScreen gamescreen = new GameScreen();
                gamescreen.Visible = true;
                Visible = false; 
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            noCharacterLabel.Visible = false;
            noCharacterLabel2.Visible = false;
            noCharacterLabel3.Visible = false;
            if (usernameTextbox.Text == "")
            {
                label6.Visible = true;
                return;
            }
            if (password1Textbox.Text != password2Textbox.Text)
            {
                label4.Visible = true;
                return;
            }
            if (password1Textbox.Text == "" && password2Textbox.Text == "")
            {
                label5.Visible = true;
                return;
            }
            if (usernameTextbox.Text.Contains(';') || usernameTextbox.Text.Contains('/') || usernameTextbox.Text.Contains('\\') || usernameTextbox.Text.Contains('-') || usernameTextbox.Text.Contains('_'))
            {
                noCharacterLabel.Visible = true;
                noCharacterLabel2.Visible = true;
                noCharacterLabel3.Visible = true;
            }
            if (password1Textbox.Text.Contains(';') || password1Textbox.Text.Contains('/') || password1Textbox.Text.Contains('\\') || password1Textbox.Text.Contains('-') || password1Textbox.Text.Contains('_'))
            {
                noCharacterLabel.Visible = true;
                noCharacterLabel2.Visible = true;
                noCharacterLabel3.Visible = true;
            }
        }

        private void ChangeIP_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreen;
            Login.Visible = false;
            Register.Visible = false;
            ChangeIP.Visible = false;
            ipLabel.Visible = true;
            ipTextbox.Visible = true;
            confirmIP.Visible = true;
            backButon.Visible = true;
        }

        private void confirmIP_Click(object sender, EventArgs e)
        {
            invalidIPLabel.Visible = false;
            if (ipTextbox.Text.Contains('.') || ipTextbox.Text.Contains('0') || ipTextbox.Text.Contains('1') || ipTextbox.Text.Contains('2') || ipTextbox.Text.Contains('3') || ipTextbox.Text.Contains('4') || ipTextbox.Text.Contains('5') || ipTextbox.Text.Contains('6') || ipTextbox.Text.Contains('7') || ipTextbox.Text.Contains('8') || ipTextbox.Text.Contains('9'))
            {
                ipAddres = IPAddress.Parse(ipTextbox.Text);
                backButon_Click(sender, e);
            }
            else
            {
                invalidIPLabel.Visible = true;
            }
        }
    }
}
