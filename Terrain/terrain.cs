using EquipeJeuDeRole.Pages;

namespace EquipeJeuDeRole.Pages
    {
        public class Terrain
        {
            public Entity?[,] plateau;
            public Monstre[] listeMonstre = new Monstre[25];
            public int nbRow = 100;
            public int nbCol = 100;

            public Terrain()
            {
                plateau = new Entity?[nbRow, nbCol];
                InitialiserMonstres();
            }

            private void InitialiserMonstres()
            {
                Random random = new Random();

                for (int k = 0; k < listeMonstre.Length; k++)
                {
                    int randomRow = random.Next(0, nbRow);
                    int randomCol = random.Next(0, nbCol);

                    // je vérifie si la case est vide
                    while (plateau[randomRow, randomCol] != null)
                    {
                        randomRow = random.Next(0, nbRow);
                        randomCol = random.Next(0, nbCol);
                    }

                    //Créer un nouveau monstre et l'ajouter à la case
                    Monstre monstre = new Monstre();
                    monstre.row = randomRow;
                    monstre.col = randomCol;
                    plateau[randomRow, randomCol] = monstre;

                    // Ajoutez le monstre à la liste des monstres
                    listeMonstre[k] = monstre;
                }
            }
        }
    }

