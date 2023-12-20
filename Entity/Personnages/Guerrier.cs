


namespace EquipeJeuDeRole.Pages
{


    public class Guerrier : Entity
    {


        public int Force { get; set; }
        


        public Guerrier()
        {
           
            Nom = "GUERRIER";
            Race = Races.NULL;
            Force = 6;
            PointDeVie = 20;
            Classes = Classes.GUERRIER;


        }

        public Guerrier(Races aRace = Races.NULL, string aNom = "GUERRIER")
        {
            Nom = aNom;
            Race = aRace;
            PointDeVie = 20;
            Force = 6;
        }
        


        public override void Attaquer(Entity cible)
        {
            Console.WriteLine("Le guerrier attaque !");
        }
    }
}
