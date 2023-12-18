using EquipeJeuDeRole.Pages;

public class Terrain
{

    public Entity[,] plateau;
    public int nbRow = 100;
    public int nbCol = 100;

    public Terrain()
    {
        plateau = new Entity[nbRow, nbCol];
    }
}


