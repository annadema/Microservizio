using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Animale
{
    public class AnimaleDTO
    {
        [Key]
        public uint IdAnimale { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Specie { get; set; }

        public DateTime DataNascita { get; set; }

        public Double Peso { get; set; }
    }
}
