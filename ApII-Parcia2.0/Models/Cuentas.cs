using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApII_Parcia2._0.Models
{
    public class Cuentas
    {
        [Key]
        public int CuentaId { get; set; }

        [Required(ErrorMessage = "EL Campo{0} es obligatorio")]
        [StringLength(60)]
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ICollection<Prestamos> Prestamos { get; set; }
    }
}