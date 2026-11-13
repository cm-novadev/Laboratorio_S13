using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratorio12.Models
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }
        public DateTime FechaMatricula { get; set; }
        public string Estado { get; set; }
        public decimal MontoTotal { get; set; }

        // Key Foreign

        public int IdEstudiante { get; set; }

        [ForeignKey("IdEstudiante")]
        public Estudiante Estudiante { get; set; }

        public int IdCurso { get; set; }

        [ForeignKey("IdCurso")]
        public Curso Curso { get; set; }

    }
}
