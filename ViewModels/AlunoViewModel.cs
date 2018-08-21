using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.ViewModels
{
    public class AlunoViewModel
    {
        public int id {get; set;}
        public string nome { get; set; }
        public string matricula { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public int turma { get; set; }

    }
}