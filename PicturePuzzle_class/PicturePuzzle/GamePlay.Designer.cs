
namespace PicturePuzzle
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
            this.mnsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.mnsExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsLoad,
            this.mnsSave});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(37, 20);
            this.mnsFile.Text = "File";
            // 
            // mnsLoad
            // 
            this.mnsLoad.Name = "mnsLoad";
            this.mnsLoad.Size = new System.Drawing.Size(180, 22);
            this.mnsLoad.Text = "Load";
            this.mnsLoad.Click += new System.EventHandler(this.mnsLoad_Click);
            // 
            // mnsSave
            // 
            this.mnsSave.Name = "mnsSave";
            this.mnsSave.Size = new System.Drawing.Size(180, 22);
            this.mnsSave.Text = "Save";
            this.mnsSave.Click += new System.EventHandler(this.mnsSave_Click);
            // 
            // mnsExit
            // 
            this.mnsExit.Name = "mnsExit";
            this.mnsExit.Size = new System.Drawing.Size(38, 20);
            this.mnsExit.Text = "Exit";
            this.mnsExit.Click += new System.EventHandler(this.mnsExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsFile;
        private System.Windows.Forms.ToolStripMenuItem mnsLoad;
        private System.Windows.Forms.ToolStripMenuItem mnsSave;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}