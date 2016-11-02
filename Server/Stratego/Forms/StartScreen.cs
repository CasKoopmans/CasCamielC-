using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratego
{
    public partial class StartScreen : Form
    {
        private SelectForm selectForm;

        public StartScreen(SelectForm selectForm)
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
            backButon.Visible = false;
            confirmButton.Visible = false;
            usernameTextbox.Visible = false;
            password1Textbox.Visible = false;
            password2Textbox.Visible = false;
            usernameTextbox.Text = "";
            password1Textbox.Text = "";
            password2Textbox.Text = "";
            loginButton.Visible = false;
            Register.Visible = true;
            Login.Visible = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreen;
            Login.Visible = false;
            Register.Visible = false;
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
            label7.Visible = true;
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
    }
}
