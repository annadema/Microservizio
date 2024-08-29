using DTO.Angular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaccia_DAL.Angular
{
    public interface IAngularDAL
    {
        Task<LoginResponseDTO> Login(LoginRequestDTO login);
    }
}
