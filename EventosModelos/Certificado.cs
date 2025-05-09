using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModelos
{
    public class Certificado
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Fecha { get; set; }
        public string NombreEvento { get; set; }

        public int EventoId { get; set; }
        public Evento? Evento { get; set; }
    }
}
