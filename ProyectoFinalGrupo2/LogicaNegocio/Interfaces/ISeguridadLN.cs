﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface ISeguridadLN
    {
        TUSR_USUARIOS recUsuario(string pLogin);
        List<PA_recPerfilesXUsuario_Result> recPerfilesPorUsuario(string pLogin);
    }
}
