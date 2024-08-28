﻿using DTO.Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaccia_DAL.Libreria
{
    public interface ILibreriaDAL
    {
        Task<IEnumerable<LibroDTO>> GetAll();
        Task<IEnumerable<LibroDTO>> GetAllCandiani();

    }
}