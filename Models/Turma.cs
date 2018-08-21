using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.Models
{
    public class Turma : Entity
    {
        public string nome {get; private set;}
        public string ano {get; private set;}
        public Escola escola {get; private set;}

         public Turma(string nome, string ano, Escola escola)
        {
            validateValues(nome, ano, escola);
            setProperties(nome, ano, escola);
        }

        public void update(string nome, string ano, Escola escola)
        {
            validateValues(nome, ano, escola);
            setProperties(nome, ano, escola);
        }

        private void setProperties(string nome, string ano, Escola escola)
        {
            this.nome = nome;
            this.ano = ano;
            this.escola = escola;
        }
        private static void validateValues(string nome, string ano, Escola escola)
        {
            DomainException.when(string.IsNullOrEmpty(nome), "Nome é obrigatório");
            DomainException.when(string.IsNullOrEmpty(ano), "Ano é obrigatório");
            DomainException.when(escola == null, "Turma é obrigatório");
        }
    }
}