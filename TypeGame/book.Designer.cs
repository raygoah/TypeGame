namespace TypeGame
{
    partial class book
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
            this.wordTable = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // wordTable
            // 
            this.wordTable.BackColor = System.Drawing.SystemColors.Info;
            this.wordTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordTable.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTable.FormattingEnabled = true;
            this.wordTable.ItemHeight = 18;
            this.wordTable.Location = new System.Drawing.Point(36, 33);
            this.wordTable.Name = "wordTable";
            this.wordTable.Size = new System.Drawing.Size(360, 308);
            this.wordTable.TabIndex = 0;
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 389);
            this.Controls.Add(this.wordTable);
            this.Name = "book";
            this.Text = "book";
            this.Load += new System.EventHandler(this.book_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox wordTable;


    }
}