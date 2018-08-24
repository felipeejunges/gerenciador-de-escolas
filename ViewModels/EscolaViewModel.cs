using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.ViewModels
{
    public class EscolaViewModel
    {
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string endereco { get; set; }
        [Required]
        public string telefone { get; set; }
        public string logomarca { get; set; }

         public IEnumerable<TurmaViewModel> turmas { get; set; } 
    }
}