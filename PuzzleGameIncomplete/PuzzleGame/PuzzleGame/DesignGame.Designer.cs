
namespace PuzzleGame
{
    partial class DesignGame
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
            this.designPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level13X3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level24X4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designPuzzleToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // designPuzzleToolStripMenuItem
            // 
            this.designPuzzleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level13X3ToolStripMenuItem,
            this.level24X4ToolStripMenuItem});
            this.designPuzzleToolStripMenuItem.Name = "designPuzzleToolStripMenuItem";
            this.designPuzzleToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.designPuzzleToolStripMenuItem.Text = "Design Puzzle";
            // 
            // level13X3ToolStripMenuItem
            // 
            this.level13X3ToolStripMenuItem.Name = "level13X3ToolStripMenuItem";
            this.level13X3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.level13X3ToolStripMenuItem.Text = "Level 1 (3X3)";
            // 
            // level24X4ToolStripMenuItem
            // 
            this.level24X4ToolStripMenuItem.Name = "level24X4ToolStripMenuItem";
            this.level24X4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.level24X4ToolStripMenuItem.Text = "Level 2 (4X4)";
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // DesignGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 677);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DesignGame";
            this.Text = "Design Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem designPuzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level13X3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level24X4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}