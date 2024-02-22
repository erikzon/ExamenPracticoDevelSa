namespace ExamenPractico.Models
{
    public class Campo
    {
        public int CampoId { get; set; }
        public int EncuestaId { get; set; }
        public Encuesta Encuesta { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public bool EsRequerido { get; set; }
        public string TipoCampo { get; set; }
    }
}
