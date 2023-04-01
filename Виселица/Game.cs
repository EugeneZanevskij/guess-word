using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Виселица
{
    public class Game
    {
        public Player Player { get; set; }
        public Word Word { get; set; }
        public int WrongGuesses { get; private set; }
        public List<char> guessedChars { get; set; }
        public List<Player> Players = new List<Player>();


        public Game(string player, string catName)
        {
            Player = new Player(player);     
            Player.Tries++;
            Word = new Word(catName);
            guessedChars = new List<char>();
            WrongGuesses = 0;
        }

        public int run()
        {
            char playerLetter = Player.Turn();

            if (!Word.ContainsLetter(playerLetter))// нет такой буквы в слове
            {
                WrongGuesses++;
                guessedChars.Add(playerLetter);
            }
            else
            {
                Word.Update(playerLetter);
            }
            Word.Update(playerLetter);
            if (WrongGuesses >= 5) return -1;//закончились попытки
            if (this.Word.WordLettersLeft.Length == 0) return 1;//отгадано слово
            return (0);//игра продолжается
        }


    }
}
