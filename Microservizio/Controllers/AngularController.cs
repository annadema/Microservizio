using DTO.Angular;
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


    }
}
