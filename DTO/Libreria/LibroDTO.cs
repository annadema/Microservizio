using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Libreria
{
    public class LibroDTO
    {
        public String Titolo { get; set; }
        public  String Autore { get; set; }

        public String ISBN { get; set; }

        public uint NumeroPagine { get; set; }

    }
}
