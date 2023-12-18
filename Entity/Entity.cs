using EquipeJeuDeRole.Pages;

namespace JeuDeRole.Pages
{



    public abstract class Entity
    {
        public Races Race;

        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int row { get; set; }
        public int col { get; set; }

        public Entity(string aNom, int aPointDevie,Races aRace)
        {
            Race = aRace;
            Nom = aNom;
            PointDeVie = aPointDevie;
        }

        public abstract void Attaquer(Entity cible);
        //methode de deplacement

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