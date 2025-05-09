using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModelos
{
    public class Espacio
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }

        public List<Evento> Eventos { get; set; } = new List<Evento>();

    }
}
