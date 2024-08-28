using DTO.Libreria;
using Interfaccia_DAL.Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Libreria
{
    public class LibreriaDAL_Fake : ILibreriaDAL
    {

        private readonly static List<LibroDTO> myLibri = new List<LibroDTO>();

        static LibreriaDAL_Fake()
        {
            myLibri = new List<LibroDTO>()
            {
                new LibroDTO()
                {
                    Titolo = "Baol",
                    Autore = "StefanoBenni",
                    ISBN = "STFBN",
                    NumeroPagine = 100
                },
                new LibroDTO()
                {
                    Titolo = "La strada",
                    Autore = "Cormac McCarty",
                    ISBN = "CMCR",
                    NumeroPagine = 200
                },
                new LibroDTO()
                {
                    Titolo = "Il silenzio è cosa viva",
                    Autore = "C. L. Candiani",
                    ISBN = "1234567890",
                    NumeroPagine = 214
                },
                new LibroDTO()
                {
                    Titolo = "Questo immenso non sapere",
                    Autore = "Candiani",
                    ISBN = "43567",
                    NumeroPagine = 168
                },
                new LibroDTO()
                    {
                    Titolo = "Il signore degli anelli",
                    Autore = "JRR Tolkien",
                    ISBN = "0987654321",
                    NumeroPagine = 1543
                }

            };
        }

        public async Task<IEnumerable<LibroDTO>> GetAll()
        {
            await Task.Delay(1000);
            return myLibri;
        }

        public async Task<IEnumerable<LibroDTO>> GetAllCandiani()
        {
            await Task.Delay(1000);

            var libriCandiani = myLibri
                .Where(libro => libro.Autore.ToLower().Contains("candiani"))
                .Select(libro => new LibroDTO() 
            {
                Titolo = libro.Titolo.ToUpper(),
                Autore = libro.Autore,
                ISBN = libro.ISBN,
                NumeroPagine = libro.NumeroPagine,
            });
                    

            return libriCandiani;
        }

        public async Task<IEnumerable<LibroDTO>> GetFilterByAutore(string autore)
        {
            await Task.Delay(1000);
            return  myLibri.Where(libro=>libro.Autore.ToUpper().Contains(autore.ToUpper()));
        }

        public async Task<LibroDTO> GetByISBN(string ISBN)
        {
            await Task.Delay(1000);
            return myLibri.Where(libro => (libro.ISBN == ISBN)).SingleOrDefault();
        }

        public async Task<LibroDTO> Insert(LibroDTO libro)
        {
            await Task.Delay(500);
            myLibri.Add(libro);
            return libro;
        }
    }
}
