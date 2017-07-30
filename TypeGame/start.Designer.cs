namespace TypeGame
{
    partial class start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.storyTime = new System.Windows.Forms.Timer(this.components);
            this.startPage = new System.Windows.Forms.Panel();
            this.animate = new System.Windows.Forms.Panel();
            this.story = new System.Windows.Forms.PictureBox();
            this.attack4 = new System.Windows.Forms.PictureBox();
            this.attack3 = new System.Windows.Forms.PictureBox();
            this.attack2 = new System.Windows.Forms.PictureBox();
            this.attack1 = new System.Windows.Forms.PictureBox();
            this.book = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.gameStart = new System.Windows.Forms.Button();
            this.startPage.SuspendLayout();
            this.animate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.story)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack1)).BeginInit();
            this.SuspendLayout();
            // 
            // storyTime
            // 
            this.storyTime.Interval = 3000;
            this.storyTime.Tick += new System.EventHandler(this.storyTime_Tick);
            // 
            // startPage
            // 
            this.startPage.BackgroundImage = global::TypeGame.Resource1.start_background;
            this.startPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startPage.Controls.Add(this.animate);
            this.startPage.Controls.Add(this.book);
            this.startPage.Controls.Add(this.exit);
            this.startPage.Controls.Add(this.gameStart);
            this.startPage.Location = new System.Drawing.Point(-2, 0);
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(595, 436);
            this.startPage.TabIndex = 5;
            // 
            // animate
            // 
            this.animate.Controls.Add(this.story);
            this.animate.Controls.Add(this.attack4);
            this.animate.Controls.Add(this.attack3);
            this.animate.Controls.Add(this.attack2);
            this.animate.Controls.Add(this.attack1);
            this.animate.Location = new System.Drawing.Point(2, -1);
            this.animate.Name = "animate";
            this.animate.Size = new System.Drawing.Size(592, 433);
            this.animate.TabIndex = 5;
            // 
            // story
            // 
            this.story.Image = global::TypeGame.Resource1.story1;
            this.story.Location = new System.Drawing.Point(-3, 0);
            this.story.Name = "story";
            this.story.Size = new System.Drawing.Size(591, 429);
            this.story.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.story.TabIndex = 4;
            this.story.TabStop = false;
            // 
            // attack4
            // 
            this.attack4.Image = global::TypeGame.Resource1.attack4;
            this.attack4.Location = new System.Drawing.Point(83, 53);
            this.attack4.Name = "attack4";
            this.attack4.Size = new System.Drawing.Size(427, 319);
            this.attack4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attack4.TabIndex = 3;
            this.attack4.TabStop = false;
            // 
            // attack3
            // 
            this.attack3.Image = global::TypeGame.Resource1.attack3;
            this.attack3.Location = new System.Drawing.Point(-3, 14);
            this.attack3.Name = "attack3";
            this.attack3.Size = new System.Drawing.Size(237, 292);
            this.attack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attack3.TabIndex = 2;
            this.attack3.TabStop = false;
            // 
            // attack2
            // 
            this.attack2.Image = global::TypeGame.Resource1.attack2;
            this.attack2.Location = new System.Drawing.Point(199, 34);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(390, 292);
            this.attack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attack2.TabIndex = 1;
            this.attack2.TabStop = false;
            // 
            // attack1
            // 
            this.attack1.Image = global::TypeGame.Resource1.attach1;
            this.attack1.Location = new System.Drawing.Point(-3, 96);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(390, 292);
            this.attack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attack1.TabIndex = 0;
            this.attack1.TabStop = false;
            // 
            // book
            // 
            this.book.AutoSize = true;
            this.book.BackColor = System.Drawing.Color.Transparent;
            this.book.BackgroundImage = global::TypeGame.Resource1.book;
            this.book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book.FlatAppearance.BorderSize = 0;
            this.book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.Transparent;
            this.book.Location = new System.Drawing.Point(537, 14);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(38, 54);
            this.book.TabIndex = 3;
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            this.book.MouseLeave += new System.EventHandler(this.book_MouseLeave);
            this.book.MouseMove += new System.Windows.Forms.MouseEventHandler(this.book_MouseMove);
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
            this.exit.Location = new System.Drawing.Point(392, 283);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 105);
            this.exit.TabIndex = 4;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_MouseMove);
            // 
            // gameStart
            // 
            this.gameStart.AutoSize = true;
            this.gameStart.BackColor = System.Drawing.Color.Transparent;
            this.gameStart.BackgroundImage = global::TypeGame.Resource1.startgame;
            this.gameStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameStart.FlatAppearance.BorderSize = 0;
            this.gameStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gameStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameStart.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStart.ForeColor = System.Drawing.Color.Transparent;
            this.gameStart.Location = new System.Drawing.Point(105, 283);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(103, 105);
            this.gameStart.TabIndex = 1;
            this.gameStart.UseVisualStyleBackColor = false;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            this.gameStart.MouseLeave += new System.EventHandler(this.gameStart_MouseLeave);
            this.gameStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gameStart_MouseMove);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 422);
            this.Controls.Add(this.startPage);
            this.MaximizeBox = false;
            this.Name = "start";
            this.Text = "start";
            this.Load += new System.EventHandler(this.start_Load);
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.animate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.story)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gameStart;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel startPage;
        private System.Windows.Forms.Panel animate;
        private System.Windows.Forms.PictureBox attack1;
        private System.Windows.Forms.PictureBox attack4;
        private System.Windows.Forms.PictureBox attack3;
        private System.Windows.Forms.PictureBox attack2;
        private System.Windows.Forms.Timer storyTime;
        private System.Windows.Forms.PictureBox story;
    }
}