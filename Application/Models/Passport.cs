using Application.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Application.Models
{
    public class Passport
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }

        
        [Display(Name = "Date of Issue")]
        [DataType(DataType.Date)]
        public DateTime Issuedate { get; set; }

      
        [Display(Name = "Date of Expiry")]
        [DataType(DataType.Date)]
        public DateTime Expirydate { get; set; }

        public string? PlaceofIssue { get; set; }
        public string? RfName { get; set; }
        public string? Rfcurrentcompany { get; set; }
        public string? Rfemail { get; set; }
        public string? Rftelephone { get; set; }

        public string? RsName { get; set; }
        public string? Rscurrentcompany { get; set; }
        public string? Rsemail { get; set; }
        public string? Rstelephone { get; set; }
        [Required]
        public Visa Visa { get; set; }
        [Required]
        public Opentotravel Opentotravel { get; set; }

        public int? personid { get; set; }
        [ForeignKey("personid")]
        [InverseProperty("Passports")]
        public virtual required Private Private { get; set; }

    }
    public enum Visa
    {
        Yes,
        No
    }
    public enum Opentotravel
    {
        Yes,
        No
    }
}
