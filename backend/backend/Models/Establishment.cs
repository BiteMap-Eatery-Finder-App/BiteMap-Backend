using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public enum EstablishmentType
    {
        BarsAndPubs,
        CaffeeAndTea,
        Dessert,
        Restaurant,
        Bakery,
        QuickBite
    }

    public class Establishment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EstablishmentType Type { get; set; }

        //public List<Manager> Managers { get; set; } = new List<Manager> { };

        public Establishment() { }

        public Establishment(string name, string description, EstablishmentType type)
        {
            this.Name = name;
            this.Description = description;
            this.Type = type;
        }
    }
}
