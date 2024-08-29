using DTO.Angular;
using DTO.Libreria;
using Interfaccia_BL.Angular;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.CompilerServices;

namespace Microservizio.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("/api/v1/angular")]
    public class AngularController : ControllerBase
    {
        #region privates

        private readonly IAngularBL _angularBL;

        #endregion

        #region Constructors
        public AngularController(IAngularBL angularBL)
        {
            this._angularBL = angularBL;
        }
        #endregion

        #region APIs
        #region endpoint prova ritorna stringa

        [HttpGet("prova")]
        [ProducesResponseType(typeof(String), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Prova()
        {
            return Ok("Ciao Mondo");
        }

        #endregion

        #region endpoint post login
        [HttpPost("login")]
        [ProducesResponseType(typeof(LoginResponseDTO), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginreq)
        {
            #region Validazione

            if (loginreq == null) return BadRequest("login request non corretta");

            #endregion

            LoginResponseDTO response = null;

            try
            {
                response = await this._angularBL.Login(loginreq);


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(response);

        }
        #endregion

        #region endpoint get users

        [HttpGet("getusers")]
        [ProducesResponseType(typeof(List<UtenteDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<UtenteDTO> users = await this._angularBL.GetAll();
            return Ok(users);
        }

        #endregion


        #endregion


    }
}
