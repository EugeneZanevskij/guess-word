using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Виселица
{
    [Serializable]
    public class Player
    {
        public string Name { get; set; }
        public int Tries { get; set; }
        public int Wins { get; set; }


        public Player()
        {
        }
        public Player(string playerName)
        {
            this.Name = playerName;
            this.Tries = 0;
            this.Wins = 0;
        }

        public char Turn()
        {
            return ReadLetter();
        }

        private char ReadLetter()
        {
            return GameControls.ReadLetter();
        }
    }
}
