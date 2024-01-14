using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaProway.Models;

[Table("Professores")]
public class Professor
{
    [Key]
    public int IdProfessor { get; set; }
    [Required]
    public string NomeProfessor { get; set; }
    [Required]
    public string Especialidade { get; set; }
    public List<Aluno> Alunos { get; set; }
}
