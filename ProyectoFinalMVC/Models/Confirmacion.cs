using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalMVC.Models
{
    public class Confirmacion
    {

        public int confirmacionID { get; set; }

        public int clienteID { get; set; }

        public DateTime fechaIn { get; set; }

        public DateTime fechaOut { get; set; }

        public int citaID { get; set; }

        public double costoMoney { get; set; }

        public bool confirmacion { get; set; }

        public string comentarios { get; set; }

        virtual public Dentistas dentista { get; set; }
        virtual public Clientes clientes { get; set; }
    }
}