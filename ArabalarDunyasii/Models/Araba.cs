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
        [Required,MaxLength(200)]
        public string Model { get; set; }
        [Range(1900,2100)]
        public int Yil { get; set; }
    }
}
