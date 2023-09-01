using Application.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Application.Models
{
    public class Addinfo
    {
        [Key]
        public int Id { get; set; }

        // Current Address
        [Required]
        [Display(Name = "Address Line 1")]
        public string? AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        public string? Country { get; set; }

        // Permanent Address
        [Display(Name = "Permanent Address Line 1")]
        public string? PermanentAddressLine1 { get; set; }

        [Display(Name = "Permanent Address Line 2")]
        public string? PermanentAddressLine2 { get; set; }

        [Display(Name = "Permanent Zip Code")]
        public string? PermanentZipCode { get; set; }

        [Display(Name = "Permanent City")]
        public string? PermanentCity { get; set; }

        [Display(Name = "Permanent State")]
        public string? PermanentState { get; set; }

        [Display(Name = "Permanent Country")]
        public string? PermanentCountry { get; set; }

        public string? Name { get; set; }

        public RelationshipType RelationshipType { get; set; }

        public int Age { get; set; }
        public int? personid { get; set; }
        [ForeignKey("personid")]
        [InverseProperty("Addinfos")]
        public virtual required Private Private { get; set; }

    }
    public enum RelationshipType
    {
        Parent,
        Sibling,
        Spouse,
        Child,
        Other
    }
}
