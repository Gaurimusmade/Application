using Application.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Application.Models
{
    public class Assesment
    {
        [Key]
        public int Id { get; set; }

        public string? S1 { get; set; }
        public string? S2 { get; set; }
        public string? S3 { get; set; }
        public string? S4 { get; set; }
        public string? S5 { get; set; }
        public string? W1 { get; set; }
        public string? W2 { get; set; }
        public string? W3 { get; set; }
        public string? W4 { get; set; }
        public string? W5 { get; set; }
        public string? Hobby { get; set; }
        public string? Shortgoal { get; set; }

        public string? Longgoal { get; set; }

        public string? MpyAttendency { get; set; }


        public int? personid { get; set; }
        [ForeignKey("personid")]
        [InverseProperty("Assesments")]
        public virtual required Private Private { get; set; }

    }

}
