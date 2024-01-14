using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaProway.Migrations
{
    public partial class CriandoProfessor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    insert into Professores(NomeProfessor,Especialidade)
                                    values ('Andre','Csharp'),
                                           ('Andre Vitor','Java'),                                                                                   
                                           ('Vitor','Python')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
