using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puissancequatre
{
    public interface IGameState
    {
        public void CheckVictory(int[,] grille, int numJoueur, int nbCoupsVictoire);
    }
}
