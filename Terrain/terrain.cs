using EquipeJeuDeRole.Pages;

namespace EquipeJeuDeRole.Pages
{
    public class Terrain
    {

        public Entity?[,] plateau;
        public int nbRow = 100;
        public int nbCol = 100;

        public Terrain()
        {
            plateau = new Entity?[nbRow, nbCol];

            for (int i = 0; i < nbRow; i++)
            {
                for (int j = 0; j < nbCol; j++)
                {
                    plateau[i, j] = null;
                }
            }
        }
    }
}


