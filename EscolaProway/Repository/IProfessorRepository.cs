using Ap.Controle.Web.Context;
using EscolaProway.Models;

namespace EscolaProway.Repository;

public class IProfessorRepository : IProfessor
{
    private readonly AppDbContext _context;
    public IProfessorRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public IEnumerable<Professor> Professores => _context.Professores;
}
