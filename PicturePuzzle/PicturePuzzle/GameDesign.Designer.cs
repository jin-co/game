
namespace PicturePuzzle
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsSave,
            this.mnsClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnsSave
            // 
            this.mnsSave.Name = "mnsSave";
            this.mnsSave.Size = new System.Drawing.Size(180, 22);
            this.mnsSave.Text = "&Save";
            this.mnsSave.Click += new System.EventHandler(this.mnsSave_Click);
            // 
            // mnsClose
            // 
            this.mnsClose.Name = "mnsClose";
            this.mnsClose.Size = new System.Drawing.Size(180, 22);
            this.mnsClose.Text = "&Close";
            this.mnsClose.Click += new System.EventHandler(this.mnsClose_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsLevel1,
            this.mnsLevel2});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // mnsLevel1
            // 
            this.mnsLevel1.Name = "mnsLevel1";
            this.mnsLevel1.Size = new System.Drawing.Size(180, 22);
            this.mnsLevel1.Text = "Level 1 (3 x 3)";
            this.mnsLevel1.Click += new System.EventHandler(this.mnsLevel1_Click);
            // 
            // mnsLevel2
            // 
            this.mnsLevel2.Name = "mnsLevel2";
            this.mnsLevel2.Size = new System.Drawing.Size(180, 22);
            this.mnsLevel2.Text = "Level 2 (4 x 4)";
            this.mnsLevel2.Click += new System.EventHandler(this.mnsLevel2_Click);
            // 
            // GameDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameDesign";
            this.Text = "GameDesign";
            this.Load += new System.EventHandler(this.GameDesign_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsSave;
        private System.Windows.Forms.ToolStripMenuItem mnsClose;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsLevel1;
        private System.Windows.Forms.ToolStripMenuItem mnsLevel2;
    }
}