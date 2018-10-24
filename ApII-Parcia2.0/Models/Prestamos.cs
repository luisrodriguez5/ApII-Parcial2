using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApII_Parcia2._0.Models
{
    public class Prestamos
    {
        public int PrestamosId { get; set; }

        public long Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Plazo { get; set; }
        public int ClienteId { get; set; }
        public virtual Clientes  Clientes { get; set; }
    }
}