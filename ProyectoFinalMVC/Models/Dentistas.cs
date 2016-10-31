using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalMVC.Models
{
    public class Dentistas
    {
        public int dentistasID { get; set; }

        public int nombre { get; set; }

        public string especialidad { get; set; }

        public int telefono { get; set; }

        public string direccion { get; set; }

    }
}