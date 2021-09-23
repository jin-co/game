
namespace RabbitEagle
{
    partial class MainGame
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.ptbBRabbit = new System.Windows.Forms.PictureBox();
            this.ptbBEagle5 = new System.Windows.Forms.PictureBox();
            this.ptbBEagle4 = new System.Windows.Forms.PictureBox();
            this.ptbBEagle3 = new System.Windows.Forms.PictureBox();
            this.ptbBEagle2 = new System.Windows.Forms.PictureBox();
            this.ptbBEagle1 = new System.Windows.Forms.PictureBox();
            this.lblGameEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBRabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(486, 308);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(212, 43);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // gametimer
            // 
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // ptbBRabbit
            // 
            this.ptbBRabbit.Image = global::RabbitEagle.Resource.rabbit;
            this.ptbBRabbit.Location = new System.Drawing.Point(477, 447);
            this.ptbBRabbit.Margin = new System.Windows.Forms.Padding(4);
            this.ptbBRabbit.Name = "ptbBRabbit";
            this.ptbBRabbit.Size = new System.Drawing.Size(85, 84);
            this.ptbBRabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBRabbit.TabIndex = 5;
            this.ptbBRabbit.TabStop = false;
            // 
            // ptbBEagle5
            // 
            this.ptbBEagle5.Image = global::RabbitEagle.Resource.eagle;
            this.ptbBEagle5.Location = new System.Drawing.Point(833, 69);
            this.ptbBEagle5.Margin = new System.Windows.Forms.Padding(4);
            this.ptbBEagle5.Name = "ptbBEagle5";
            this.ptbBEagle5.Size = new System.Drawing.Size(150, 69);
            this.ptbBEagle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBEagle5.TabIndex = 4;
            this.ptbBEagle5.TabStop = false;
            // 
            // ptbBEagle4
            // 
            this.ptbBEagle4.Image = global::RabbitEagle.Resource.eagle;
            this.ptbBEagle4.Location = new System.Drawing.Point(631, 69);
            this.ptbBEagle4.Margin = new System.Windows.Forms.Padding(4);
            this.ptbBEagle4.Name = "ptbBEagle4";
            this.ptbBEagle4.Size = new System.Drawing.Size(150, 69);
            this.ptbBEagle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBEagle4.TabIndex = 3;
            this.ptbBEagle4.TabStop = false;
            // 
            // ptbBEagle3
            // 
            this.ptbBEagle3.Image = global::RabbitEagle.Resource.eagle;
            this.ptbBEagle3.Location = new System.Drawing.Point(451, 69);
            this.ptbBEagle3.Margin = new System.Windows.Forms.Padding(4);
            this.ptbBEagle3.Name = "ptbBEagle3";
            this.ptbBEagle3.Size = new System.Drawing.Size(150, 69);
            this.ptbBEagle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBEagle3.TabIndex = 2;
            this.ptbBEagle3.TabStop = false;
            // 
            // ptbBEagle2
            // 
            this.ptbBEagle2.Image = global::RabbitEagle.Resource.eagle;
            this.ptbBEagle2.Location = new System.Drawing.Point(271, 69);
            this.ptbBEagle2.Margin = new System.Windows.Forms.Padding(4);
            this.ptbBEagle2.Name = "ptbBEagle2";
            this.ptbBEagle2.Size = new System.Drawing.Size(150, 69);
            this.ptbBEagle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBEagle2.TabIndex = 1;
            this.ptbBEagle2.TabStop = false;
            // 
            // ptbBEagle1
            // 
            this.ptbBEagle1.Image = global::RabbitEagle.Resource.eagle;
            this.ptbBEagle1.Location = new System.Drawing.Point(86, 69);
            this.ptbBEagle1.Margin = new System.Windows.Forms.Padding(4);
            this.ptbBEagle1.Name = "ptbBEagle1";
            this.ptbBEagle1.Size = new System.Drawing.Size(150, 69);
            this.ptbBEagle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBEagle1.TabIndex = 0;
            this.ptbBEagle1.TabStop = false;
            // 
            // lblGameEnd
            // 
            this.lblGameEnd.AutoSize = true;
            this.lblGameEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblGameEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameEnd.Location = new System.Drawing.Point(403, 211);
            this.lblGameEnd.Name = "lblGameEnd";
            this.lblGameEnd.Size = new System.Drawing.Size(378, 76);
            this.lblGameEnd.TabIndex = 7;
            this.lblGameEnd.Text = "Game Over";
            this.lblGameEnd.Click += new System.EventHandler(this.lblGameEnd_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RabbitEagle.Resource.bg;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.lblGameEnd);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.ptbBRabbit);
            this.Controls.Add(this.ptbBEagle5);
            this.Controls.Add(this.ptbBEagle4);
            this.Controls.Add(this.ptbBEagle3);
            this.Controls.Add(this.ptbBEagle2);
            this.Controls.Add(this.ptbBEagle1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGame";
            this.Text = "Rabbit and Eagle";
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBRabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBEagle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbBEagle1;
        private System.Windows.Forms.PictureBox ptbBEagle2;
        private System.Windows.Forms.PictureBox ptbBEagle3;
        private System.Windows.Forms.PictureBox ptbBEagle4;
        private System.Windows.Forms.PictureBox ptbBEagle5;
        private System.Windows.Forms.PictureBox ptbBRabbit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label lblGameEnd;
    }
}

