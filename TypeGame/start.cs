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
using System.Collections;
using System.Media;

namespace TypeGame
{
    public partial class start : Form
    {
        private string[] wordTable = new string[0];
        private int questionNum = 0;
        private ArrayList getWord = new ArrayList();
        private book wordBook;
        private form1 mainGame;
        private Word[] table = new Word[0];
        private int nowPicture = 0;

        public start()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void start_Load(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer(@"story_BGM.wav");

            music.Play();
            startPage.Visible = true;
            animate.Visible = true;

            attack1.Visible = false;
            attack2.Visible = false;
            attack3.Visible = false;
            attack4.Visible = false;

            storyTime.Enabled = true;

            if (File.Exists(@"question\question.txt"))
            {
                StreamReader sr = new StreamReader(@"question\question.txt");
                while (true)
                {
                    string temp = sr.ReadLine();
                    if (temp == null) break;
                    else 
                    {
                        Array.Resize(ref table, table.Length + 1);
                        table[questionNum] = new Word();

                        if (!temp.Substring(0, 1).Equals("#"))
                        {
                            table[questionNum].setContent(temp);
                            table[questionNum].setCollect(false);
                        }
                        else
                        {
                            table[questionNum].setContent(temp.Substring(1, temp.Length - 1));
                            table[questionNum].setCollect(true);
                        }

                        questionNum++;
                    }
                }
            }
        }

        private void gameStart_MouseLeave(object sender, EventArgs e)
        {
            gameStart.BackgroundImage = Resource1.startgame;
        }

        private void gameStart_MouseMove(object sender, MouseEventArgs e)
        {
            gameStart.BackgroundImage = Resource1.startgame_select;
        }

        private void book_MouseLeave(object sender, EventArgs e)
        {
            book.BackgroundImage = Resource1.book;
            book.Location = new Point(535, 12);
            book.Size = new Size(41, 54);
        }

        private void book_MouseMove(object sender, MouseEventArgs e)
        {
            book.BackgroundImage = Resource1.book_select;
            book.Location = new Point(508, 12);
            book.Size = new Size(67, 54);
        }

        private void exit_MouseMove(object sender, MouseEventArgs e)
        {
            exit.BackgroundImage = Resource1.exit_select;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Resource1.exit;
        }

        private void gameStart_Click(object sender, EventArgs e)
        {
            mainGame = new form1(this, table, questionNum);
            mainGame.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void book_Click(object sender, EventArgs e)
        {
            wordBook = new book();
            wordBook.Visible = true;
        }

        private void storyTime_Tick(object sender, EventArgs e)
        {
            nowPicture += 1;

            if (nowPicture == 1)
            {
                story.Visible = true;
                story.Image = Resource1.story1;
            }
            else if (nowPicture == 2)
                story.Image = Resource1.story2;
            else if (nowPicture == 3)
                story.Image = Resource1.story3;
            else if (nowPicture == 6)
            {
                story.Visible = false;
                attack1.Visible = true;
            }
            else if (nowPicture == 7)
                attack2.Visible = true;
            else if (nowPicture == 8)
                attack3.Visible = true;
            else if (nowPicture == 9)
                attack4.Visible = true;
            else if (nowPicture == 10)
            {
                story.Visible = true;
                story.Image = Resource1.story4;
            }
            else if (nowPicture == 12)
            {
                storyTime.Enabled = false;
                animate.Visible = false;
                startPage.Visible = true;
            }
            
        }
    }
}
