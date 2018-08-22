using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.Models
{
    public class Escola : Entity
    {
        public string nome { get; private set; }
        public string endereco { get; private set; }
        public string telefone { get; private set; }
        public string logomarca { get; private set; }

        public Escola()
        {

        }

        public Escola(string nome, string endereco, string telefone, string logomarca)
        {
            validateValues(nome, endereco, telefone, logomarca);
            setProperties(nome, endereco, telefone, logomarca);
        }

        public void update(string nome, string endereco, string telefone, string logomarca)
        {
            validateValues(nome, endereco, telefone, logomarca);
            setProperties(nome, endereco, telefone, logomarca);
        }

        private void setProperties(string nome, string endereco, string telefone, string logomarca)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.logomarca = logomarca;
        }
        private static void validateValues(string nome, string endereco, string telefone, string logomarca)
        {
            DomainException.when(string.IsNullOrEmpty(nome), "Nome é obrigatório");
            DomainException.when(string.IsNullOrEmpty(endereco), "Endereco é obrigatório");
            DomainException.when(string.IsNullOrEmpty(telefone), "Telefone é obrigatório");
            DomainException.when(string.IsNullOrEmpty(logomarca), "Logomarca é obrigatório");
        }
    }
}