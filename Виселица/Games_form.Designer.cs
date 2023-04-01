
namespace Виселица
{
    partial class Games_Form
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
            this.Image = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.GuessedLetters = new System.Windows.Forms.ListBox();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(268, 25);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(260, 216);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 9;
            this.Image.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(595, 182);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(106, 50);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Продолжить игру";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // GuessedLetters
            // 
            this.GuessedLetters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuessedLetters.FormattingEnabled = true;
            this.GuessedLetters.ItemHeight = 28;
            this.GuessedLetters.Location = new System.Drawing.Point(72, 25);
            this.GuessedLetters.Name = "GuessedLetters";
            this.GuessedLetters.Size = new System.Drawing.Size(63, 144);
            this.GuessedLetters.TabIndex = 7;
            // 
            // lblShowWord
            // 
            this.lblShowWord.AutoSize = true;
            this.lblShowWord.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowWord.Location = new System.Drawing.Point(344, 235);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(83, 32);
            this.lblShowWord.TabIndex = 6;
            this.lblShowWord.Text = "Слово";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(595, 109);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 48);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Закончить игру";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(35, 212);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 12;
            this.label.Text = "Буква";
            // 
            // Games_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.GuessedLetters);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.btnStop);
            this.Name = "Games_Form";
            this.Text = "Игра";
            this.Load += new System.EventHandler(this.Games_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListBox GuessedLetters;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
    }
}