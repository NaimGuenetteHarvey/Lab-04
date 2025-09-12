using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class Zombie
    {
        [Key]
        [Range(5,20)]
        public string Name { get; set; }
        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]

        public int ZombieTypeId { get; set; }
        public ZombieType ZombieType { get; set; }
        [Range(1,10)]
        public int Point { get; set; }
        [Range(0,250)]
        public string ShortDesc { get; set; }
    }
}
