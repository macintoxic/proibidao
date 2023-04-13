namespace Taboo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.Location = new System.Drawing.Point(88, 43);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(121, 68);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Nova Partida";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHowToPlay.Location = new System.Drawing.Point(88, 132);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(121, 68);
            this.btnHowToPlay.TabIndex = 1;
            this.btnHowToPlay.Text = "Como Jogar";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 243);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proibidão";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNewGame;
        private Button btnHowToPlay;
    }
}