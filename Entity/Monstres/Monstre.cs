

namespace EquipeJeuDeRole.Pages
{
    public class Monstre : Entity
    {


        public Monstre()
        {
            Nom = "MONSTRE";
            Race = Races.NULL;
            PointDeVie = 20;
        }

        public Monstre(string aNom = "MONSTRE", Races aRace = Races.NULL)
        {
            PointDeVie = 20;
        }

        
        
        
        public override void Attaquer(Entity cible)
        {
            Console.WriteLine("Le monstre attaque !");
            
        }
    }
}