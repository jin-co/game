
namespace LoadImage
{
    partial class MainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupGrid = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(95, 22);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(99, 23);
            this.txtRows.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(353, 22);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(99, 23);
            this.txtCols.TabIndex = 3;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(519, 17);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(130, 39);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(726, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 39);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupGrid
            // 
            this.groupGrid.Location = new System.Drawing.Point(38, 96);
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.Size = new System.Drawing.Size(817, 585);
            this.groupGrid.TabIndex = 6;
            this.groupGrid.TabStop = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 746);
            this.Controls.Add(this.groupGrid);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label1);
            this.Name = "MainGame";
            this.Text = "Another way to load image into memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupGrid;
    }
}

