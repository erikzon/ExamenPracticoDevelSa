using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPractico.Models
{
    public class Respuesta
    {
        [Key]
        public int RespuestaId { get; set; }

        public string Valor { get; set; }

        [Required]
        public int CampoId { get; set; }

        [ForeignKey("CampoId")]
        public Campo Campo { get; set; }
    }

}
