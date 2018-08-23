using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.ViewModels
{
    public class AlunoViewModel
    {
        public int id {get; set;}
        [Required]
        public string nome { get; set; }
        [Required]
        public string matricula { get; set; }
        [Required]
        public string endereco { get; set; }
        [Required]
        public string telefone { get; set; }
        [Required]
        public int turmaId { get; set; }
        public string turmaNome { get; set; }
         public string turmaAno { get; set; }
        public string escolaNome {get; set;}
         public IEnumerable<TurmaViewModel> turmas { get; set; }

    }
}