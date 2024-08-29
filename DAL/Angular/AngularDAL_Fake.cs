using DTO.Angular;
using Interfaccia_DAL.Angular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Angular
{
    public class AngularDAL_Fake : IAngularDAL
    {
        private static readonly List<UtenteDTO> users;

        static AngularDAL_Fake()
        {
            users = new List<UtenteDTO>()
            {
                new UtenteDTO()
                {
                    id = 0,
                    password = "2",
                    immagine = 0,
                    nome = "Aldo",
                    cognome = "Rossi",
                    motto = "Lorem ipsum dolor sit amet, consectetur",
                    frase = "Fusce non justo ut risus venenatis"
                },
                new UtenteDTO()
                {
                    id = 1,
                    password = "2",
                    immagine = 1,
                    nome = "Giovanni",
                    cognome = "Bianchi",
                    motto = "In molestie ut augue at faucibus",
                    frase = "Pellentesque porta leo at sollicitudin semper"
                },
                new UtenteDTO()
                {
                    id = 2,
                    password = "2",
                    immagine = 2,
                    nome = "Giacomo",
                    cognome = "Verdi",
                    motto = "Mauris pharetra vulputate neque",
                    frase = "Aliquam erat volutpat. Vivamus quis sapien iaculis ligula tincidunt porta sed a risus"
                }
                ,
                new UtenteDTO()
                {
                    id = 3,
                    password = "2",
                    immagine = 3,
                    nome = "Pippo",
                    cognome = "Giallo",
                    motto = "Mauris pharetra vulputate neque",
                    frase = "Aliquam erat volutpat. Vivamus quis sapien iaculis ligula tincidunt porta sed a risus"
                },
                new UtenteDTO()
                {
                    id = 4,
                    password = "2",
                    immagine = 4,
                    nome = "Pippo",
                    cognome = "Viola",
                    motto = "Mauris pharetra vulputate neque",
                    frase = "Aliquam erat volutpat. Vivamus quis sapien iaculis ligula tincidunt porta sed a risus"
                }
            };
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO login)
        {
 
            await Task.Delay(500);

            UtenteDTO utente = users.SingleOrDefault(u => u.nome == login.nome && u.password == login.password);

            LoginResponseDTO response = new LoginResponseDTO()
            {
                log = utente == null ? "No" : "Si",
                id = utente?.id.ToString() ?? String.Empty,
                nome = utente?.nome
            };

            return response;

        }
    }
}
