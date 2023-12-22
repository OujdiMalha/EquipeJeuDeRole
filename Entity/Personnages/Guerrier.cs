


using System.Data.Common;

namespace EquipeJeuDeRole.Pages
{


    public class Guerrier : Entity
    {


        public int Force { get; set; }
        public List<string> AttackList = new List<string>() { "AttaqueLegere", "AttaqueLourde" };
        


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
        


        public int AttaqueLegere(Entity monstre)
        {
            //attaque aléatoire avec sa force de 1 a 6
            Random rnd = new Random();
            damage = rnd.Next(1, Force);
            return monstre.PointDeVie -= damage;
        }
        public int AttaqueLourde(Entity monstre)
        {
            //attaque aléatoire avec sa force de 1 a force+2 
            Random rnd = new Random();
            damage = rnd.Next(1, Force+2);
            
            return monstre.PointDeVie -= damage;
        }
    }
}
