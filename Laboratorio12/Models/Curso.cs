using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratorio12.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int DuracionHoras { get; set; }
        public bool Activo { get; set; }

        // Key Foreight
        public int IdInstructor { get; set; }

        [ForeignKey("IdInstructor")]
        public Instructor Instructor { get; set; }

    }
}
