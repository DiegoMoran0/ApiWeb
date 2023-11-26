using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWeb3C.Shared.Modelos.DTO
{
    public class ClasificacionDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Fundacion { get; set; }
        public string? Sede { get; set; }
        public string? Premios { get; set; }
        public string? Socios { get; set; }

        public int PilotoId { get; set; }
        public Piloto? Piloto { get; set; }
    }
}
