
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
            this.btnGQueue = new System.Windows.Forms.Button();
            this.btnGStack = new System.Windows.Forms.Button();
            this.btnLinkedList = new System.Windows.Forms.Button();
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
            // btnGQueue
            // 
            this.btnGQueue.Location = new System.Drawing.Point(203, 208);
            this.btnGQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnGQueue.Name = "btnGQueue";
            this.btnGQueue.Size = new System.Drawing.Size(112, 32);
            this.btnGQueue.TabIndex = 6;
            this.btnGQueue.Text = "GQueue";
            this.btnGQueue.UseVisualStyleBackColor = true;
            this.btnGQueue.Click += new System.EventHandler(this.btnGQueue_Click);
            // 
            // btnGStack
            // 
            this.btnGStack.Location = new System.Drawing.Point(203, 289);
            this.btnGStack.Margin = new System.Windows.Forms.Padding(4);
            this.btnGStack.Name = "btnGStack";
            this.btnGStack.Size = new System.Drawing.Size(112, 32);
            this.btnGStack.TabIndex = 7;
            this.btnGStack.Text = "GStack";
            this.btnGStack.UseVisualStyleBackColor = true;
            this.btnGStack.Click += new System.EventHandler(this.btnGStack_Click);
            // 
            // btnLinkedList
            // 
            this.btnLinkedList.Location = new System.Drawing.Point(362, 50);
            this.btnLinkedList.Margin = new System.Windows.Forms.Padding(4);
            this.btnLinkedList.Name = "btnLinkedList";
            this.btnLinkedList.Size = new System.Drawing.Size(112, 32);
            this.btnLinkedList.TabIndex = 8;
            this.btnLinkedList.Text = "Linked List";
            this.btnLinkedList.UseVisualStyleBackColor = true;
            this.btnLinkedList.Click += new System.EventHandler(this.btnLinkedList_Click);
            // 
            // Collections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.btnLinkedList);
            this.Controls.Add(this.btnGStack);
            this.Controls.Add(this.btnGQueue);
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
        private System.Windows.Forms.Button btnGQueue;
        private System.Windows.Forms.Button btnGStack;
        private System.Windows.Forms.Button btnLinkedList;
    }
}

