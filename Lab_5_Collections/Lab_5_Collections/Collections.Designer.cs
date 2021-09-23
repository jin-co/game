
namespace Lab_5_Collections
{
    partial class Collections
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
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(38, 50);
            this.btnArrayList.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(112, 32);
            this.btnArrayList.TabIndex = 0;
            this.btnArrayList.Text = "ArrayListAdd";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(38, 131);
            this.btnHash.Margin = new System.Windows.Forms.Padding(4);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(112, 32);
            this.btnHash.TabIndex = 1;
            this.btnHash.Text = "Hash table";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(38, 208);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(112, 32);
            this.btnQueue.TabIndex = 2;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(38, 289);
            this.btnStack.Margin = new System.Windows.Forms.Padding(4);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(112, 32);
            this.btnStack.TabIndex = 3;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(203, 50);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(112, 32);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(203, 131);
            this.btnDictionary.Margin = new System.Windows.Forms.Padding(4);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(112, 32);
            this.btnDictionary.TabIndex = 5;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 208);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Linked List";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Collections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnArrayList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Collections";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button button3;
    }
}

