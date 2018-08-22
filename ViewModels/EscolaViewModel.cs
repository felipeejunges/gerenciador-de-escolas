using System.ComponentModel.DataAnnotations;
using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.ViewModels
{
    public class EscolaViewModel
    {
        public int id { get; set; }
        [Required]
        public string nome { get; private set; }
        [Required]
        public string endereco { get; private set; }
        [Required]
        public string telefone { get; private set; }
        public string logomarca { get; private set; }
    }
}