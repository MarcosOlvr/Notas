using Notas.Models;

namespace Notas.ViewModels
{
    public class EditarNotasVM
    {
        public Aluno Aluno { get; set; }
        public bool TemNotaPrimeiroBi { get; set; } = false;
        public bool TemNotaSegundoBi { get; set; } = false;
        public bool TemNotaTerceiroBi { get; set; } = false;
        public bool TemNotaQuartoBi { get; set; } = false;
    }
}
