namespace EquipeJeuDeRole.Pages
{

    public class Guerrier : Entity
    {


        public int Force { get; set; }

        public Guerrier(Races aRace = Races.NULL, string aNom = "GUERRIER") : base(aNom, 20,aRace)
        {
            Force = 6;
        }




        public override void Attaquer(Entity cible)
        {
            Console.WriteLine("Le guerrier attaque !");
        }
    }
}