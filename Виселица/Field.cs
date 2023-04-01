using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Виселица
{
    public class Field
    {
        public Game Game { set; get; }

        public Field(Game game)
        {
            this.Game = game;
            Refresh();
        }

        public void Refresh()
        {
            GameControls.Refresh(this);
        }
        
    }
}
