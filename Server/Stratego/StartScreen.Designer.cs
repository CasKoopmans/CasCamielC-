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
            this.password1Textbox.Size = new System.Drawing.Size(286, 39);
            this.password1Textbox.TabIndex = 12;
            this.password1Textbox.Visible = false;
            // 
            // password2Textbox
            // 
            this.password2Textbox.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Textbox.Location = new System.Drawing.Point(261, 155);
            this.password2Textbox.Name = "password2Textbox";
            this.password2Textbox.Size = new System.Drawing.Size(286, 39);
            this.password2Textbox.TabIndex = 13;
            this.password2Textbox.Visible = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Stratego.Properties.Resources.startscreenlogo;
            this.ClientSize = new System.Drawing.Size(597, 393);
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
            this.Name = "StartScreen";
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
    }
}

