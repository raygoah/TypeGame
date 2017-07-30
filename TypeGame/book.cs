using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TypeGame
{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void book_Load(object sender, EventArgs e)
        {
            String[] myWord = new String[0];
            int number = 0;

            if (File.Exists(@"question\translation.txt"))
            {
                /*BinaryReader br = new BinaryReader(File.Open(@"question\translation.txt", FileMode.Open));
                String temp = br.ReadString();*/

                StreamReader sr = new StreamReader(@"question\translation.txt", System.Text.Encoding.Default);
                string temp = sr.ReadLine();
                while (temp != null)
                {
                    Array.Resize(ref myWord, myWord.Length + 1);
                    myWord[number] = temp;
                    temp = sr.ReadLine();
                    number++;
                }
                sr.Close();
            }

            if (File.Exists(@"question\question.txt"))
            {
                StreamReader sr = new StreamReader(@"question\question.txt", System.Text.Encoding.Default);
                string temp = sr.ReadLine();
                int i = 0;
                while (temp != null)
                {
                    if (temp.Substring(0, 1).Equals("#"))
                    {
                        wordTable.Items.Add(myWord[i]);
                    }
                    i++;
                    temp = sr.ReadLine();
                }
                sr.Close();
            }
        }
    }
}
