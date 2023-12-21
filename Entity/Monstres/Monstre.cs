

namespace EquipeJeuDeRole.Pages
{
    public class Monstre : Entity
    {
        
        public List<string> AttackList = new List<string>() {"AttaqueMECHANTE"};
        

        public Monstre()
        {
            Nom = "GOBLIN";
            Race = Races.GOBLIN;
            PointDeVie = 20;
        }

        public Monstre(string aNom = "GOBLIN", Races aRace = Races.GOBLIN)
        {
            PointDeVie = 20;
        }
        
        public int AttaqueMECHANTE(Entity personnage)
        {
            //attaque aléatoire 
            Random rnd = new Random();
            damage = rnd.Next(1, 6);
            return personnage.PointDeVie -= damage;
        }
    }
}