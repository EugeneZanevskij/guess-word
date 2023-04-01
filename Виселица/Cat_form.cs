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
    public partial class Cat_form : Form
    {
        string playerName;
        public Cat_form(string name)
        {
            InitializeComponent();
            playerName = name;

            this.BackgroundImage = new Bitmap(Properties.Resources.tetradnii_list_v_kletku_fon_2);
            this.Size = new Size(780, 475);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string catName = button.Text;
            this.Hide();
            Games_Form game = new Games_Form(playerName, catName);
            game.ShowDialog();
            this.Close();
        }
    }
}
