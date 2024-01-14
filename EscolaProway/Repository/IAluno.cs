using EscolaProway.Models;

namespace EscolaProway.Repository;

public interface IAluno
{
    public IEnumerable<Aluno> Alunos { get; }
}
