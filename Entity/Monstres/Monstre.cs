
using JeuDeRole.Pages;

public class Monstre : Entity
{
    
    public override void Attaquer(Entity cible)
    {
        Console.WriteLine("Le monstre attaque !");
        throw new NotImplementedException();
    }

    public Monstre(string aNom = "MONSTRE"): base(aNom,20)
    {
        aNom = "Monstre";
    }
}