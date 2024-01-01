using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRez.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string DoctorName { get; set; }


        public string? Poliklinik { get; set; }



        [Required]
        public string Calisma { get; set; }


        [ValidateNever]
        public int? PoliId { get; set; }



        [ForeignKey(("PoliId"))]
        [ValidateNever]
        public Category? Category { get; set; }


        
        public string? Image { get; set; }

        public bool IsHome { get; set; }
    }
}
