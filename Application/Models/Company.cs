using Application.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Application.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string? CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? Lastdesignation { get; set; }
        public string? Employmentperiod { get; set; }
        public string? Employecode { get; set; }

        public string? NameofRm { get; set; }
        public string? DepartmentofRm { get; set; }
        public string? EmailofRm { get; set; }
        public string? TelephoneofRm { get; set; }

        public string? NameofHr { get; set; }
        public string? EmailofHr { get; set; }
        public string? TelephoneofHr { get; set; }
        [Required]
        public EmploymentIsOf EmploymentIsOf { get; set; }

        public string? AlternativeNameofRm { get; set; }
        public string? AlternativeDepartmentofRm { get; set; }
        public string? AlternativeEmailofRm { get; set; }
        public string? AlternativeTelephoneofRm { get; set; }

        public string? Reason { get; set; }
        public string? Agency { get; set; }
        public string? Remunerations { get; set; }
        public int? personid { get; set; }
        [ForeignKey("personid")]
        [InverseProperty("Companys")]
        public virtual required Private Private { get; set; }

    }
    public enum EmploymentIsOf
    {
        permanent,
        Temporary
    }

}
