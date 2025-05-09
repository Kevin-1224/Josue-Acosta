using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModelos
{
    public class Inscripcion
    {
        [Key] public int Id { get; set; }
        public string FechaInscripcion { get; set; }
        public string NombreParticipante {  get; set; }
        public string EstadoInscripcion { get; set; }

        public int EventoId { get; set; }
        public Evento? Evento { get; set; }
        public Pago? Pago { get; set; }
        


    }
}
