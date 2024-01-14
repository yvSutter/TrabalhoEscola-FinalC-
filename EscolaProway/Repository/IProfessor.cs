using Ap.Controle.Web.Context;
using EscolaProway.Models;

namespace EscolaProway.Repository;

public interface IProfessor
{
    public IEnumerable<Professor> Professores { get; }
}
