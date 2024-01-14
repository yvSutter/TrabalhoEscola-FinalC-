using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaProway.Migrations
{
    public partial class CriandoAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    insert into Alunos(NomeAluno,NomeMateria, IdProfessor)
                                    values ('Joao','Csharp',1),
                                           ('Maria','Java',2),                                                                                   
                                           ('Jose','Python',3)
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
