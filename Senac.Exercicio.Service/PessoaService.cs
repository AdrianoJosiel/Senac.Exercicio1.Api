using Senac.Exercicio.Domain.DTO;
using Senac.Exercicio.Domain.Entities;
using Senac.Exercicio.Infra.Repository;
using System.Security;

namespace Senac.Exercicio.Service
{
    public class PessoaService
    {

        public List<PessoaEntity> ObterPessoas()
     => new PessoaRepository().ObterPessoas();

        /*
        public List<PessoaEntity> ObterPessoas()
        {
            List<PessoaEntity> objLista = new List<PessoaEntity>();
            PessoaRepository repositorio = new PessoaRepository();
            objLista = repositorio.ObterPessoas();
            return objLista;
        }*/

        public bool GravarPessoa (PessoaInputModel p)        
        {
            
            PessoaEntity obj = new PessoaEntity(0, p.Nome, p.Cpf, p.DataNascimento, true);
            //(gambiarra de momento )
            return new PessoaRepository().Gravar(obj);
        }
    }
}
