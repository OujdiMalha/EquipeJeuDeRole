using JeuDeRole.Pages;

public class Guerrier: Entity
{
    
    
    public int Force{ get; set; }
    
    public Guerrier(string aNom = "GUERRIER") : base(aNom, 20)
    {
        Force = 6;
    }


   

    public override void Attaquer(Entity cible)
    {
        Console.WriteLine("Le guerrier attaque !");
    }
}