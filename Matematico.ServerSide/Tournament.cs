using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Matematico.Game;
using Matematico.ServerSide.Forms;
using Matematico.Tournaments;

namespace Matematico.ServerSide
{
    public class Tournament
    {
        LanGame Game;

        private List<string> users;
        public List<string> Users
        {
            get
            {
                if (users == null) users = new List<string>();
                return users;
            }
            set { users = value; }
        }

        public Round[] Rounds;
        
        public int ARound;

        public Tournament(int points)
        {
            Rounds = new Round[3];
            
            Rounds[0] = new Round(GameType.Maximum);
            Rounds[1] = new Round(GameType.Minimum);
            Rounds[2] = new Round(GameType.Exactly, points);

            ARound = 1;

            ExcelParser parser = new ExcelParser();

            parser.CreateHeader("turnaj1");
            parser.WriteNames(new string[2] { "adam", "david" });
        }

        public void Start()
        {
            Game = new LanGame(Rounds[ARound].Type);
        }

        public void Stop(GameResult result)
        {
            Rounds[ARound].Result = result;
        }

        private void StartRound(int round)
        {

        }
    }
}
