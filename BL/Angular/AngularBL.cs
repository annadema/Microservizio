using DTO.Angular;
using Interfaccia_DAL.Angular;
using Interfaccia_BL.Angular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Angular
{
    public class AngularBL : IAngularBL
    {
        #region Privates
        private readonly IAngularDAL _angularDAL;
        #endregion

        #region Constructors
        public AngularBL(IAngularDAL angularDAL)
        {
            this._angularDAL = angularDAL;
        }
        #endregion

        #region Metodi interfaccia


        public async Task<LoginResponseDTO> Login(LoginRequestDTO login)
        {
            return await this._angularDAL.Login(login);
        }

        #endregion

    }
}
