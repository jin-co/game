
namespace KBaekQGame
{
    partial class GameDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDesign));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.spcBoard = new System.Windows.Forms.SplitContainer();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbTest = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.ptbTest = new System.Windows.Forms.PictureBox();
            this.ptbTest2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBoard)).BeginInit();
            this.spcBoard.Panel1.SuspendLayout();
            this.spcBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTest2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRows);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCols);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 38);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(69, 7);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(58, 24);
            this.txtRows.TabIndex = 6;
            this.txtRows.Text = "3";
            this.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Columns:";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(232, 7);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(58, 24);
            this.txtCols.TabIndex = 3;
            this.txtCols.Text = "3";
            this.txtCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(321, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 32);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // spcBoard
            // 
            this.spcBoard.Location = new System.Drawing.Point(0, 71);
            this.spcBoard.Name = "spcBoard";
            // 
            // spcBoard.Panel1
            // 
            this.spcBoard.Panel1.Controls.Add(this.btnGreenBox);
            this.spcBoard.Panel1.Controls.Add(this.btnRedBox);
            this.spcBoard.Panel1.Controls.Add(this.btnGreenDoor);
            this.spcBoard.Panel1.Controls.Add(this.btnRedDoor);
            this.spcBoard.Panel1.Controls.Add(this.btnWall);
            this.spcBoard.Panel1.Controls.Add(this.btnNone);
            this.spcBoard.Panel1.Controls.Add(this.label3);
            this.spcBoard.Size = new System.Drawing.Size(855, 497);
            this.spcBoard.SplitterDistance = 123;
            this.spcBoard.TabIndex = 7;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.ImageIndex = 5;
            this.btnGreenBox.ImageList = this.imageList;
            this.btnGreenBox.Location = new System.Drawing.Point(3, 413);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(117, 51);
            this.btnGreenBox.TabIndex = 17;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.ToolBox_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "none.jpg");
            this.imageList.Images.SetKeyName(1, "wall.jpg");
            this.imageList.Images.SetKeyName(2, "reddoor.jpg");
            this.imageList.Images.SetKeyName(3, "greendoor.jpg");
            this.imageList.Images.SetKeyName(4, "redbox.jpg");
            this.imageList.Images.SetKeyName(5, "greenbox.jpg");
            // 
            // btnRedBox
            // 
            this.btnRedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.ImageIndex = 4;
            this.btnRedBox.ImageList = this.imageList;
            this.btnRedBox.Location = new System.Drawing.Point(3, 343);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(117, 51);
            this.btnRedBox.TabIndex = 15;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.ToolBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.ImageIndex = 3;
            this.btnGreenDoor.ImageList = this.imageList;
            this.btnGreenDoor.Location = new System.Drawing.Point(3, 273);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(117, 51);
            this.btnGreenDoor.TabIndex = 13;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.ToolBox_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.ImageIndex = 2;
            this.btnRedDoor.ImageList = this.imageList;
            this.btnRedDoor.Location = new System.Drawing.Point(3, 203);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(117, 51);
            this.btnRedDoor.TabIndex = 11;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.ToolBox_Click);
            // 
            // btnWall
            // 
            this.btnWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imageList;
            this.btnWall.Location = new System.Drawing.Point(3, 133);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(117, 51);
            this.btnWall.TabIndex = 9;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.ToolBox_Click);
            // 
            // btnNone
            // 
            this.btnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imageList;
            this.btnNone.Location = new System.Drawing.Point(3, 63);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(117, 51);
            this.btnNone.TabIndex = 7;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.ToolBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toolbox";
            // 
            // rtbTest
            // 
            this.rtbTest.Location = new System.Drawing.Point(162, 577);
            this.rtbTest.Name = "rtbTest";
            this.rtbTest.Size = new System.Drawing.Size(646, 61);
            this.rtbTest.TabIndex = 0;
            this.rtbTest.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(814, 577);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(41, 61);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "T";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ptbTest
            // 
            this.ptbTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbTest.Location = new System.Drawing.Point(6, 577);
            this.ptbTest.Name = "ptbTest";
            this.ptbTest.Size = new System.Drawing.Size(72, 61);
            this.ptbTest.TabIndex = 8;
            this.ptbTest.TabStop = false;
            // 
            // ptbTest2
            // 
            this.ptbTest2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbTest2.Location = new System.Drawing.Point(84, 577);
            this.ptbTest2.Name = "ptbTest2";
            this.ptbTest2.Size = new System.Drawing.Size(72, 61);
            this.ptbTest2.TabIndex = 9;
            this.ptbTest2.TabStop = false;
            // 
            // GameDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 650);
            this.Controls.Add(this.ptbTest2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.ptbTest);
            this.Controls.Add(this.rtbTest);
            this.Controls.Add(this.spcBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameDesign";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spcBoard.Panel1.ResumeLayout(false);
            this.spcBoard.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBoard)).EndInit();
            this.spcBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTest2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.SplitContainer spcBoard;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox ptbTest2;
        private System.Windows.Forms.PictureBox ptbTest;
        private System.Windows.Forms.ImageList imageList;
    }
}