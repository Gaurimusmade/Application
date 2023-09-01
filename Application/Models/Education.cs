using Application.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Application.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        public string? XcourseName { get; set; }
        public string? XIIcourseName { get; set; }

        public string? UGcourseName { get; set; }
        public string? PGcourseName { get; set; }
        public string? OthercourseName { get; set; }
        public string? XcollegeName { get; set; }
        public string? XIIcollegeName { get; set; }
        public string? UGcollegeName { get; set; }
        public string? PGcollegeName { get; set; }
        public string? OthercollegeName { get; set; }
        public string? Xpercent { get; set; }
        public string? XIIpercent { get; set; }
        public string? UGpercent { get; set; }
        public string? PGpercent { get; set; }
        public string? Otherpercent { get; set; }


        //Major Achivment

        public string? Description1 { get; set; }
        public string? year1 { get; set; }
        public string? Description2 { get; set; }
        public string? year2 { get; set; }

        //Additional Info
        public string? program { get; set; }
        public string? Institute { get; set; }
        [Display(Name = "Duration")]
        public string? duration { get; set; }
        public string? percentage { get; set; }

        //seminar
        public string? seminarname { get; set; }
        public string? seminarconductby { get; set; }
        public string? seminarduration { get; set; }


        //Project info
        public string? title { get; set; }
        public string? company { get; set; }
        public string? client { get; set; }
        public string? skill { get; set; }
        public string? teamsize { get; set; }
        public string? role { get; set; }

        public int? personid { get; set; }
        [ForeignKey("personid")]
        [InverseProperty("Educations")]
        public virtual required Private Private { get; set; }

    }
}
