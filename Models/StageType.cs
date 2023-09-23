using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Work.Models
{
    public class StageType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string question { get; set; }
        [Required]
        public string info { get; set; }
        [Required]
        public int maxduration { get; set; }
        [Required]
        public int deadline { get; set; }
    }
}
