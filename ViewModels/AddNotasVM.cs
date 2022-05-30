using Notas.Models;

namespace Notas.ViewModels
{
    public class AddNotasVM
    {
        public Aluno Aluno { get; set; }
        public int Portugues { get; set; }
        public int Matematica { get; set; }
        public int Historia { get; set; }
        public int Geografia { get; set; }
        public int Ciencias { get; set; }
    }
}
