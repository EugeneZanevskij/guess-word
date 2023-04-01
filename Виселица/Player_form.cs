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
    public partial class Player_form : Form
    {
        public Player_form()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(Properties.Resources.tetradnii_list_v_kletku_fon_2);
            this.Size = new Size(780, 475);
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = textBox_Name.Text;
            this.Hide();
            Cat_form cat_Form = new Cat_form(playerName);
            cat_Form.ShowDialog();
            this.Close();
        }
    }
}
