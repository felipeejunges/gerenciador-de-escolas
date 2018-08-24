using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.ViewModels
{
    public class TurmaViewModel
    {
        public int id {get; set;}
        [Required]
        public string nome {get; set;}
        [Required]
        public string ano {get; set;}
        [Required]
        public int escolaId {get; set;}
        public string escolaNome {get;set;}
         public IEnumerable<EscolaViewModel> escolas { get; set; }
        public IEnumerable<AlunoViewModel> alunos { get; set; }

    }
}