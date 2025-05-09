using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModelos
{
    public class Asistente
    {
        [Key] public int Id { get; set; }
        public string? NombreAsistente { get; set; }

        public int EventoId { get; set; }
        public Evento? Evento { get; set; }

    }
}
