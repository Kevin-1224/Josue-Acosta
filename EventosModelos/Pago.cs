using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModelos
{
    public class Pago
    {
        [Key] public int Id { get; set; }
        public string FechaPago { get; set; }
        public double? Monto { get; set; }
        public string MetodoPago { get; set; }

        public int InscripcionId { get; set; }
        public Inscripcion? Inscripcion { get; set; }

    }
}
