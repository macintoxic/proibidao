namespace Taboo
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnTaboo = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeA = new System.Windows.Forms.Label();
            this.lblTimeB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grdCard = new System.Windows.Forms.DataGridView();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnPauseContinue = new System.Windows.Forms.Button();
            this.tmrRoundTimer = new System.Windows.Forms.Timer(this.components);
            this.richCard = new System.Windows.Forms.RichTextBox();
            this.lblDeck = new System.Windows.Forms.Label();
            this.lblDescart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.PaleGreen;
            this.btnScore.Enabled = false;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScore.Location = new System.Drawing.Point(33, 281);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(207, 54);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "Correto (+1)";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Khaki;
            this.btnPass.Enabled = false;
            this.btnPass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPass.Location = new System.Drawing.Point(33, 341);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(207, 83);
            this.btnPass.TabIndex = 1;
            this.btnPass.Text = "Próxima Carta (Pular)";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnTaboo
            // 
            this.btnTaboo.BackColor = System.Drawing.Color.LightCoral;
            this.btnTaboo.Enabled = false;
            this.btnTaboo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaboo.Location = new System.Drawing.Point(33, 430);
            this.btnTaboo.Name = "btnTaboo";
            this.btnTaboo.Size = new System.Drawing.Size(207, 54);
            this.btnTaboo.TabIndex = 2;
            this.btnTaboo.Text = "Proibidão";
            this.btnTaboo.UseVisualStyleBackColor = false;
            this.btnTaboo.Click += new System.EventHandler(this.btnTaboo_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeam.Location = new System.Drawing.Point(262, 40);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(99, 37);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "Time A";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(262, 81);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(183, 37);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Tempo : 00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pontuação";
            // 
            // lblTimeA
            // 
            this.lblTimeA.AutoSize = true;
            this.lblTimeA.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeA.Location = new System.Drawing.Point(262, 301);
            this.lblTimeA.Name = "lblTimeA";
            this.lblTimeA.Size = new System.Drawing.Size(92, 28);
            this.lblTimeA.TabIndex = 6;
            this.lblTimeA.Text = "Time A: 0";
            // 
            // lblTimeB
            // 
            this.lblTimeB.AutoSize = true;
            this.lblTimeB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeB.Location = new System.Drawing.Point(262, 333);
            this.lblTimeB.Name = "lblTimeB";
            this.lblTimeB.Size = new System.Drawing.Size(90, 28);
            this.lblTimeB.TabIndex = 7;
            this.lblTimeB.Text = "Time B: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Carta";
            // 
            // grdCard
            // 
            this.grdCard.AllowUserToAddRows = false;
            this.grdCard.AllowUserToDeleteRows = false;
            this.grdCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCard.Location = new System.Drawing.Point(33, 40);
            this.grdCard.Name = "grdCard";
            this.grdCard.ReadOnly = true;
            this.grdCard.RowTemplate.Height = 25;
            this.grdCard.Size = new System.Drawing.Size(207, 222);
            this.grdCard.TabIndex = 9;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRound.Location = new System.Drawing.Point(262, 163);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(161, 54);
            this.btnRound.TabIndex = 10;
            this.btnRound.Text = "Iniciar Rodada";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRound.Location = new System.Drawing.Point(262, 122);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(130, 37);
            this.lblRound.TabIndex = 11;
            this.lblRound.Text = "Rodada 1";
            // 
            // btnPauseContinue
            // 
            this.btnPauseContinue.Enabled = false;
            this.btnPauseContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPauseContinue.Location = new System.Drawing.Point(262, 221);
            this.btnPauseContinue.Name = "btnPauseContinue";
            this.btnPauseContinue.Size = new System.Drawing.Size(161, 44);
            this.btnPauseContinue.TabIndex = 12;
            this.btnPauseContinue.Text = "Pausa";
            this.btnPauseContinue.UseVisualStyleBackColor = true;
            this.btnPauseContinue.Click += new System.EventHandler(this.btnPauseContinue_Click);
            // 
            // tmrRoundTimer
            // 
            this.tmrRoundTimer.Interval = 1000;
            this.tmrRoundTimer.Tick += new System.EventHandler(this.tmrRoundTimer_Tick);
            // 
            // richCard
            // 
            this.richCard.Location = new System.Drawing.Point(33, 40);
            this.richCard.Name = "richCard";
            this.richCard.ReadOnly = true;
            this.richCard.Size = new System.Drawing.Size(207, 222);
            this.richCard.TabIndex = 13;
            this.richCard.Text = "";
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeck.Location = new System.Drawing.Point(262, 381);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(55, 28);
            this.lblDeck.TabIndex = 14;
            this.lblDeck.Text = "Deck";
            // 
            // lblDescart
            // 
            this.lblDescart.AutoSize = true;
            this.lblDescart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescart.Location = new System.Drawing.Point(262, 414);
            this.lblDescart.Name = "lblDescart";
            this.lblDescart.Size = new System.Drawing.Size(87, 28);
            this.lblDescart.TabIndex = 15;
            this.lblDescart.Text = "Descarte";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 507);
            this.Controls.Add(this.lblDescart);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.richCard);
            this.Controls.Add(this.btnPauseContinue);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.grdCard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTimeB);
            this.Controls.Add(this.lblTimeA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnTaboo);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proibidão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnScore;
        private Button btnPass;
        private Button btnTaboo;
        private Label lblTeam;
        private Label lblTime;
        private Label label3;
        private Label lblTimeA;
        private Label lblTimeB;
        private Label label6;
        private DataGridView grdCard;
        private Button btnRound;
        private Label lblRound;
        private Button btnPauseContinue;
        private System.Windows.Forms.Timer tmrRoundTimer;
        private RichTextBox richCard;
        private Label lblDeck;
        private Label lblDescart;
    }
}