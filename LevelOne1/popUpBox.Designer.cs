namespace LevelOne1
{
    partial class popUpBox
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(180, 39);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(106, 36);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textLabel.Location = new System.Drawing.Point(145, 95);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(262, 36);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "You Have Got";
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Image = global::LevelOne1.Properties.Resources.no_star;
            this.star1.Location = new System.Drawing.Point(162, 148);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(57, 59);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 2;
            this.star1.TabStop = false;
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Image = global::LevelOne1.Properties.Resources.no_star;
            this.star2.Location = new System.Drawing.Point(247, 148);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(57, 59);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 3;
            this.star2.TabStop = false;
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.Image = global::LevelOne1.Properties.Resources.no_star;
            this.star3.Location = new System.Drawing.Point(333, 148);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(57, 59);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 4;
            this.star3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(229, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // popUpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LevelOne1.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 300);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "popUpBox";
            this.Text = "Level One";
            this.Load += new System.EventHandler(this.popUpBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
    }
}