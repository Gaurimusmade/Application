using Application.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Application.Models
{
    public class Declaration
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Signed")]
        public string? Signed { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int? personid { get; set; }
        [ForeignKey("personid")]
        [InverseProperty("Declarations")]
        public virtual required Private Private { get; set; }

    }

}
