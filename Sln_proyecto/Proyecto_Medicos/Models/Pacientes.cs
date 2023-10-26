using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proyecto_Medicos.Models
{
    public class Pacientes
    {
        [Display(Name = "Codigo")]
        public string?  codpac { get; set; }

        [Display(Name = "Nombre")]
        public string? nompac { get; set; }

        [Display(Name = "DNI")]
        public string? dnipac { get; set; }

        [Display(Name = "Numero Telefono")]
        public string? telefono { get; set; }

        [Display(Name = "Direccion")]
        public string? dirpac { get; set; }

        [Display(Name = "Distrito")]
        public string? coddis { get; set; }

        [Display(Name = "Eliminado")]
        public string? eliminado { get; set; }

    }
}
