using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Work.Models
{
    public class AppForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string img { get; set; }

        [Required]
        public string fname { get; set; }
        [Required]
        public string lname { get; set; }
        [Required]
        public string email { get; set; }
        [Range(0, 12)]
        [Required]
        public int phone { get; set; }
        [Required]
        public string nationality { get; set; }
        [Required]
        public string currentResidence { get; set; }
        [Required]
        public int IDNumber { get; set; }
        [Required]
        public DateTime birth { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
