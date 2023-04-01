
namespace Виселица
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGame = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGame
            // 
            this.buttonGame.BackColor = System.Drawing.SystemColors.Info;
            this.buttonGame.Location = new System.Drawing.Point(43, 41);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(145, 55);
            this.buttonGame.TabIndex = 0;
            this.buttonGame.Text = "Начать игру";
            this.buttonGame.UseVisualStyleBackColor = false;
            this.buttonGame.Click += new System.EventHandler(this.ButtonGame_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(43, 119);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(145, 57);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(43, 196);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 63);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonGame);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonExit;
    }
}

