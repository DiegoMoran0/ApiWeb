using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWeb3C.Shared.Modelos
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe escribir el Nombre")]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe escribir el Pais de origen")]
        [StringLength(50)]
        public string? PaisOrg { get; set; }

        [Required(ErrorMessage = "Debe escribir la Longitud")]
        [StringLength(50)]
        public string? Longitud { get; set; }

        [Required(ErrorMessage = "Debe escribir la Ubicacion")]
        [StringLength(50)]
        public string? Ubicacion { get; set; }

        [Required(ErrorMessage = "Debe escribir el Numero de Vueltas")]
        [StringLength(50)]
        public string? NVueltas { get; set; }

        [Required(ErrorMessage = "Debe escribir el Record de Vueltas")]
        [StringLength(50)]
        public string? RVueltas { get; set; }

        public int ClasificacionId { get; set; }
        public Clasificacion? Clasificacion { get; set; }

        public int PilotoId { get; set; }
        public Piloto? Piloto { get; set; }
    }
}
