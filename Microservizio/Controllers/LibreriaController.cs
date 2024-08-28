using DTO.Libreria;
using Interfaccia_BL.Libreria;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.CompilerServices;

namespace Microservizio.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("/api/v1/libreria")]
    public class LibreriaController : ControllerBase
    {
        private readonly ILibreriaBL _libreriaBL;

    public LibreriaController(ILibreriaBL libreriaBL)
        {
            this._libreriaBL = libreriaBL;
        }

        [HttpGet("getAll")]
        [ProducesResponseType(typeof(List<LibroDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable < LibroDTO > elencoLibri = await this._libreriaBL.GetAll();
            return Ok(elencoLibri);
        }
       
        [HttpGet("getAllCandiani")]
        [ProducesResponseType(typeof(List<LibroDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllCandiani()
        {
            IEnumerable<LibroDTO> elencoLibri = await this._libreriaBL.GetFilterByAutore("canDIANI");
            return Ok(elencoLibri);
        }

        [HttpGet("getbyisbn/{ISBN}")]
        [ProducesResponseType(typeof(LibroDTO), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetByISBN(String ISBN)
        {
            if (String.IsNullOrEmpty(ISBN)) return BadRequest("ISBN deve avere un valore");

            LibroDTO libro = null;
            try
            {
                libro = await this._libreriaBL.GetByISBN(ISBN);
            }
            catch {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
            return Ok(libro);
        
        }

        [HttpPost("insertlibro")]
        [ProducesResponseType(typeof(LibroDTO), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> InsertLibro([FromBody] LibroDTO libro)
        {
            if (libro == null) return BadRequest("manda un libro");

            LibroDTO newlibro = await this._libreriaBL.Insert(libro);
            return Ok(libro);

        }
    }
}
