namespace Stratego
{
    partial class SelectForm
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
            this.startScreenButton = new System.Windows.Forms.Button();
            this.gameScreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startScreenButton
            // 
            this.startScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startScreenButton.Location = new System.Drawing.Point(12, 12);
            this.startScreenButton.Name = "startScreenButton";
            this.startScreenButton.Size = new System.Drawing.Size(517, 101);
            this.startScreenButton.TabIndex = 0;
            this.startScreenButton.Text = "STARTSCREEN";
            this.startScreenButton.UseVisualStyleBackColor = true;
            this.startScreenButton.Click += new System.EventHandler(this.startScreenButton_Click);
            // 
            // gameScreenButton
            // 
            this.gameScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameScreenButton.Location = new System.Drawing.Point(12, 119);
            this.gameScreenButton.Name = "gameScreenButton";
            this.gameScreenButton.Size = new System.Drawing.Size(517, 101);
            this.gameScreenButton.TabIndex = 1;
            this.gameScreenButton.Text = "GAMESCREEN";
            this.gameScreenButton.UseVisualStyleBackColor = true;
            this.gameScreenButton.Click += new System.EventHandler(this.gameScreenButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 232);
            this.Controls.Add(this.gameScreenButton);
            this.Controls.Add(this.startScreenButton);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startScreenButton;
        private System.Windows.Forms.Button gameScreenButton;
    }
}