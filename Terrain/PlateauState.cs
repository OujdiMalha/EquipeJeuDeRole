using System.Text.Json.Serialization;

namespace EquipeJeuDeRole.Pages;

public class PlateauState
{
    
    
    public Entity? Entity { get; set; }
    public Monstre? Monstre { get; set; }

    public Terrain Terrain { get; set; } = new Terrain();
}