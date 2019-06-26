﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.BLEvento_Equipo
{
    public interface IEvento_EquipoService
    {
        void CrearEvento_Equipo(Evento_Equipo obj);
        List<Evento_Equipo> ObtenerEvento_Equipos();
        void EliminarEvento_Equipos(int id);
        List<Evento_Equipo> ListarPorEvento(int EventoID);
        List<Evento_Equipo> ListarPorEquipo(int EquipoID);
    }
}
