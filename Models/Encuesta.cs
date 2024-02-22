namespace ExamenPractico.Models
{
    public class Encuesta
    {
        public int EncuestaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Campo> Campos { get; set; }
    }

}
