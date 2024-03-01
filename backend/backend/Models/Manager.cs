using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Manager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenagerId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? EstablishmentId { get; set; }
        public Establishment? Establishment { get; set; } = null;
    }
}
