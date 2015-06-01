using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematico.Game
{
    public class GameResult
    {
        private List<PlayerResult> players;
        public List<PlayerResult> Players
        {
            get
            {
                if (players == null) players = new List<PlayerResult>();
                return players;
            }
            set
            {
                players = value;
            }
        }
    }
}
