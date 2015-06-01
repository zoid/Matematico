using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Matematico.Game;

namespace Matematico.Tournaments
{
    public class Tournament
    {
        private List<string> users;
        public List<string> Users
        {
            get
            {
                if (users == null) users = new List<string>();
                return users;
            }
            set
            {
                users = value;
            }
        }


        public Round FirstRound;
        public Round SecondRound;
        public Round ThirdRound;

        public Tournament()
        {
            FirstRound = new Round(GameType.Maximum);
            SecondRound = new Round(GameType.Minimum);
            ThirdRound = new Round(GameType.Exactly);
        }
    }
}
