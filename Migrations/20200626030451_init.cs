using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectShcool_Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true),
                    sobrenome = table.Column<string>(nullable: true),
                    dataNasc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true),
                    sobrenome = table.Column<string>(nullable: true),
                    dataNasc = table.Column<string>(nullable: true),
                    professorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Alunos_Professores_professorId",
                        column: x => x.professorId,
                        principalTable: "Professores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "dataNasc", "nome", "sobrenome" },
                values: new object[] { 1, "01-02-2000", "Vinicius", "de Moraes" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "dataNasc", "nome", "sobrenome" },
                values: new object[] { 2, "01-01-1999", "Helena", "Gonzales" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "dataNasc", "nome", "sobrenome" },
                values: new object[] { 3, "01-01-1800", "Luna", "de Lunares" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "dataNasc", "nome", "professorId", "sobrenome" },
                values: new object[] { 3, "01-01-2012", "Aluno Luna", 1, "de Lunares" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "dataNasc", "nome", "professorId", "sobrenome" },
                values: new object[] { 1, "01-02-2010", "Aluno Vinicius", 2, "de Moraes" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "dataNasc", "nome", "professorId", "sobrenome" },
                values: new object[] { 2, "01-01-2005", "Aluno Helena", 3, "Gonzales" });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_professorId",
                table: "Alunos",
                column: "professorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
