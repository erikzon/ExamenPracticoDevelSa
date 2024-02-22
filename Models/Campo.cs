using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPractico.Models
{
    public class Campo
    {
        [Key]
        public int CampoId { get; set; }

        [Required]
        public int EncuestaId { get; set; }

        [ForeignKey("EncuestaId")]
        public Encuesta Encuesta { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Titulo { get; set; }

        public bool EsRequerido { get; set; }

        public string TipoCampo { get; set; }

        public List<Respuesta> Respuestas { get; set; }
    }

}
