using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArabalarDunyasii.Models
{
    public class Araba
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} alanı zorunludur. ")]
        [MaxLength(200, ErrorMessage ="{0} alanı en fazla {1} karakter olabilir.")]
        [Display(Name ="Model")]
        public string Model { get; set; }
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [Range(1900,2100, ErrorMessage ="{0} {1} ile {2} aralığında olmalıdır.")]
        [Display(Name ="Yıl")]
        public int? Yil { get; set; }
    }
}
