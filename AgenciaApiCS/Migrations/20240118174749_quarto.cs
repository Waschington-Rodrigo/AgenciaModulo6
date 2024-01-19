using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaApiCS.Migrations
{
    public partial class quarto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagem_Destino_Destino_id_fk",
                table: "Passagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Passagem_Usuario_Usuario_id_fk",
                table: "Passagem");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Usuario",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Usuario",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Usuario",
                newName: "endereco");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuario",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Usuario",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Usuario",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Passagem",
                newName: "valorTotal");

            migrationBuilder.RenameColumn(
                name: "Usuario_id_fk",
                table: "Passagem",
                newName: "usuario_id_fk");

            migrationBuilder.RenameColumn(
                name: "PacotePromo",
                table: "Passagem",
                newName: "pacotePromo");

            migrationBuilder.RenameColumn(
                name: "Destino_id_fk",
                table: "Passagem",
                newName: "destino_id_fk");

            migrationBuilder.RenameColumn(
                name: "DataViagem",
                table: "Passagem",
                newName: "dataViagem");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Passagem",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Passagem_Usuario_id_fk",
                table: "Passagem",
                newName: "IX_Passagem_usuario_id_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Passagem_Destino_id_fk",
                table: "Passagem",
                newName: "IX_Passagem_destino_id_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagem_Destino_destino_id_fk",
                table: "Passagem",
                column: "destino_id_fk",
                principalTable: "Destino",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passagem_Usuario_usuario_id_fk",
                table: "Passagem",
                column: "usuario_id_fk",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagem_Destino_destino_id_fk",
                table: "Passagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Passagem_Usuario_usuario_id_fk",
                table: "Passagem");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Usuario",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuario",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Usuario",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "endereco",
                table: "Usuario",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuario",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Usuario",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Usuario",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valorTotal",
                table: "Passagem",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "usuario_id_fk",
                table: "Passagem",
                newName: "Usuario_id_fk");

            migrationBuilder.RenameColumn(
                name: "pacotePromo",
                table: "Passagem",
                newName: "PacotePromo");

            migrationBuilder.RenameColumn(
                name: "destino_id_fk",
                table: "Passagem",
                newName: "Destino_id_fk");

            migrationBuilder.RenameColumn(
                name: "dataViagem",
                table: "Passagem",
                newName: "DataViagem");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Passagem",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Passagem_usuario_id_fk",
                table: "Passagem",
                newName: "IX_Passagem_Usuario_id_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Passagem_destino_id_fk",
                table: "Passagem",
                newName: "IX_Passagem_Destino_id_fk");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagem_Destino_Destino_id_fk",
                table: "Passagem",
                column: "Destino_id_fk",
                principalTable: "Destino",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passagem_Usuario_Usuario_id_fk",
                table: "Passagem",
                column: "Usuario_id_fk",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
