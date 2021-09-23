using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_Collections
{
    public partial class Collections : Form
    {
        public Collections()
        {
            InitializeComponent();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("String value");
            arrayList.Add(100);
            arrayList.Add(3.14f);
            Button button = new Button();
            button.Text = "This is a button";
            arrayList.Add(button);

            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is Button)
                {
                    Debug.WriteLine(((Button)arrayList[i]).Text);
                }
                Debug.WriteLine(arrayList[i]);
            }

        }
    }
}
