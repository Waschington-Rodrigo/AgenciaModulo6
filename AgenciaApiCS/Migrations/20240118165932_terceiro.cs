using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaApiCS.Migrations
{
    public partial class terceiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Hospedagem_Hospedagem_id_fk",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuario_Usuario_id_fk",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Reserva",
                newName: "valorTotal");

            migrationBuilder.RenameColumn(
                name: "Usuario_id_fk",
                table: "Reserva",
                newName: "usuario_id_fk");

            migrationBuilder.RenameColumn(
                name: "QtdDias",
                table: "Reserva",
                newName: "qtdDias");

            migrationBuilder.RenameColumn(
                name: "PacotePromo",
                table: "Reserva",
                newName: "pacotePromo");

            migrationBuilder.RenameColumn(
                name: "Hospedagem_id_fk",
                table: "Reserva",
                newName: "hospedagem_id_fk");

            migrationBuilder.RenameColumn(
                name: "DataReserva",
                table: "Reserva",
                newName: "dataReserva");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reserva",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_Usuario_id_fk",
                table: "Reserva",
                newName: "IX_Reserva_usuario_id_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_Hospedagem_id_fk",
                table: "Reserva",
                newName: "IX_Reserva_hospedagem_id_fk");

            migrationBuilder.RenameColumn(
                name: "ValorDiaria",
                table: "Hospedagem",
                newName: "valorDiaria");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Hospedagem",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Hospedagem",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Hospedagem",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Hospedagem",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Hospedagem",
                newName: "endereco");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Hospedagem",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hospedagem",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Destino",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "LocalDestino",
                table: "Destino",
                newName: "localDestino");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Destino",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Destino",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Destino",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Hospedagem_hospedagem_id_fk",
                table: "Reserva",
                column: "hospedagem_id_fk",
                principalTable: "Hospedagem",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuario_usuario_id_fk",
                table: "Reserva",
                column: "usuario_id_fk",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Hospedagem_hospedagem_id_fk",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuario_usuario_id_fk",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "valorTotal",
                table: "Reserva",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "usuario_id_fk",
                table: "Reserva",
                newName: "Usuario_id_fk");

            migrationBuilder.RenameColumn(
                name: "qtdDias",
                table: "Reserva",
                newName: "QtdDias");

            migrationBuilder.RenameColumn(
                name: "pacotePromo",
                table: "Reserva",
                newName: "PacotePromo");

            migrationBuilder.RenameColumn(
                name: "hospedagem_id_fk",
                table: "Reserva",
                newName: "Hospedagem_id_fk");

            migrationBuilder.RenameColumn(
                name: "dataReserva",
                table: "Reserva",
                newName: "DataReserva");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Reserva",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_usuario_id_fk",
                table: "Reserva",
                newName: "IX_Reserva_Usuario_id_fk");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_hospedagem_id_fk",
                table: "Reserva",
                newName: "IX_Reserva_Hospedagem_id_fk");

            migrationBuilder.RenameColumn(
                name: "valorDiaria",
                table: "Hospedagem",
                newName: "ValorDiaria");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Hospedagem",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Hospedagem",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Hospedagem",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Hospedagem",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "endereco",
                table: "Hospedagem",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Hospedagem",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Hospedagem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Destino",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "localDestino",
                table: "Destino",
                newName: "LocalDestino");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Destino",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Destino",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Destino",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Hospedagem_Hospedagem_id_fk",
                table: "Reserva",
                column: "Hospedagem_id_fk",
                principalTable: "Hospedagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuario_Usuario_id_fk",
                table: "Reserva",
                column: "Usuario_id_fk",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
