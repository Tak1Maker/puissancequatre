namespace puissancequatre
{
    public class GameState : IGameState
    {
        public void CheckVictory(int[,] grille, int numJoueur, int nbCoupsVictoire)
        {
            if (
                VictoireVerticale(grille, numJoueur, nbCoupsVictoire) ||
                VictoireDiagonaleDroiteGauche(grille, numJoueur, nbCoupsVictoire) ||
                VictoireDiagonaleGaucheDroite(grille, numJoueur, nbCoupsVictoire) ||
                VictoireHorizontale(grille, numJoueur, nbCoupsVictoire))
            {
                Console.WriteLine("Victory");
            }
        }
        static bool VictoireVerticale(int[,] grille, int numJoueur, int nbCoupsVictoire)
        {
            bool victoireVerticale = false;
            for (int i = grille.GetLength(0) - 1; i >= (nbCoupsVictoire - 1); --i)
            {
                for (int j = 0; j < grille.GetLength(1); ++j)
                {
                    bool testVertical = TestVertical(grille, i, j, numJoueur, nbCoupsVictoire);
                    if (testVertical)
                    {
                        victoireVerticale = true;
                    }
                }
            }
            return victoireVerticale;
        }//VictoireVerticale()

        static bool VictoireDiagonaleDroiteGauche(int[,] grille, int numJoueur, int nbCoupsVictoire)
        {
            bool victoireDiagonaleDroiteGauche = false;
            for (int i = grille.GetLength(0) - 1; i >= (nbCoupsVictoire - 1); --i)
            {
                for (int j = grille.GetLength(1) - 1; j >= (nbCoupsVictoire - 1); --j)
                {
                    bool testDiagoDroiteGauche = TestDiagoDroiteGauche(grille, i, j, numJoueur, nbCoupsVictoire);
                    if (testDiagoDroiteGauche)
                    {
                        victoireDiagonaleDroiteGauche = true;
                    }
                }
            }
            return victoireDiagonaleDroiteGauche;
        }//VictoireDiagonaleDroiteGauche()


        static bool VictoireDiagonaleGaucheDroite(int[,] grille, int numJoueur, int nbCoupsVictoire)
        {
            bool victoireDiagonaleGaucheDroite = false;
            for (int i = grille.GetLength(0) - 1; i >= (nbCoupsVictoire - 1); --i)
            {
                for (int j = 0; j < grille.GetLength(1) - (nbCoupsVictoire - 1); ++j)
                {
                    bool testDiagoGaucheDroite = TestDiagoGaucheDroite(grille, i, j, numJoueur, nbCoupsVictoire);
                    if (testDiagoGaucheDroite)
                    {
                        victoireDiagonaleGaucheDroite = true;
                    }
                }
            }
            return victoireDiagonaleGaucheDroite;
        }//VictoireDiagonaleGaucheDroite()

        static bool VictoireHorizontale(int[,] grille, int numJoueur, int nbCoupsVictoire)
        {
            bool victoireHorizontale = false;
            for (int i = grille.GetLength(0) - 1; i >= 0; --i)
            {
                for (int j = 0; j < grille.GetLength(1) - (nbCoupsVictoire - 1); ++j)
                {
                    bool testHorizontal = TestHorizontales(grille, i, j, numJoueur, nbCoupsVictoire);
                    if (testHorizontal)
                    {
                        victoireHorizontale = true;
                    }
                }
            }
            return victoireHorizontale;
        }//VictoireHorizontale()
        static bool TestHorizontales(int[,] grille, int ligne, int colonne, int noJoueur, int nbCoupsPourGagner)
        {
            bool test = false;
            int compteur = 0;
            for (int i = 0; i < nbCoupsPourGagner; ++i)
            {
                if (grille[ligne, colonne] == noJoueur && grille[ligne, colonne + i] == noJoueur)
                {
                    ++compteur;
                }
            }
            if (compteur == nbCoupsPourGagner)
            {
                test = true;
            }
            return test;
        }//TestHorizontales()


        static bool TestVertical(int[,] grille, int ligne, int colonne, int noJoueur, int nbCoupsPourGagner)
        {
            bool test = false;
            int compteur = 0;
            for (int i = 0; i < nbCoupsPourGagner; ++i)
            {
                if (grille[ligne, colonne] == noJoueur && grille[ligne - i, colonne] == noJoueur)
                {
                    ++compteur;
                }
            }
            if (compteur == nbCoupsPourGagner)
            {
                test = true;
            }
            return test;
        }//TestVertical()

        static bool TestDiagoGaucheDroite(int[,] grille, int ligne, int colonne, int noJoueur, int nbCoupsPourGagner)
        {
            bool test = false;
            int compteur = 0;
            for (int i = 0; i < nbCoupsPourGagner; ++i)
            {
                if (grille[ligne, colonne] == noJoueur && grille[ligne - i, colonne + i] == noJoueur)
                {
                    ++compteur;
                }
            }
            if (compteur == nbCoupsPourGagner)
            {
                test = true;
            }
            return test;
        }//TestDiagoGaucheDroite()


        static bool TestDiagoDroiteGauche(int[,] grille, int ligne, int colonne, int noJoueur, int nbCoupsPourGagner)
        {
            bool test = false;
            int compteur = 0;
            for (int i = 0; i < nbCoupsPourGagner; ++i)
            {
                if (grille[ligne, colonne] == noJoueur && grille[ligne - i, colonne - i] == noJoueur)
                {
                    ++compteur;
                }
            }
            if (compteur == nbCoupsPourGagner)
            {
                test = true;
            }
            return test;
        }//TestDiagoDroiteGauche()
    }
}
