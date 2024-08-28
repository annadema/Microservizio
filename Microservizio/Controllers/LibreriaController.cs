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

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<LibroDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable < LibroDTO > elencoLibri = await this._libreriaBL.GetAll();
            return Ok(elencoLibri);
        }
       
        [HttpGet("GetAllCandiani")]
        [ProducesResponseType(typeof(List<LibroDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllCandiani()
        {
            IEnumerable<LibroDTO> elencoLibri = await this._libreriaBL.GetAllCandiani();
            return Ok(elencoLibri);
        }


    }
}
