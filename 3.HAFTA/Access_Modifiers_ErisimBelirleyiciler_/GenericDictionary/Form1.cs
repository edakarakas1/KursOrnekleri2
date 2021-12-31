using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> mylist = new List<string>();
            mylist.Add("Matematik");
            mylist.Add("Fizik");
            mylist.Add("Kimya");
            mylist.Add("Biyoloji");
            mylist.Add("İngizce");
        
            MessageBox.Show("Kapasite: "+ mylist.Capacity.ToString());

            mylist.TrimExcess();
            MessageBox.Show("TrimExcess sonrası kapasite:"+ mylist.Capacity.ToString());

            MessageBox.Show("Count : "+ mylist.Count());

            MessageBox.Show("Contains : "+ mylist.Contains("Kimya"));

            mylist.Insert(0, "Türkçe");

        }
        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> icindekiler = new Dictionary<int, string>();
            icindekiler.Add(0, "Generic");
            icindekiler.Add(5, "List<>");
            icindekiler.Add(2,"Dictionary");
            icindekiler.Add(4, "SortedList");
            icindekiler.Add(3,"Stack");
            icindekiler.Add(1,"Queue<>");

            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int,string> item in icindekiler)
            {
                sb.Append(item.Key);
                sb.Append("-");
                sb.Append(item.Value);
                sb.AppendLine();

            }
            MessageBox.Show(sb.ToString());
        }
    }
}
