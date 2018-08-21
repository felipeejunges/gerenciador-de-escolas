using gerenciador_de_escolas.Config;

namespace gerenciador_de_escolas.Models
{
    public class Aluno : Entity
    {
        public string nome { get; private set; }
        public string matricula { get; private set; }
        public string endereco { get; private set; }
        public string telefone { get; private set; }
        public Turma turma { get; private set; }

        public Aluno(string nome, string matricula, string endereco, string telefone, Turma turma)
        {
            validateValues(nome, matricula, endereco, telefone, turma);
            setProperties(nome, matricula, endereco, telefone, turma);
        }

        public void update(string nome, string matricula, string endereco, string telefone, Turma turma)
        {
            validateValues(nome, matricula, endereco, telefone, turma);
            setProperties(nome, matricula, endereco, telefone, turma);
        }

        private void setProperties(string nome, string matricula, string endereco, string telefone, Turma turma)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.endereco = endereco;
            this.telefone = telefone;
            this.turma = turma;
        }
        private static void validateValues(string nome, string matricula, string endereco, string telefone, Turma turma)
        {
            DomainException.when(string.IsNullOrEmpty(nome), "Nome é obrigatório");
            DomainException.when(string.IsNullOrEmpty(matricula), "Matricula é obrigatório");
            DomainException.when(string.IsNullOrEmpty(endereco), "Endereco é obrigatório");
            DomainException.when(string.IsNullOrEmpty(telefone), "Telefone é obrigatório");
            DomainException.when(turma == null, "Turma é obrigatório");
        }
    }
}