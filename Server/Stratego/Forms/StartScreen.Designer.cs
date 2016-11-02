namespace Stratego
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.backButon = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.password1Textbox = new System.Windows.Forms.TextBox();
            this.password2Textbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.noCharacterLabel = new System.Windows.Forms.Label();
            this.noCharacterLabel2 = new System.Windows.Forms.Label();
            this.noCharacterLabel3 = new System.Windows.Forms.Label();
            this.ChangeIP = new System.Windows.Forms.Button();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.confirmIP = new System.Windows.Forms.Button();
            this.invalidIPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-enter password:";
            this.label3.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Silver;
            this.loginButton.Location = new System.Drawing.Point(460, 321);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(125, 60);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // backButon
            // 
            this.backButon.BackColor = System.Drawing.Color.Transparent;
            this.backButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButon.BackgroundImage")));
            this.backButon.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButon.ForeColor = System.Drawing.Color.Silver;
            this.backButon.Location = new System.Drawing.Point(12, 321);
            this.backButon.Name = "backButon";
            this.backButon.Size = new System.Drawing.Size(125, 60);
            this.backButon.TabIndex = 7;
            this.backButon.Text = "Back";
            this.backButon.UseVisualStyleBackColor = false;
            this.backButon.Visible = false;
            this.backButon.Click += new System.EventHandler(this.backButon_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Silver;
            this.Login.Location = new System.Drawing.Point(12, 321);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(125, 60);
            this.Login.TabIndex = 8;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Register.BackgroundImage")));
            this.Register.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.Silver;
            this.Register.Location = new System.Drawing.Point(143, 321);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(125, 60);
            this.Register.TabIndex = 9;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmButton.BackgroundImage")));
            this.confirmButton.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.Silver;
            this.confirmButton.Location = new System.Drawing.Point(460, 321);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(125, 60);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextbox.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(261, 58);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(286, 39);
            this.usernameTextbox.TabIndex = 11;
            this.usernameTextbox.Visible = false;
            // 
            // password1Textbox
            // 
            this.password1Textbox.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1Textbox.Location = new System.Drawing.Point(261, 108);
            this.password1Textbox.Name = "password1Textbox";
            this.password1Textbox.PasswordChar = '•';
            this.password1Textbox.Size = new System.Drawing.Size(286, 39);
            this.password1Textbox.TabIndex = 12;
            this.password1Textbox.Visible = false;
            // 
            // password2Textbox
            // 
            this.password2Textbox.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Textbox.Location = new System.Drawing.Point(261, 155);
            this.password2Textbox.Name = "password2Textbox";
            this.password2Textbox.PasswordChar = '•';
            this.password2Textbox.Size = new System.Drawing.Size(286, 39);
            this.password2Textbox.TabIndex = 13;
            this.password2Textbox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(256, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Passwords are not the same";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(256, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "You need to fill in a password";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(257, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "You need to fill in a username";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(257, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Invalid password or username";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(257, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "You need to fill in a username";
            this.label8.Visible = false;
            // 
            // noCharacterLabel
            // 
            this.noCharacterLabel.AutoSize = true;
            this.noCharacterLabel.BackColor = System.Drawing.Color.Transparent;
            this.noCharacterLabel.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCharacterLabel.ForeColor = System.Drawing.Color.Red;
            this.noCharacterLabel.Location = new System.Drawing.Point(261, 206);
            this.noCharacterLabel.Name = "noCharacterLabel";
            this.noCharacterLabel.Size = new System.Drawing.Size(233, 27);
            this.noCharacterLabel.TabIndex = 19;
            this.noCharacterLabel.Text = "You used invalid characters";
            this.noCharacterLabel.Visible = false;
            // 
            // noCharacterLabel2
            // 
            this.noCharacterLabel2.AutoSize = true;
            this.noCharacterLabel2.BackColor = System.Drawing.Color.Transparent;
            this.noCharacterLabel2.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCharacterLabel2.ForeColor = System.Drawing.Color.Red;
            this.noCharacterLabel2.Location = new System.Drawing.Point(261, 233);
            this.noCharacterLabel2.Name = "noCharacterLabel2";
            this.noCharacterLabel2.Size = new System.Drawing.Size(154, 27);
            this.noCharacterLabel2.TabIndex = 20;
            this.noCharacterLabel2.Text = "You may not use:";
            this.noCharacterLabel2.Visible = false;
            // 
            // noCharacterLabel3
            // 
            this.noCharacterLabel3.AutoSize = true;
            this.noCharacterLabel3.BackColor = System.Drawing.Color.Transparent;
            this.noCharacterLabel3.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCharacterLabel3.ForeColor = System.Drawing.Color.Red;
            this.noCharacterLabel3.Location = new System.Drawing.Point(261, 260);
            this.noCharacterLabel3.Name = "noCharacterLabel3";
            this.noCharacterLabel3.Size = new System.Drawing.Size(77, 27);
            this.noCharacterLabel3.TabIndex = 21;
            this.noCharacterLabel3.Text = "; / \\ - _";
            this.noCharacterLabel3.Visible = false;
            // 
            // ChangeIP
            // 
            this.ChangeIP.BackColor = System.Drawing.Color.Transparent;
            this.ChangeIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeIP.BackgroundImage")));
            this.ChangeIP.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeIP.ForeColor = System.Drawing.Color.Silver;
            this.ChangeIP.Location = new System.Drawing.Point(274, 321);
            this.ChangeIP.Name = "ChangeIP";
            this.ChangeIP.Size = new System.Drawing.Size(125, 60);
            this.ChangeIP.TabIndex = 22;
            this.ChangeIP.Text = "Change IP";
            this.ChangeIP.UseVisualStyleBackColor = true;
            this.ChangeIP.Click += new System.EventHandler(this.ChangeIP_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipLabel.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(12, 59);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(203, 38);
            this.ipLabel.TabIndex = 23;
            this.ipLabel.Text = "New IP-Addres:";
            this.ipLabel.Visible = false;
            // 
            // ipTextbox
            // 
            this.ipTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.ipTextbox.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextbox.Location = new System.Drawing.Point(261, 58);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(286, 39);
            this.ipTextbox.TabIndex = 24;
            this.ipTextbox.Visible = false;
            // 
            // confirmIP
            // 
            this.confirmIP.BackColor = System.Drawing.Color.Transparent;
            this.confirmIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmIP.BackgroundImage")));
            this.confirmIP.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmIP.ForeColor = System.Drawing.Color.Silver;
            this.confirmIP.Location = new System.Drawing.Point(460, 321);
            this.confirmIP.Name = "confirmIP";
            this.confirmIP.Size = new System.Drawing.Size(125, 60);
            this.confirmIP.TabIndex = 25;
            this.confirmIP.Text = "Confirm";
            this.confirmIP.UseVisualStyleBackColor = true;
            this.confirmIP.Visible = false;
            this.confirmIP.Click += new System.EventHandler(this.confirmIP_Click);
            // 
            // invalidIPLabel
            // 
            this.invalidIPLabel.AutoSize = true;
            this.invalidIPLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidIPLabel.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidIPLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidIPLabel.Location = new System.Drawing.Point(261, 100);
            this.invalidIPLabel.Name = "invalidIPLabel";
            this.invalidIPLabel.Size = new System.Drawing.Size(154, 27);
            this.invalidIPLabel.TabIndex = 26;
            this.invalidIPLabel.Text = "Invalid IP-Addres";
            this.invalidIPLabel.Visible = false;
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreenlogo;
            this.ClientSize = new System.Drawing.Size(597, 393);
            this.Controls.Add(this.invalidIPLabel);
            this.Controls.Add(this.confirmIP);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ChangeIP);
            this.Controls.Add(this.noCharacterLabel3);
            this.Controls.Add(this.noCharacterLabel2);
            this.Controls.Add(this.noCharacterLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password2Textbox);
            this.Controls.Add(this.password1Textbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.backButon);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stratego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button backButon;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox password1Textbox;
        private System.Windows.Forms.TextBox password2Textbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label noCharacterLabel;
        private System.Windows.Forms.Label noCharacterLabel2;
        private System.Windows.Forms.Label noCharacterLabel3;
        private System.Windows.Forms.Button ChangeIP;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Button confirmIP;
        private System.Windows.Forms.Label invalidIPLabel;
    }
}

