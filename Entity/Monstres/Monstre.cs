namespace EquipeJeuDeRole.Pages
{



    public class Monstre : Entity
    {

        public override void Attaquer(Entity cible)
        {
            Console.WriteLine("Le monstre attaque !");
            throw new NotImplementedException();
        }

        public Monstre(string aNom = "MONSTRE", Races aRaces = Races.NULL) : base(aNom, 20, aRaces)
        {
            aNom = "Monstre";
        }
    }
}