using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApII_Parcia2._0.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="EL Campo{0} es obligatorio")]
        [StringLength (60)]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "EL Campo{0} es obligatorio")]
        [StringLength(100)]

        public string Apellido { get; set; }

        [Required(ErrorMessage = "EL Campo{0} es obligatorio")]
        [StringLength(60)]

        public string Dirrecion { get; set; }

        public virtual ICollection<Prestamos>Prestamos { get; set; }
        public int CuentaId { get; set; }
        public virtual Cuentas Cuentas { get; set; }


    }
}