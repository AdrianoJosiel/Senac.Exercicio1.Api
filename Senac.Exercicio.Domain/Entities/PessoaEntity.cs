namespace Senac.Exercicio.Domain.Entities
{
    public class PessoaEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; private set; }
        public bool Situacao {  get; set; } 

        public PessoaEntity()
        {
        }

        public PessoaEntity(int id, string nome, string cpf, DateTime dataNascimento, bool situacao)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Situacao = situacao;
        }
       
    }
}
