﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDal
{
    public class ProductoDal
    {
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from producto";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }


        
    }
}
