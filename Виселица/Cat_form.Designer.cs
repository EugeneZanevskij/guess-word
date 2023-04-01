
namespace Виселица
{
    partial class Cat_form
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
            this.buttonEurope = new System.Windows.Forms.Button();
            this.buttonAsia = new System.Windows.Forms.Button();
            this.buttonAmerica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEurope
            // 
            this.buttonEurope.Location = new System.Drawing.Point(114, 63);
            this.buttonEurope.Name = "buttonEurope";
            this.buttonEurope.Size = new System.Drawing.Size(149, 49);
            this.buttonEurope.TabIndex = 0;
            this.buttonEurope.Text = "Europe";
            this.buttonEurope.UseVisualStyleBackColor = true;
            this.buttonEurope.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // buttonAsia
            // 
            this.buttonAsia.Location = new System.Drawing.Point(114, 154);
            this.buttonAsia.Name = "buttonAsia";
            this.buttonAsia.Size = new System.Drawing.Size(149, 49);
            this.buttonAsia.TabIndex = 1;
            this.buttonAsia.Text = "Asia";
            this.buttonAsia.UseVisualStyleBackColor = true;
            this.buttonAsia.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // buttonAmerica
            // 
            this.buttonAmerica.Location = new System.Drawing.Point(114, 245);
            this.buttonAmerica.Name = "buttonAmerica";
            this.buttonAmerica.Size = new System.Drawing.Size(149, 49);
            this.buttonAmerica.TabIndex = 2;
            this.buttonAmerica.Text = "America";
            this.buttonAmerica.UseVisualStyleBackColor = true;
            this.buttonAmerica.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // Cat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAmerica);
            this.Controls.Add(this.buttonAsia);
            this.Controls.Add(this.buttonEurope);
            this.Name = "Cat_form";
            this.Text = "Категория";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEurope;
        private System.Windows.Forms.Button buttonAsia;
        private System.Windows.Forms.Button buttonAmerica;
    }
}