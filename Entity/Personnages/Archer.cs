using EquipeJeuDeRole.Pages;

public class Archer: Entity
{
    
    
        


    public Archer()
    {
           
        Nom = "ARCHER";
        Race = Races.NULL;
        PointDeVie = 20;
        Classes = Classes.ARCHER;


    }

    public Archer(Races aRace = Races.NULL, string aNom = "ARCHER")
    {
        Nom = aNom;
        Race = aRace;
        PointDeVie = 20;
        
    }
        


    public override void Attaquer(Entity cible)
    {
        Console.WriteLine("L'archer attaque !");
    }
}
