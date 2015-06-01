using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematico.Game
{
    public interface IGame
    {
        bool CanPlace {get; set; }

        #region Methods
        
        void ShowForm();
        void Start();
        void Stop();

        void Click(object button);


        #endregion
    }
}
