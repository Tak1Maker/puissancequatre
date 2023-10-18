static int TestValiditeDuTypeDeLaSaisie()
{
    int r;
    while (!int.TryParse(Console.ReadLine(), out r))
    {
        Console.WriteLine("Veuillez saisir un entier!");
    }
    return r;
}//TestValiditeDuTypeDeLaSaisie()

static int NombreCoupsPourGagner()
{
    int nombre = 0;
    do
    {
        Console.Write("Veuillez saisir le nombre de pion à aligner pour gagner: \n(nombre >= 3) : ");
        nombre = TestValiditeDuTypeDeLaSaisie();
    } while (nombre < 3);
    return nombre;
}//NombreCoupsPourGagner()

static int[,] CreationGrille(int nbCoupsVictoire)
{
    Console.WriteLine("Création de la grille:");
    Console.WriteLine();
    int ligne = 0;
    int colonne = 0;
    do
    {
        Console.Write("Veuillez saisir le nombre de ligne \n(nombre >=" + nbCoupsVictoire + ") : ");
        ligne = TestValiditeDuTypeDeLaSaisie();

        Console.WriteLine();

        Console.Write("Veuillez saisir le nombre de colonne \n(nombre >= " + nbCoupsVictoire + "): ");
        colonne = TestValiditeDuTypeDeLaSaisie();

        Console.WriteLine();
    } while (ligne < nbCoupsVictoire || colonne < nbCoupsVictoire);

    int[,] grille = new int[ligne, colonne];
    return grille;
}//CreationGrille()

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

static bool TestNumColonneValide(int colonne, int[,] grille)
{
    bool test = false;
    if (colonne > 0 && colonne <= grille.GetLength(1) && !ColonnePleine(grille, colonne))
    {
        test = true;
    }
    return test;
}//TestNumColonneValide()

static int SaisirUnNumColonneValide(int[,] grille)
{
    int numColonne = -1;
    do
    {
        Console.Write("Veuillez saisir une colonne valide: ");
        numColonne = TestValiditeDuTypeDeLaSaisie();
        Console.WriteLine();
    } while (!TestNumColonneValide(numColonne, grille));
    return numColonne;
}//SaisirUnNumColonneValide()

static bool ColonnePleine(int[,] grille, int colonne)
{
    bool colonnePleine = false;

    if (grille[0, colonne - 1] == 1 || grille[0, colonne - 1] == 2)
    {
        colonnePleine = true;
    }
    return colonnePleine;
}//SaisirUnNumColonneValide()

