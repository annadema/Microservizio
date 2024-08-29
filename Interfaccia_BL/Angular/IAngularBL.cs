using DTO.Angular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaccia_BL.Angular
{
    public interface IAngularBL
    {
        Task<LoginResponseDTO> Login(LoginRequestDTO login);
        Task<IEnumerable<UtenteDTO>> GetAll();

    }
}
