namespace JeuDeRole.Pages
{



    public abstract class Entity
    {

        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int row { get; set; }
        public int col { get; set; }

        public Entity(string aNom, int aPointDevie)
        {
            Nom = aNom;
            PointDeVie = aPointDevie;
        }

        public abstract void Attaquer(Entity cible);
        //methode de deplacement

        public void findCol(List<List<Entity>> entities)
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (entities[i][j] == this)
                    {
                        col = j;
                    }
                }
            }
        }


        public void findRow(List<List<Entity>> entities)
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (entities[i][j] == this)
                    {
                        row = i;

                    }
                }
            }
        }

        public void Deplacer(Deplacement direction)
        {
            switch (direction)
            {
                case Deplacement.LEFT:
                    col--;
                    break;
                case Deplacement.RIGHT:
                    col++;
                    break;
                case Deplacement.UP:
                    row--;
                    break;
                case Deplacement.DOWN:
                    row++;
                    break;
            }
        }


    }
}