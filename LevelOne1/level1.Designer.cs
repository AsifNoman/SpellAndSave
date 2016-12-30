namespace LevelOne1
{
    partial class levelOne
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
            this.lifelabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.ghost1 = new System.Windows.Forms.PictureBox();
            this.spellText = new System.Windows.Forms.TextBox();
            this.playpause = new System.Windows.Forms.PictureBox();
            this.ghost4 = new System.Windows.Forms.PictureBox();
            this.ghost5 = new System.Windows.Forms.PictureBox();
            this.ghost6 = new System.Windows.Forms.PictureBox();
            this.ghost7 = new System.Windows.Forms.PictureBox();
            this.bossPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lifelabel
            // 
            this.lifelabel.AutoSize = true;
            this.lifelabel.BackColor = System.Drawing.Color.Transparent;
            this.lifelabel.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifelabel.ForeColor = System.Drawing.Color.Red;
            this.lifelabel.Location = new System.Drawing.Point(13, 11);
            this.lifelabel.Name = "lifelabel";
            this.lifelabel.Size = new System.Drawing.Size(81, 36);
            this.lifelabel.TabIndex = 0;
            this.lifelabel.Text = "Life:";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.Color.Red;
            this.scorelabel.Location = new System.Drawing.Point(748, 8);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(105, 36);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "Score:";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::LevelOne1.Properties.Resources.Player0;
            this.player.Location = new System.Drawing.Point(401, 206);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(123, 110);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // ghost1
            // 
            this.ghost1.BackColor = System.Drawing.Color.Transparent;
            this.ghost1.Image = global::LevelOne1.Properties.Resources.ghost1;
            this.ghost1.Location = new System.Drawing.Point(316, 9);
            this.ghost1.Name = "ghost1";
            this.ghost1.Size = new System.Drawing.Size(65, 89);
            this.ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost1.TabIndex = 3;
            this.ghost1.TabStop = false;
            this.ghost1.Paint += new System.Windows.Forms.PaintEventHandler(this.ghost1_Paint);
            // 
            // spellText
            // 
            this.spellText.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.spellText.Location = new System.Drawing.Point(1, 590);
            this.spellText.Name = "spellText";
            this.spellText.Size = new System.Drawing.Size(878, 41);
            this.spellText.TabIndex = 4;
            this.spellText.TextChanged += new System.EventHandler(this.spellText_TextChanged);
            // 
            // playpause
            // 
            this.playpause.BackColor = System.Drawing.Color.Transparent;
            this.playpause.Image = global::LevelOne1.Properties.Resources.Pause;
            this.playpause.Location = new System.Drawing.Point(885, 577);
            this.playpause.Name = "playpause";
            this.playpause.Size = new System.Drawing.Size(113, 53);
            this.playpause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playpause.TabIndex = 5;
            this.playpause.TabStop = false;
            this.playpause.Click += new System.EventHandler(this.playpause_Click);
            // 
            // ghost4
            // 
            this.ghost4.BackColor = System.Drawing.Color.Transparent;
            this.ghost4.Image = global::LevelOne1.Properties.Resources.ghost1;
            this.ghost4.Location = new System.Drawing.Point(46, 489);
            this.ghost4.Name = "ghost4";
            this.ghost4.Size = new System.Drawing.Size(75, 89);
            this.ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost4.TabIndex = 6;
            this.ghost4.TabStop = false;
            this.ghost4.Paint += new System.Windows.Forms.PaintEventHandler(this.ghost4_Paint);
            // 
            // ghost5
            // 
            this.ghost5.BackColor = System.Drawing.Color.Transparent;
            this.ghost5.Image = global::LevelOne1.Properties.Resources.g2;
            this.ghost5.Location = new System.Drawing.Point(912, 486);
            this.ghost5.Name = "ghost5";
            this.ghost5.Size = new System.Drawing.Size(75, 89);
            this.ghost5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost5.TabIndex = 7;
            this.ghost5.TabStop = false;
            this.ghost5.Paint += new System.Windows.Forms.PaintEventHandler(this.ghost5_Paint);
            // 
            // ghost6
            // 
            this.ghost6.BackColor = System.Drawing.Color.Transparent;
            this.ghost6.Image = global::LevelOne1.Properties.Resources.ghost1;
            this.ghost6.Location = new System.Drawing.Point(12, 50);
            this.ghost6.Name = "ghost6";
            this.ghost6.Size = new System.Drawing.Size(75, 89);
            this.ghost6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost6.TabIndex = 8;
            this.ghost6.TabStop = false;
            this.ghost6.Paint += new System.Windows.Forms.PaintEventHandler(this.ghost6_Paint);
            // 
            // ghost7
            // 
            this.ghost7.BackColor = System.Drawing.Color.Transparent;
            this.ghost7.Image = global::LevelOne1.Properties.Resources.g2;
            this.ghost7.Location = new System.Drawing.Point(922, 50);
            this.ghost7.Name = "ghost7";
            this.ghost7.Size = new System.Drawing.Size(75, 89);
            this.ghost7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost7.TabIndex = 9;
            this.ghost7.TabStop = false;
            this.ghost7.Paint += new System.Windows.Forms.PaintEventHandler(this.ghost7_Paint);
            // 
            // bossPicture
            // 
            this.bossPicture.BackColor = System.Drawing.Color.Transparent;
            this.bossPicture.Image = global::LevelOne1.Properties.Resources.boss1;
            this.bossPicture.Location = new System.Drawing.Point(10, 471);
            this.bossPicture.Name = "bossPicture";
            this.bossPicture.Size = new System.Drawing.Size(115, 109);
            this.bossPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossPicture.TabIndex = 10;
            this.bossPicture.TabStop = false;
            this.bossPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.bossPicture_Paint);
            // 
            // levelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LevelOne1.Properties.Resources._1022x670;
            this.ClientSize = new System.Drawing.Size(1006, 631);
            this.Controls.Add(this.bossPicture);
            this.Controls.Add(this.ghost7);
            this.Controls.Add(this.ghost6);
            this.Controls.Add(this.ghost5);
            this.Controls.Add(this.ghost4);
            this.Controls.Add(this.playpause);
            this.Controls.Add(this.spellText);
            this.Controls.Add(this.ghost1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.lifelabel);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "levelOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level One";
            this.Load += new System.EventHandler(this.levelOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lifelabel;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ghost1;
        private System.Windows.Forms.TextBox spellText;
        private System.Windows.Forms.PictureBox playpause;
        private System.Windows.Forms.PictureBox ghost4;
        private System.Windows.Forms.PictureBox ghost5;
        private System.Windows.Forms.PictureBox ghost6;
        private System.Windows.Forms.PictureBox ghost7;
        private System.Windows.Forms.PictureBox bossPicture;
    }
}

