using DTO.Libreria;
using Interfaccia_DAL.Libreria;
using Interfaccia_BL.Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Libreria
{
    public class LibreriaBL : ILibreriaBL
    {

        private readonly ILibreriaDAL _libreriaDAL;

        public LibreriaBL(ILibreriaDAL libreriaDAL)
        {
            this._libreriaDAL = libreriaDAL;
        }

        public async Task<IEnumerable<LibroDTO>> GetAll()
        {
           IEnumerable<LibroDTO> elencoLibri= await this._libreriaDAL.GetAll();
            return elencoLibri;
        }

        public async Task<IEnumerable<LibroDTO>> GetAllCandiani()
        {
            IEnumerable<LibroDTO> elencoLibri = await this._libreriaDAL.GetAllCandiani();    

            return elencoLibri;
        }

        public async Task<IEnumerable<LibroDTO>> GetFilterByAutore(string autore)
        {
            IEnumerable<LibroDTO> elencoLibriRaw = await this._libreriaDAL.GetFilterByAutore("CAndiani");

            return elencoLibriRaw.Select(libro => new LibroDTO()
            {
                Autore = libro.Autore,
                Titolo = libro.Titolo.ToUpper(),
                ISBN = libro.ISBN,
                NumeroPagine = libro.NumeroPagine
            });
        }

        public async Task<LibroDTO> GetByISBN(string isbn)
        {
            return await this._libreriaDAL.GetByISBN(isbn);
        }
    }
}
