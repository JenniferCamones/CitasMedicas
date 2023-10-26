using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace Proyecto_Medicos.Models
{
    public class CitasMedicos

    {
        [Display(Name = "Nro Cita")]
        public int nrocita { get; set; }


        [Display(Name = "Fecha Cita")]
        public string? fecha { get; set; }


        [Display(Name = "Codigo Paciente")]
        public string? codpac { get; set; }

        [Display(Name = "Nombre")]
        public string? nompac { get; set; }

        [Display(Name = "Pago")]
        public decimal pago { get; set; }
    }
}
