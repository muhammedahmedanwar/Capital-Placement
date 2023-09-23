using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Work.Models
{
    public class ProgramDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Skill { get; set; }
        [Required]
        public string Benefit { get; set; }
        [Required]
        public string Criteria { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string MinQuali { get; set; }
        [Required]
        public string MaxNumber { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime PStart { get; set; }
        [Required]
        public DateTime AppOpen { get; set; }
        [Required]
        public DateTime AppClose { get; set; }

        public AppForm appForm { get; set; }
        public WorkFlow WorkFlow { get; set; }
    }
}
