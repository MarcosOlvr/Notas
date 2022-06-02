using Notas.Interfaces;

namespace Notas.Models
{
    public class QuartoBi : INotas
    {
        public int Id { get; set; }
        public int Portugues { get; set; }
        public int Matematica { get; set; }
        public int Historia { get; set; }
        public int Geografia { get; set; }
        public int Ciencias { get; set; }
        public int Faltas { get; set; }
        public int AlunoId { get; set; }
    }
}
