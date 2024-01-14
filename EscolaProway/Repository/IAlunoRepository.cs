using Ap.Controle.Web.Context;
using EscolaProway.Models;

namespace EscolaProway.Repository;

public class IAlunoRepository: IAluno
{
    private readonly AppDbContext _context;
    public IAlunoRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public IEnumerable<Aluno>Alunos => _context.Alunos;
}