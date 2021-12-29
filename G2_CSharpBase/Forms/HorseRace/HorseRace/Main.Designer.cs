
namespace HorseRace
{
    partial class Main
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
            this.txtNumberOfHorses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlGround = new System.Windows.Forms.Panel();
            this.pnlFinishLine = new System.Windows.Forms.Panel();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.pnlGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumberOfHorses
            // 
            this.txtNumberOfHorses.Location = new System.Drawing.Point(235, 60);
            this.txtNumberOfHorses.Name = "txtNumberOfHorses";
            this.txtNumberOfHorses.Size = new System.Drawing.Size(30, 24);
            this.txtNumberOfHorses.TabIndex = 0;
            this.txtNumberOfHorses.Text = "8";
            this.txtNumberOfHorses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Horses:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(328, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShowRecord
            // 
            this.btnShowRecord.Location = new System.Drawing.Point(468, 61);
            this.btnShowRecord.Name = "btnShowRecord";
            this.btnShowRecord.Size = new System.Drawing.Size(121, 23);
            this.btnShowRecord.TabIndex = 3;
            this.btnShowRecord.Text = "Show Record";
            this.btnShowRecord.UseVisualStyleBackColor = true;
            this.btnShowRecord.Click += new System.EventHandler(this.btnShowRecord_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(608, 61);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(121, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 61);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlGround
            // 
            this.pnlGround.BackgroundImage = global::HorseRace.Resources.track;
            this.pnlGround.Controls.Add(this.pnlFinishLine);
            this.pnlGround.Location = new System.Drawing.Point(29, 92);
            this.pnlGround.Name = "pnlGround";
            this.pnlGround.Size = new System.Drawing.Size(1129, 519);
            this.pnlGround.TabIndex = 7;
            // 
            // pnlFinishLine
            // 
            this.pnlFinishLine.BackColor = System.Drawing.Color.Red;
            this.pnlFinishLine.Location = new System.Drawing.Point(1037, 1);
            this.pnlFinishLine.Name = "pnlFinishLine";
            this.pnlFinishLine.Size = new System.Drawing.Size(10, 519);
            this.pnlFinishLine.TabIndex = 6;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(29, 22);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(1129, 24);
            this.txtTest.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.pnlGround);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnShowRecord);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfHorses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Horese Race";
            this.pnlGround.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfHorses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShowRecord;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFinishLine;
        private System.Windows.Forms.Panel pnlGround;
        private System.Windows.Forms.TextBox txtTest;
    }
}

