namespace EquipeJeuDeRole.Pages
{
    using EquipeJeuDeRole.Pages;


    public class Archer : Entity
    {


        public int Dextérité { get; set; }
        public List<string> AttackList = new List<string>() { "AttaqueDague", "AttaqueFleche" };
        
        public Archer()
        {
            Dextérité = 6;
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
            Classes = Classes.ARCHER;
        }

        public int AttaqueDague(Entity monstre)
        {
            //attaque aléatoire avec sa dexterité de 1 a 6
            Random rnd = new Random();
            damage = rnd.Next(1, Dextérité);
            return monstre.PointDeVie -= damage;
        }

        public int AttaqueFleche(Entity monstre)
        {
            //attaque aléatoire avec sa dexterité de 1 a dexterité+2
            Random rnd = new Random();
            damage = rnd.Next(1, Dextérité + 2);
            return monstre.PointDeVie -= damage;
        }



    }
}