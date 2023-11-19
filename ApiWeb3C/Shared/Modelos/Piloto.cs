using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWeb3C.Shared.Modelos
{
    public class Piloto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe escribir el Nombre")]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe escribir el País de Origen")]
        [StringLength(100)]
        public string? POrg { get; set; }

        [Required(ErrorMessage = "Debe escribir el Año de debut")]
        [StringLength(100)]
        public string? ADebut { get; set; }

        [Required(ErrorMessage = "Debe escribir los Premios")]
        [StringLength(100)]
        public string? Premios { get; set; }

        virtual public ICollection<Persona>? Personas { get; set; }

        virtual public ICollection<Clasificacion>? Clasificaciones { get; set; }

    }
}
