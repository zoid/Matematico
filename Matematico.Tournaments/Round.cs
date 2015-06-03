using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Matematico.Game;

namespace Matematico.Tournaments
{
    public class Round
    {
        public GameType Type;
        public bool Finished;
        public int Points;

        public GameResult Result;

        public Round(GameType type)
        {
            Type = type;
            Finished = false;
        }

        public Round(GameType type, int points)
        {
            Type = type;
            Points = points;
            Finished = false;
        }


        public void Start()
        {
            
        }

    }
}
