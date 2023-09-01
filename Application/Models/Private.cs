using Application.Models;
using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Application.Models
{
    public class Private
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Required]
        [Display(Name = "Father's Name")]
        public string? FatherName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Nationality { get; set; }

        [Required]
        [Display(Name = "Security Number")]
        public string? SecurityNumber { get; set; }

        [Required]
        [Display(Name = "PAN Number")]
        public string? PANNumber { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Place of Birth")]
        public string? PlaceOfBirth { get; set; }

        [Required]
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public virtual IEnumerable<Addinfo>? Addinfos { get; set; }
        public virtual IEnumerable<Education>? Educations { get; set; }
        public virtual IEnumerable<Passport>? Passports { get; set; }
        public virtual IEnumerable<Company>? Companys { get; set; }
        public virtual IEnumerable<Assesment>? Assesments { get; set; }
        public virtual IEnumerable<Declaration>? Declarations { get; set; }
    }

    public enum MaritalStatus
    {
        Single,
        Married,
        Divorced,
        Widowed
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

}
