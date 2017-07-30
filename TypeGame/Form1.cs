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
using System.Runtime.InteropServices;
using System.Collections;

namespace TypeGame
{
    public partial class form1 : Form
    {
        private string[] wordTable = new string[0];
        private Word[] table = new Word[0];
        private start s;

        private ArrayList magicList = new ArrayList();
        private ArrayList problemList = new ArrayList();
        private int questionNum = 0;

        private int interval = 0;
        private int magicInterval = 0;
        private int originalSpeed = 100;
        private int upSpeed = 30;
        private int makeQuestionInterval = 45;
        private bool isPause = false;

        private int score = 100;
        private int gameScore = 0;
        private int correctNum = 0;
        private int levelNum = 10;
        private int life = 5;

        private int animateCount = 0;
        private int mode = -1;
        private bool showLevelIcon = false;
        private int showLevelIconTime = 1;
        Random random = new Random();

        public form1(start s ,Word[] table,int quesNumber)
        {
            this.s = s;
            questionNum = quesNumber;
            Array.Resize(ref this.table, this.table.Length + quesNumber);
            Array.Resize(ref wordTable, wordTable.Length + quesNumber);
            this.table = table;

            InitializeComponent();
            this.DoubleBuffered = true;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        private void Form1_Load(object sender, EventArgs e)
        {

            gametime.Enabled = true;
            gametime.Interval = originalSpeed;
            showNum.Text = correctNum + " \\ " + levelNum;
            showScore.Text = "0";

            Magictime.Enabled = true;
            Magictime.Interval = 2500;
            animation.Enabled = false;
            animation.Interval = 250;
            ctrlIcon.Image = Resource1.ctrl;

            magicEffect.Enabled = false;
            magicEffect.Interval = 1000;


            levelUpIcon.Visible = false;
            levelUpIcon.Location = new System.Drawing.Point(195, 105);
        }

        //亂數產生題目
        public void makeQuestion()
        {
            
            int index = 0;
            
            do{
                index = random.Next(questionNum);
            } while (table[index].getCollect() == true);

            Problem p = new Problem(table[index]);
            p.setWordIndex(index);

            if (random.Next(2) == 0)
                p.move(700,144);
            else
                p.move(700, 235);

            this.Controls.Add(p.ballon);
            problemList.Add(p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (interval % makeQuestionInterval == 0)
            {
                makeQuestion();
                interval = 1;
            }

            interval = interval + 1;
            for (int i = 0; i < problemList.Count; ++i)
            {
                Problem p = (Problem)problemList[i];
                p.ballon.Left -= 5;
                p.ballon.Refresh();
                if (p.ballon.Left < 100)
                {
                    problemList[i] = null;
                    problemList.Remove(problemList[i]);
                    this.Controls.Remove(p.ballon);
                    lifeSub();
                }
            }

            for (int i = 0; i < magicList.Count; ++i)
            {
                Magic m = (Magic)magicList[i];
                m.ballon.Left += 5;
                m.ballon.Refresh();
                if (m.ballon.Left > 720)
                {
                    magicList[i] = null;
                    magicList.Remove(magicList[i]);
                    this.Controls.Remove(m.ballon);
                }
            }

            animateCount++;

            if (animateCount == 2)
                horse.Image = Resource1.horse2;
            else if (animateCount == 4)
                horse.Image = Resource1.horse3;
            else if (animateCount == 6)
            {
                animateCount = 0;
                horse.Image = Resource1.horse1;
            }
        }

        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                gametime.Interval = upSpeed;
                ctrlIcon.Image = Resource1.ctrlPress;
            }
        }

        private void userInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                gametime.Interval = originalSpeed;
                ctrlIcon.Image = Resource1.ctrl;
            }
        }

        private void userInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                String text = userInput.Text;
                for (int i = 0; i < problemList.Count; ++i)
                {
                    Problem p = (Problem)problemList[i];
                    if (p.getQuestion().Equals(text))
                    {
                        userInput.Text = "";
                        this.Controls.Remove(p.ballon);
                        problemList.RemoveAt(i);
                        table[p.getWordIndex()].setCollect(true);

                        correctNum = correctNum + 1;
                        gameScore = gameScore + score;
                        if (correctNum < 50)
                            showNum.Text = correctNum + " \\ " + levelNum;
                        else
                            showNum.Text = correctNum + " \\ ";

                        showScore.Text = gameScore + " ";
                        level();

                        break;
                    }
                }

                for (int i = 0; i < magicList.Count; ++i)
                {
                    Magic m = (Magic)magicList[i];
                    if (m.ballon.Text.Equals(text))
                    {
                        m.ballon.Text = "";
                        userInput.Text = "";
                        this.Controls.Remove(m.ballon);
                        magicList.RemoveAt(i);

                        switch (m.mode)
                        {
                            case 1:
                                mode = 1;
                                originalSpeed += 125;
                                magicEffect.Enabled = true;
                                gametime.Interval = originalSpeed;
                                break;
                            case 2:
                                mode = 2;
                                for (int j = 0; j != problemList.Count;)
                                {
                                    Problem p = (Problem)problemList[j];

                                    this.Controls.Remove(p.ballon);
                                    problemList.RemoveAt(0);
                                    table[p.getWordIndex()].setCollect(true);
                                    

                                    gameScore = gameScore + score;
                                    showScore.Text = gameScore + " ";
                                }
                                break;
                            case 3:
                                mode = 3;
                                gametime.Enabled = false;
                                magicEffect.Enabled = true;
                                break;
                        }

                        break;
                    }
                }
            }
        }

        private void level()
        {
            if (correctNum == 10)
            {
                levelUp();
                levelNum = 25;
                showNum.Text = correctNum + " \\ " + levelNum;
                hero.Size = new Size(165, 243);
                hero.Image = Resource1.knight2;
            }
            else if (correctNum == 25)
            {
                levelNum = 50;
                hero.Size = new Size(200, 243);
                hero.Image = Resource1.knight3;
                boss.Image = Resource1.monster2;
                levelUp();
            }
            else if (correctNum == 50)
            {
                levelUp();
                showNum.Text = correctNum + " \\ ";
                hero.Size = new Size(165, 243);
                hero.Image = Resource1.knight4;
            }
        }

        private void levelUp()
        {
            levelUpIcon.Visible = true;
            animation.Enabled = true;
            showLevelIcon = true;

            gametime.Enabled = false;
            Magictime.Enabled = false;

            for (int i = 0; i < problemList.Count; ++i)
            {
                Problem p = (Problem)problemList[i];
                this.Controls.Remove(p.ballon);
                problemList[i] = null;
            }

            problemList.Clear();

            for (int i = 0; i < magicList.Count; ++i)
            {
                Magic m = (Magic)magicList[i];
                this.Controls.Remove(m.ballon);
                magicList[i] = null;
            }
            magicList.Clear();

            makeQuestionInterval -=  3;
            originalSpeed -= 5;
            gametime.Interval = originalSpeed;
            score += 150;
            life = 5;
            showLife.Image = Resource1.life_5;

            magicEffect.Enabled = false;
            magicInterval = 0;

            if (mode == 1)
            {
                originalSpeed -= 125;
                gametime.Interval = originalSpeed;
            }
            else if (mode == 3)
            {
                gametime.Enabled = true;
            }
            mode = 0;
        }

        private void Magictime_Tick(object sender, EventArgs e)
        {
            int temp = random.Next(100);
            if (temp > 50 && temp < 61)
            {
                //makeMagic(1);
                Magic p = new Magic(1);
                magicList.Add(p);
                this.Controls.Add(p.ballon);
            }
            else if (temp == 1 || temp == 2)
            {
                // makeMagic(2);
                Magic p = new Magic(2);
                magicList.Add(p);
                this.Controls.Add(p.ballon);
            }
            else if (temp > 94)
            {
                //makeMagic(3);
                Magic p = new Magic(3);
                magicList.Add(p);
                this.Controls.Add(p.ballon);
            }
        }

        private void pause_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPause == false)
                pause.BackgroundImage = Resource1.pauseOn;
            else
                pause.BackgroundImage = Resource1.startOn;
        }

        private void pause_MouseLeave(object sender, EventArgs e)
        {
            if (isPause == false)
                pause.BackgroundImage = Resource1.pause;
            else
                pause.BackgroundImage = Resource1.start;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (isPause == false)
            {
                isPause = true;
                gametime.Enabled = false;
                Magictime.Enabled = false;
                animation.Enabled = false;
            }
            else
            {
                isPause = false;
                gametime.Enabled = true;
                Magictime.Enabled = true;
                animation.Enabled = true;
            }
        }

        private void animation_Tick(object sender, EventArgs e)
        {
            if (showLevelIconTime == 0)
            {
                if (showLevelIcon == true)
                {
                    levelUpIcon.Visible = false;
                    showLevelIconTime = 4;
                }
                else
                {
                    gametime.Enabled = true;
                    Magictime.Enabled = true;
                    levelUpIcon.Visible = false;
                    animation.Enabled = false;
                    showLevelIconTime = 1;
                }
            }
            else if (showLevelIconTime == 4)
            {
                levelUpIcon.Visible = true;
                showLevelIcon = false;
                showLevelIconTime--;
            }
            else
                showLevelIconTime--;    
        }

        private void lifeSub()
        {
            life = life - 1;
            if (life == 0)
            {
                gameover.Visible = true;
                gametime.Enabled = false;
                Magictime.Enabled = false;
                animation.Enabled = false;

                StreamWriter sw = new StreamWriter(@"question\question.txt");
                for (int i = 0; i < questionNum; ++i)
                {
                    if (table[i].getCollect() == true)
                    {
                        sw.WriteLine("#" + table[i].getContent());
                    }
                    else
                        sw.WriteLine(table[i].getContent());
                    sw.Flush();
                }
                sw.Close();
            }
            switch (life)
            {
                case 0:
                    showLife.Image = Resource1.life_0;
                    break;
                case 1:
                    showLife.Image = Resource1.life_1;
                    break;
                case 2:
                    showLife.Image = Resource1.life_2;
                    break;
                case 3:
                    showLife.Image = Resource1.life_3;
                    break;
                case 4:
                    showLife.Image = Resource1.life_4;
                    break;
            }
                    

        }

        private void exit_Click(object sender, EventArgs e)
        {
            s.Dispose();
        }

        private void exit_MouseMove(object sender, MouseEventArgs e)
        {
            exit.BackgroundImage = Resource1.exit_select;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Resource1.exit;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.BackgroundImage = Resource1.back;
        }

        private void back_MouseMove(object sender, MouseEventArgs e)
        {
            back.BackgroundImage = Resource1.back_select;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void magicEffect_Tick(object sender, EventArgs e)
        {
            magicInterval = magicInterval + 1;
            if (magicInterval == 5)
            {
                magicEffect.Enabled = false;
                magicInterval = 0;

                if (mode == 1)
                {
                    originalSpeed -= 125;
                    gametime.Interval = originalSpeed;
                }
                else if (mode == 3)
                {
                    gametime.Enabled = true;
                }
                mode = 0;
            }
        }
    }

    public class Magic
    {
        /*道具的功能*/
        //public Label magic = new Label();//新增label使得道具產生
        public int mode = 0;
        public Label ballon = new Label();
        public Magic(int i)
        {
            mode = i;
            showMagic();
            ballon.Visible = true;
            ballon.Location = new System.Drawing.Point(0, 70);
            ballon.Font = new Font("Segoe Marker",1 , System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ballon.Width = 90;
            ballon.Height = 90;
            ballon.BackgroundImageLayout = ImageLayout.Zoom;
            ballon.BackColor = System.Drawing.Color.Transparent;

            ballon.BackColor =  System.Drawing.Color.Transparent;
        }

        public void showMagic()
        {
            if (mode == 1)
            {
                ballon.Text = "SLOW DOWN";//緩速
                ballon.BackgroundImage = Resource1.magic1;
            }
            else if (mode == 2)
            {
                ballon.Text = "DESTROY ALL";//炸彈
                ballon.BackgroundImage = Resource1.magic2;
            }
            else if (mode == 3)
            {
                ballon.Text = "TIME STOP";//石化
                ballon.BackgroundImage = Resource1.magic3;
;
            }
        }
    }

    //每一題都是一個problem 型態的物件
    public class Problem
    {
        Random random = new Random();
        private string Question = null;
        private int color = 0;
        public Panel ballon = new Panel();
        public Label ballonWord = new Label();
        private int wordIndex = 0;
        private Word content;
        

        public Problem(Word question)
        {
            content = question;
            Question = question.getContent();
            color = random.Next(5);

            ballonWord.Parent = ballon;
            ballonWord.Text = Question;
            ballonWord.AutoSize = false;
            ballonWord.Font = new Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ballonWord.ForeColor = Color.Black;
            ballonWord.TextAlign = ContentAlignment.MiddleCenter;
            ballonWord.Width = 90;
            ballonWord.Height = 90;

            ballon.Width = 90;
            ballon.Height = 90;
            ballon.BackgroundImage = Resource1.fireball;
            ballon.BackgroundImageLayout = ImageLayout.Zoom;
            ballon.BackColor = System.Drawing.Color.Transparent;
        }//隨機產生顏色，並設定題目內容字體

        public int getColor()
        {
            return color;
        }

        public string getQuestion()
        {
            return Question;
        }

        public void setWordIndex(int index)
        {
            wordIndex = index;
        }

        public int getWordIndex()
        {
            return wordIndex;
        }

        public void clear()
        {
            ballon.Text = "";
            content.setCollect(true);
        }

        public void move(int x, int y)
        {
            ballon.Location = new System.Drawing.Point(x, y);
        }//改變位置
    }

    //題庫中的每個單字都是一個word型別的物件
    public class Word
    {
        private string content = null;
        private bool collect = false;
        //content 是單字內容 collect為是否已經答對過，如果有就不會在出題

        public void setContent(string content)
        {
            this.content = content;
        }

        public string getContent()
        {
            return content;
        }

        public void setCollect(bool check)
        {
            this.collect = check;
        }

        public bool getCollect()
        {
            return collect;
        }
    }
}
