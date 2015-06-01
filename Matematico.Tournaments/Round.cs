using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Matematico.Game;

namespace Matematico.Tournaments
{
    class Round
    {
        public GameType Type;
        public bool Finished;

        public GameResult Result;

        public Round(GameType type)
        {
            Type = type;
            Finished = false;
        }


        public void Start()
        {
            
        }

    }
}
