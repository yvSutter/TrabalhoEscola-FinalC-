using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaProway.Models;

[Table("Alunos")]
public class Aluno
{
    [Key]
    public int IdAluno { get; set; }
    [Required]
    public string NomeAluno { get; set; }
    [Required]
    public string NomeMateria { get; set; }
    [Required]
    public int IdProfessor { get; set; }
    [ForeignKey("IdProfessor")]
    public virtual Professor Professor { get; set; }
}
