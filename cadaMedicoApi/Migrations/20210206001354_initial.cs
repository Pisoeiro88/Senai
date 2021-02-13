using Microsoft.EntityFrameworkCore.Migrations;

namespace cadaMedicoApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Crm = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Privilegios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilegios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true),
                    PrivilegioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicoCidade",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoCidade", x => new { x.MedicoId, x.CidadeId });
                    table.ForeignKey(
                        name: "FK_MedicoCidade_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoCidade_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicoEspecilidade",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EspecialidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoEspecilidade", x => new { x.MedicoId, x.EspecialidadeId });
                    table.ForeignKey(
                        name: "FK_MedicoEspecilidade_Especialidades_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoEspecilidade_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 1, "PR", "Londrina" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 2, "PR", "Cambé" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 3, "PR", "Rolandia" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 4, "PR", "Jataizinho" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 5, "SP", "São Paulo" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 6, "RJ", "Rio de Janeiro" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "CLINICO GERAL" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "PSIQUIATRA" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "OFTALMOLOGISTA" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "PODÓLOGO" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "OBSTÉTRA" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 6, "UROLOGISTA" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Crm", "Nome", "Telefone" },
                values: new object[] { 6, "87623", "JORGIM", "21-1238-9873" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Crm", "Nome", "Telefone" },
                values: new object[] { 5, "84763", "JULIA", "43-3598-9875" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Crm", "Nome", "Telefone" },
                values: new object[] { 4, "223412", "LUIZ", "43-3256-3456" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Crm", "Nome", "Telefone" },
                values: new object[] { 2, "6534", "PEDRO", "43-3467-6578" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Crm", "Nome", "Telefone" },
                values: new object[] { 1, "23478", "SEBASTIÃO", "19-3241-7893" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Crm", "Nome", "Telefone" },
                values: new object[] { 3, "87634", "MARIANA", "11-5614-8794" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "MASTER" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "ADM" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "USER" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "USERMEDICO" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 5, "FERNANDO01", "FERNANDO", 6, "SENHA123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 1, "ROBERTO01", "ROBERTO", 2, "SENHA123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 2, "JOAO01", "JOÃO", 5, "SENHA123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 3, "ANTONIETA01", "MARIA ANTONIETA", 2, "SENHA123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 4, "HENRIQUE01", "HENRIQUE", 5, "SENHA123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 6, "WALTER01", "WALTER", 4, "SENHA123" });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "MedicoEspecilidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MedicoEspecilidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "MedicoEspecilidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "MedicoEspecilidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "MedicoEspecilidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 5, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoCidade_CidadeId",
                table: "MedicoCidade",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecilidade_EspecialidadeId",
                table: "MedicoEspecilidade",
                column: "EspecialidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoCidade");

            migrationBuilder.DropTable(
                name: "MedicoEspecilidade");

            migrationBuilder.DropTable(
                name: "Privilegios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
