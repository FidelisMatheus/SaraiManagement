﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.Interfaces
{
    interface IAlimentoRepositorio
    {
        IQueryable<Alimento> Alimentos { get; }
    }
}
