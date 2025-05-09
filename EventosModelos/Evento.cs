using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModelos
{
    public class Evento
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string HorarioInicio { get; set; }


        public int EspacioId { get; set; }
        public int PonenteId { get; set; }

        public Espacio? Espacio { get; set; }
        public Ponente? Ponente { get; set; }

        public List<Inscripcion>? Inscripciones { get; set; } = new List<Inscripcion>();
        public List<Asistente>? Asistentes { get; set; } = new List<Asistente>();
        public List<Certificado>? Certificados { get; set; } = new List<Certificado>();
        
        
    }
}
