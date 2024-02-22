using System.ComponentModel.DataAnnotations;

namespace ExamenPractico.Models
{
    public class Encuesta
    {
        [Key]
        public int EncuestaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public List<Campo> Campos { get; set; }
    }
}
