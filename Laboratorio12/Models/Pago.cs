using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratorio12.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoPago { get; set; }

        // Key Foreign

        public int IdMatricula { get; set; }

        [ForeignKey("IdMatricula")]
        public Matricula Matricula { get; set; }
    }
}
