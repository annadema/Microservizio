using DTO.Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaccia_BL.Libreria
{
    public interface ILibreriaBL
    {
        Task<IEnumerable<LibroDTO>> GetAll();
        Task<IEnumerable<LibroDTO>> GetAllCandiani();
        Task<IEnumerable<LibroDTO>> GetFilterByAutore(String autore);
        Task<LibroDTO> GetByISBN(String ISBN);
    }
}
