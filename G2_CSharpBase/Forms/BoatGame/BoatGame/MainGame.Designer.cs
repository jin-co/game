
namespace BoatGame
{
    partial class form
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
            this.grbWater = new System.Windows.Forms.GroupBox();
            this.txtColorSequence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.txtRemoveColor = new System.Windows.Forms.TextBox();
            this.btnRemoveColor = new System.Windows.Forms.Button();
            this.cbbRemoveColors = new System.Windows.Forms.ComboBox();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.SuspendLayout();
            // 
            // grbWater
            // 
            this.grbWater.Location = new System.Drawing.Point(130, 205);
            this.grbWater.Name = "grbWater";
            this.grbWater.Size = new System.Drawing.Size(1059, 406);
            this.grbWater.TabIndex = 0;
            this.grbWater.TabStop = false;
            // 
            // txtColorSequence
            // 
            this.txtColorSequence.Location = new System.Drawing.Point(130, 52);
            this.txtColorSequence.Name = "txtColorSequence";
            this.txtColorSequence.ReadOnly = true;
            this.txtColorSequence.Size = new System.Drawing.Size(240, 24);
            this.txtColorSequence.TabIndex = 1;
            this.txtColorSequence.Text = "7";
            this.txtColorSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color Sequence:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(130, 162);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1094, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(257, 83);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(113, 23);
            this.btnAddColor.TabIndex = 8;
            this.btnAddColor.Text = "Add Color";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // txtRemoveColor
            // 
            this.txtRemoveColor.Location = new System.Drawing.Point(130, 83);
            this.txtRemoveColor.Name = "txtRemoveColor";
            this.txtRemoveColor.Size = new System.Drawing.Size(121, 24);
            this.txtRemoveColor.TabIndex = 11;
            this.txtRemoveColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemoveColor
            // 
            this.btnRemoveColor.Location = new System.Drawing.Point(257, 112);
            this.btnRemoveColor.Name = "btnRemoveColor";
            this.btnRemoveColor.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveColor.TabIndex = 10;
            this.btnRemoveColor.Text = "Remove Color";
            this.btnRemoveColor.UseVisualStyleBackColor = true;
            this.btnRemoveColor.Click += new System.EventHandler(this.btnRemoveColor_Click);
            // 
            // cbbRemoveColors
            // 
            this.cbbRemoveColors.FormattingEnabled = true;
            this.cbbRemoveColors.Location = new System.Drawing.Point(130, 113);
            this.cbbRemoveColors.Name = "cbbRemoveColors";
            this.cbbRemoveColors.Size = new System.Drawing.Size(121, 26);
            this.cbbRemoveColors.TabIndex = 12;
            // 
            // dgvColors
            // 
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Location = new System.Drawing.Point(8, 60);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.Size = new System.Drawing.Size(116, 551);
            this.dgvColors.TabIndex = 13;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(464, 100);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 24);
            this.txtTest.TabIndex = 14;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(430, 162);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(45, 24);
            this.txtDelete.TabIndex = 15;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.dgvColors);
            this.Controls.Add(this.cbbRemoveColors);
            this.Controls.Add(this.txtRemoveColor);
            this.Controls.Add(this.btnRemoveColor);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColorSequence);
            this.Controls.Add(this.grbWater);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbWater;
        private System.Windows.Forms.TextBox txtColorSequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.TextBox txtRemoveColor;
        private System.Windows.Forms.Button btnRemoveColor;
        private System.Windows.Forms.ComboBox cbbRemoveColors;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtDelete;
    }
}

