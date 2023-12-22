namespace EquipeJeuDeRole.Pages
{

    public class Sorcier : Entity
    {


        public int Intelligence { get; set; }
        public List<string> AttackList = new List<string>() { "Baton", "BouleDeFeux" };
        

        public Sorcier()
        {
            Intelligence = 6;
            Nom = "SORCIER";
            Race = Races.NULL;
            PointDeVie = 20;
            Classes = Classes.SORCIER;


        }

        public Sorcier(Races aRace = Races.NULL, string aNom = "SORCIER")
        {
            Nom = aNom;
            Race = aRace;
            PointDeVie = 20;
            Classes = Classes.SORCIER;

        }

        public int Baton(Entity monstre)
        {
            //attaque aléatoire avec son Intell de 1 a 6
            Random rnd = new Random();
            damage = rnd.Next(1, Intelligence);
            return monstre.PointDeVie -= damage;
        }

        public int BouleDeFeux(Entity monstre)
        {
            //attaque aléatoire avec son Intell de 1 a dexterité+2
            Random rnd = new Random();
             damage= rnd.Next(1, Intelligence + 2);
            return monstre.PointDeVie -= damage;
        }



    }
}