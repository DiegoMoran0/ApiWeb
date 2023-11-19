using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWeb3C.Shared.Modelos.DTO
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? PaisOrg { get; set; }
        public string? Longitud { get; set; }
        public string? Ubicacion { get; set; }
        public string? NVueltas { get; set; }
        public string? RVueltas { get; set; }
        public string? Clasificacion { get; set; }
        public string? Piloto { get; set; }

    }
}
