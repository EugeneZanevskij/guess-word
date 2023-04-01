using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Виселица
{
    class GameControls
    {
        static Label WordControl { set; get; }
        static ListBox UsedLettersControl { set; get; }
        static Label LetterControl { set; get; }
        static PictureBox PictureControl { set; get; }

        public static void Refresh(Field field)
        {
                WordControl.Text = field.Game.Word.Mask.ToString();
                UsedLettersControl.Items.Clear();
                for (int i = 0; i < field.Game.guessedChars.Count; i++)
                UsedLettersControl.Items.Add(field.Game.guessedChars[i]);
                switch (field.Game.Word.Category)
                {
                    case "Europe":
                        PictureControl.Image = EuropeImages[field.Game.WrongGuesses];
                        break;
                    case "Asia":
                        PictureControl.Image = AsiaImages[field.Game.WrongGuesses];
                        break;
                    case "America":
                        PictureControl.Image = AmericaImages[field.Game.WrongGuesses];
                        break;
                }
        }

        static public char ReadLetter()
        {
            if (LetterControl != null && LetterControl.Text.Trim().Length > 0)
                return LetterControl.Text[0];
            else
                throw new Exception("smth wrong");
        }
        static Bitmap[] EuropeImages = { Properties.Resources.Flower0, Properties.Resources.Flower1, Properties.Resources.Flower2,
                                          Properties.Resources.Flower3, Properties.Resources.Flower4, Properties.Resources.Flower5};
        static Bitmap[] AsiaImages = { Properties.Resources.Moon0, Properties.Resources.Moon1, Properties.Resources.Moon2,
                                          Properties.Resources.Moon3, Properties.Resources.Moon4, Properties.Resources.Moon5};
        static Bitmap[] AmericaImages = { Properties.Resources.building5, Properties.Resources.building4, Properties.Resources.building3,
                                          Properties.Resources.building2, Properties.Resources.building1, Properties.Resources.building0};
        static public void Init(Label letterControl, Label wordControl, ListBox usedLettersControl, PictureBox pictureControl)
            //(ListBox letterControl,ListBox usedLettersControl, Button letterControl, Label wordMaskControl, PictureBox PictureControl = null)
        {
            SetWordControl(wordControl);
            SetUsedLettersControl(usedLettersControl);
            SetLetterControl(letterControl);
            SetPictureControl(pictureControl);
        }
        private static void SetWordControl(Label wordControl)
        {
            WordControl = wordControl;
        }
        private static void SetUsedLettersControl(ListBox usedLettersControl)
        {
            UsedLettersControl = usedLettersControl;
        }


        static private void SetLetterControl(Label letterControl)
        {
            LetterControl = letterControl;
        }
        static private void SetPictureControl(PictureBox pictureControl)
        {
            PictureControl = pictureControl;
        }
       
    }
}
