using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Виселица
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(Properties.Resources.visel);
            this.Size = new Size(780, 475);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        void ButtonGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_form form = new Player_form();
            form.ShowDialog();
            this.Visible = true;
        }
        void ButtonExit_Click(object sender, EventArgs e)
        {
                this.Close();//выход из программы
        }
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра заключается в том, что загадывается слово, а игрок угадывает буквы и все слово целиком " +
            "(загаданное слово является именем существительным единственного числа, либо множественного числа)." +
            "\nВсего у игрока имеется 5 попыток." +
            "\nЕсли игрок выбирает неверную букву, то количество попыток уменьшается." +
            "\nКогда изображение нарисовано полностью, то игрок проигрывает. Если игроку удаётся угадать слово, он выигрывает.");
        }
    }
}
    