namespace TypeGame
{
    partial class form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.userInput = new System.Windows.Forms.TextBox();
            this.showNum = new System.Windows.Forms.Label();
            this.showScore = new System.Windows.Forms.Label();
            this.Magictime = new System.Windows.Forms.Timer(this.components);
            this.levelUpIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.levelWord = new System.Windows.Forms.Label();
            this.animation = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.ctrlIcon = new System.Windows.Forms.PictureBox();
            this.horse = new System.Windows.Forms.PictureBox();
            this.boss = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.shield = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.gameoverWord = new System.Windows.Forms.Label();
            this.showLife = new System.Windows.Forms.PictureBox();
            this.magicEffect = new System.Windows.Forms.Timer(this.components);
            this.levelUpIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.gameover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showLife)).BeginInit();
            this.SuspendLayout();
            // 
            // gametime
            // 
            this.gametime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userInput
            // 
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(270, 331);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(173, 32);
            this.userInput.TabIndex = 0;
            this.userInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyDown);
            this.userInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userInput_KeyPress);
            this.userInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyUp);
            // 
            // showNum
            // 
            this.showNum.AutoSize = true;
            this.showNum.BackColor = System.Drawing.Color.Transparent;
            this.showNum.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNum.ForeColor = System.Drawing.Color.DarkRed;
            this.showNum.Location = new System.Drawing.Point(443, 23);
            this.showNum.Name = "showNum";
            this.showNum.Size = new System.Drawing.Size(0, 43);
            this.showNum.TabIndex = 1;
            // 
            // showScore
            // 
            this.showScore.AutoSize = true;
            this.showScore.BackColor = System.Drawing.Color.Transparent;
            this.showScore.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showScore.ForeColor = System.Drawing.Color.DarkRed;
            this.showScore.Location = new System.Drawing.Point(175, 23);
            this.showScore.Name = "showScore";
            this.showScore.Size = new System.Drawing.Size(0, 43);
            this.showScore.TabIndex = 2;
            // 
            // Magictime
            // 
            this.Magictime.Interval = 1000;
            this.Magictime.Tick += new System.EventHandler(this.Magictime_Tick);
            // 
            // levelUpIcon
            // 
            this.levelUpIcon.BackColor = System.Drawing.Color.Transparent;
            this.levelUpIcon.Controls.Add(this.pictureBox1);
            this.levelUpIcon.Controls.Add(this.levelWord);
            this.levelUpIcon.Location = new System.Drawing.Point(169, 97);
            this.levelUpIcon.Name = "levelUpIcon";
            this.levelUpIcon.Size = new System.Drawing.Size(413, 168);
            this.levelUpIcon.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TypeGame.Resource1.dragon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // levelWord
            // 
            this.levelWord.AutoSize = true;
            this.levelWord.Font = new System.Drawing.Font("Segoe Marker", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelWord.ForeColor = System.Drawing.Color.Brown;
            this.levelWord.Location = new System.Drawing.Point(139, 62);
            this.levelWord.Name = "levelWord";
            this.levelWord.Size = new System.Drawing.Size(268, 78);
            this.levelWord.TabIndex = 7;
            this.levelWord.Text = "LEVEL UP";
            this.levelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animation
            // 
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.BackgroundImage = global::TypeGame.Resource1.pause;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.FlatAppearance.BorderSize = 0;
            this.pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.ForeColor = System.Drawing.Color.Transparent;
            this.pause.Location = new System.Drawing.Point(697, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(48, 48);
            this.pause.TabIndex = 4;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            this.pause.MouseLeave += new System.EventHandler(this.pause_MouseLeave);
            this.pause.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pause_MouseMove);
            // 
            // ctrlIcon
            // 
            this.ctrlIcon.BackColor = System.Drawing.Color.Transparent;
            this.ctrlIcon.Image = ((System.Drawing.Image)(resources.GetObject("ctrlIcon.Image")));
            this.ctrlIcon.Location = new System.Drawing.Point(21, 56);
            this.ctrlIcon.Name = "ctrlIcon";
            this.ctrlIcon.Size = new System.Drawing.Size(56, 39);
            this.ctrlIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctrlIcon.TabIndex = 3;
            this.ctrlIcon.TabStop = false;
            // 
            // horse
            // 
            this.horse.BackColor = System.Drawing.Color.Transparent;
            this.horse.Image = global::TypeGame.Resource1.horse1;
            this.horse.Location = new System.Drawing.Point(12, 1);
            this.horse.Name = "horse";
            this.horse.Size = new System.Drawing.Size(83, 65);
            this.horse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse.TabIndex = 9;
            this.horse.TabStop = false;
            // 
            // boss
            // 
            this.boss.BackColor = System.Drawing.Color.Transparent;
            this.boss.Image = ((System.Drawing.Image)(resources.GetObject("boss.Image")));
            this.boss.Location = new System.Drawing.Point(588, 63);
            this.boss.Name = "boss";
            this.boss.Size = new System.Drawing.Size(267, 277);
            this.boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss.TabIndex = 10;
            this.boss.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(224, 323);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(40, 50);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 11;
            this.sword.TabStop = false;
            // 
            // shield
            // 
            this.shield.BackColor = System.Drawing.Color.Transparent;
            this.shield.Image = ((System.Drawing.Image)(resources.GetObject("shield.Image")));
            this.shield.Location = new System.Drawing.Point(450, 323);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(40, 50);
            this.shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shield.TabIndex = 12;
            this.shield.TabStop = false;
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            this.hero.Image = ((System.Drawing.Image)(resources.GetObject("hero.Image")));
            this.hero.Location = new System.Drawing.Point(-7, 97);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(134, 243);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hero.TabIndex = 13;
            this.hero.TabStop = false;
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameover.Controls.Add(this.back);
            this.gameover.Controls.Add(this.exit);
            this.gameover.Controls.Add(this.gameoverWord);
            this.gameover.Location = new System.Drawing.Point(115, 100);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(504, 184);
            this.gameover.TabIndex = 9;
            this.gameover.Visible = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::TypeGame.Resource1.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(134, 115);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(54, 57);
            this.back.TabIndex = 10;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            this.back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_MouseMove);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(309, 115);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 57);
            this.exit.TabIndex = 9;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_MouseMove);
            // 
            // gameoverWord
            // 
            this.gameoverWord.AutoSize = true;
            this.gameoverWord.Font = new System.Drawing.Font("Segoe Marker", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverWord.ForeColor = System.Drawing.Color.Brown;
            this.gameoverWord.Location = new System.Drawing.Point(45, 7);
            this.gameoverWord.Name = "gameoverWord";
            this.gameoverWord.Size = new System.Drawing.Size(403, 93);
            this.gameoverWord.TabIndex = 8;
            this.gameoverWord.Text = "GAME OVER";
            this.gameoverWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showLife
            // 
            this.showLife.BackColor = System.Drawing.Color.Transparent;
            this.showLife.Image = global::TypeGame.Resource1.life_5;
            this.showLife.Location = new System.Drawing.Point(115, 313);
            this.showLife.Name = "showLife";
            this.showLife.Size = new System.Drawing.Size(73, 67);
            this.showLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showLife.TabIndex = 14;
            this.showLife.TabStop = false;
            // 
            // magicEffect
            // 
            this.magicEffect.Tick += new System.EventHandler(this.magicEffect_Tick);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::TypeGame.Resource1.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 392);
            this.Controls.Add(this.showLife);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.ctrlIcon);
            this.Controls.Add(this.horse);
            this.Controls.Add(this.showScore);
            this.Controls.Add(this.shield);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.levelUpIcon);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.showNum);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.boss);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Palapala_Typing_King";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.levelUpIcon.ResumeLayout(false);
            this.levelUpIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.gameover.ResumeLayout(false);
            this.gameover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showLife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label showNum;
        private System.Windows.Forms.Label showScore;
        private System.Windows.Forms.PictureBox ctrlIcon;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Timer Magictime;
        private System.Windows.Forms.Panel levelUpIcon;
        private System.Windows.Forms.Timer animation;
        private System.Windows.Forms.PictureBox horse;
        private System.Windows.Forms.PictureBox boss;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox shield;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label levelWord;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Panel gameover;
        private System.Windows.Forms.Label gameoverWord;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox showLife;
        private System.Windows.Forms.Timer magicEffect;


    }
}

