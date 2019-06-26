﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DALocal
{
    public interface ILocalRepository
    {
        void RegistrarLocal(Local objLocal);
        void ActualizarLocal(Local objLocal);
        void EliminarLocal(int LocalID);
        List<Local> ListarLocales();

        List<Local> NombreAscendente();
        List<Local> NombreDescendente();
    }
}
