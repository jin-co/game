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

            Output(arrayList, "added four elements");
            arrayList.RemoveAt(1);
            Output(arrayList, "removed the elements[1]");

            arrayList.Clear();
            arrayList.Add(5);
            arrayList.Add(1);
            arrayList.Add(70);
            arrayList.Add(13);
            arrayList.Sort();
            Output(arrayList, "Added");
            
        }

        private void Output(ArrayList arrayList, string title)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is Button)
                {
                    Debug.WriteLine(((Button)arrayList[i]).Text);
                }
                else
                {
                    Debug.WriteLine(arrayList[i]);
                }
            }
            arrayList.RemoveAt(1);
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "this is the first element");
            ht.Add("pie", 3.14f);
            ht.Add(3.14f, 3.14);

            Debug.WriteLine(ht[1]);
            foreach (var i in ht.Keys)
            {
                Debug.WriteLine("Key is" + i + " --- value" + ht[i]);

            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Queue q = new Queue();
            q.Enqueue("string queue value");
            q.Enqueue(200);
            q.Enqueue(3.14f);

            foreach (var i in q)
            {
                Debug.WriteLine(i);
            }

            // write
            q.Dequeue();

            foreach (var i in q)
            {
                Debug.WriteLine(i);
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack s = new Stack();
            s.Push("this is string stack ele");
            s.Push(40);
            s.Push(4.4f);

            // write
            s.Pop();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");
            list.Insert(1, "insert");

            list.RemoveAt(0);

            foreach (var i in list)
            {
                Debug.WriteLine(i);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

        }

        private void btnGQueue_Click(object sender, EventArgs e)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("first one to be served");
            q.Enqueue("second one to be served");

            // write
            q.Dequeue();
        }

        private void btnGStack_Click(object sender, EventArgs e)
        {
            Stack<string> s = new Stack<string>();
            s.Push("first one last served");
            s.Push("second one last served");

            // write
            s.Pop();
        }

        private void btnLinkedList_Click(object sender, EventArgs e)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst("first");
            linkedList.AddLast("second");
            linkedList.AddLast("last");

            linkedList.RemoveFirst();
        }
    }
}
