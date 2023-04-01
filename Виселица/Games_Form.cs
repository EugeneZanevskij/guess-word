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
    public partial class Games_Form : Form
    {
        Game game;
        Field field;
        List<Player> allPlayers = new List<Player>();

        public Games_Form(string name, string catName)
        {
            InitializeComponent();

            //при создании формы для отображения игры создается сама игра и поле для нее
            game = new Game(name,catName);
            allPlayers = FileForPlayers.DeSerializeXML();
            this.BackgroundImage = new Bitmap(Properties.Resources.tetradnii_list_v_kletku_fon_2);
            
            this.BackgroundImageLayout = ImageLayout.Stretch;

            GameControls.Init(label, lblShowWord, GuessedLetters, Image);
            field = new Field(game);
            string str = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";//строковая перем. с алфавитом
            int posX = 40, posY = 300;//начальные позиции первой строки букв
            for (int i = 0; i < str.Count(); i++)//создание цикла
            {
                Button button = new Button();//метод создания новой кнопки
                button.BackColor = System.Drawing.SystemColors.Info;//цвет кнопки
                button.Text = str[i] + "";//присваивает значение след.буквы
                button.Location = new System.Drawing.Point(posX, posY);//рисование кнопки
                button.Size = new System.Drawing.Size(80, 40);//задание размера кнопки
                this.Controls.Add(button); //добавление кнопки
                posX += button.Width;//ширина кнопки
                if ((i + 1) % 8 == 0)
                {
                    posX = 40;
                    posY += button.Height; //высота кнопки
                    //
                }
                button.Click += new System.EventHandler(this.btnRun_Click);
                
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            Button sendingButton = (Button)sender;

            label.Text = sendingButton.Text;
            switch (game.run())
            {
                case 0:
                    string result = $"{game.Player.Name}, Вы близки к победе!!! Осталось {5-game.WrongGuesses} попыток";
                    label1.Text = result;
                    field.Refresh();
                    break;
                case 1:
                    game.Player.Wins++;
                    UpdateList(game.Player);
                    field.Refresh();
                    MessageBox.Show($"{game.Player.Name}, You won! \n Congratulations! \n Word is: {game.Word.Value}");
                    WriteToXML(allPlayers); 
                    break;
                case -1:
                    field.Refresh();
                    MessageBox.Show($"Word was: {game.Word.Value} \n You lose!");
                    UpdateList(game.Player);
                    WriteToXML(allPlayers);
                    break;
            }
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //очищаются все подписи
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Text = "";
                }
            }
            //создается новая игра
            game = new Game(game.Player.Name, game.Word.Category);

            field = new Field(game);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();//выход из программы
        }
        private void Games_Form_Load(object sender, EventArgs e)
        {

        }
       
        void WriteToXML(List<Player> players)
        {
            FileForPlayers.SerializeXML(players);
        }
        void UpdateList(Player player)
        {
            foreach (Player pl in allPlayers)
            {
                if (pl.Name == player.Name )
                {
                    pl.Tries += player.Tries;
                    pl.Wins += player.Wins;
                    return;
                }
            }
            allPlayers.Add(player);
        }
    }
}
