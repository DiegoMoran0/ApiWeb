using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWeb3C.Shared.Modelos
{
    public class Clasificacion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe escribir el Nombre")]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe escribir la Fundacion")]
        [StringLength(100)]
        public string? Fundacion { get; set; }

        [Required(ErrorMessage = "Debe escribir la Sede")]
        [StringLength(100)]
        public string? Sede { get; set; }

        [Required(ErrorMessage = "Debe escribir los Premios")]
        [StringLength(100)]
        public string? Premios { get; set; }

        [Required(ErrorMessage = "Debe escribir los Socios")]
        [StringLength(100)]
        public string? Socios { get; set; }


        public int PilotoId { get; set; }
        public Piloto? Piloto { get; set; }

        virtual public ICollection<Persona>? Personas { get; set; }

    }
}
