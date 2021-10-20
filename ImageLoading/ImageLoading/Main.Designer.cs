
namespace ImageLoading
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.rtbPath = new System.Windows.Forms.RichTextBox();
            this.txtPath = new System.Windows.Forms.Button();
            this.grbPics = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(145, 44);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 24);
            this.txtRows.TabIndex = 1;
            this.txtRows.Text = "3";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(381, 47);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(100, 24);
            this.txtCols.TabIndex = 3;
            this.txtCols.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(677, 50);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(955, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(95, 546);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(1043, 24);
            this.txtTest.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(821, 50);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // rtbPath
            // 
            this.rtbPath.Location = new System.Drawing.Point(677, 107);
            this.rtbPath.Name = "rtbPath";
            this.rtbPath.Size = new System.Drawing.Size(511, 291);
            this.rtbPath.TabIndex = 8;
            this.rtbPath.Text = "";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(677, 419);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(75, 23);
            this.txtPath.TabIndex = 9;
            this.txtPath.Text = "File Path";
            this.txtPath.UseVisualStyleBackColor = true;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // grbPics
            // 
            this.grbPics.Location = new System.Drawing.Point(45, 92);
            this.grbPics.Name = "grbPics";
            this.grbPics.Size = new System.Drawing.Size(537, 434);
            this.grbPics.TabIndex = 10;
            this.grbPics.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.grbPics);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.rtbPath);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RichTextBox rtbPath;
        private System.Windows.Forms.Button txtPath;
        private System.Windows.Forms.GroupBox grbPics;
    }
}

