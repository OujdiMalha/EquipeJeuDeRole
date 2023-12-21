using System.Text.Json.Serialization;

namespace EquipeJeuDeRole.Pages
{
    public class Entity
    {
        public Races Race { get; set; }
        public string Nom { get; set; }
        public int PointDeVie = 20;
        public int row { get; set; }
        public int col { get; set; } 
        public int damage { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]public Classes Classes { get; set; }



        public Entity()
        {
        }
        
        public virtual int Attaquer(Entity cible)
        {
            throw new NotImplementedException();
        }

        // Méthode de déplacement
        public void Deplacer(Deplacement direction)
        {
            switch (direction)
            {
                case Deplacement.LEFT:
                    col--;
                    break;
                case Deplacement.RIGHT:
                    col++;
                    break;
                case Deplacement.UP:
                    row--;
                    break;
                case Deplacement.DOWN:
                    row++;
                    break;
            }
        }
    }
}