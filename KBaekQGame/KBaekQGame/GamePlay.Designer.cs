
namespace KBaekQGame
{
    partial class GamePlay
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfMoves = new System.Windows.Forms.TextBox();
            this.txtNumberOfRemainingBoxes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.rtbTest = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.spcPlayBoard = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPlayBoard)).BeginInit();
            this.spcPlayBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadGameToolStripMenuItem.Text = "&Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(948, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of moves:";
            // 
            // txtNumberOfMoves
            // 
            this.txtNumberOfMoves.Location = new System.Drawing.Point(951, 60);
            this.txtNumberOfMoves.Name = "txtNumberOfMoves";
            this.txtNumberOfMoves.ReadOnly = true;
            this.txtNumberOfMoves.Size = new System.Drawing.Size(100, 24);
            this.txtNumberOfMoves.TabIndex = 2;
            // 
            // txtNumberOfRemainingBoxes
            // 
            this.txtNumberOfRemainingBoxes.Location = new System.Drawing.Point(951, 125);
            this.txtNumberOfRemainingBoxes.Name = "txtNumberOfRemainingBoxes";
            this.txtNumberOfRemainingBoxes.ReadOnly = true;
            this.txtNumberOfRemainingBoxes.Size = new System.Drawing.Size(100, 24);
            this.txtNumberOfRemainingBoxes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(948, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of remaining boxes:";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1012, 428);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 55);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.Cursor_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1012, 489);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 55);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.Cursor_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(951, 489);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 55);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.Cursor_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1073, 489);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 55);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.Cursor_Click);
            // 
            // rtbTest
            // 
            this.rtbTest.Location = new System.Drawing.Point(826, 179);
            this.rtbTest.Name = "rtbTest";
            this.rtbTest.Size = new System.Drawing.Size(365, 229);
            this.rtbTest.TabIndex = 0;
            this.rtbTest.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(40, 40);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // spcPlayBoard
            // 
            this.spcPlayBoard.Location = new System.Drawing.Point(12, 39);
            this.spcPlayBoard.Name = "spcPlayBoard";
            this.spcPlayBoard.Size = new System.Drawing.Size(790, 538);
            this.spcPlayBoard.SplitterDistance = 25;
            this.spcPlayBoard.TabIndex = 9;
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.spcPlayBoard);
            this.Controls.Add(this.rtbTest);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtNumberOfRemainingBoxes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfMoves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GamePlay";
            this.Text = "Play form";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPlayBoard)).EndInit();
            this.spcPlayBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfMoves;
        private System.Windows.Forms.TextBox txtNumberOfRemainingBoxes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.RichTextBox rtbTest;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer spcPlayBoard;
    }
}