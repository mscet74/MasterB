using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterBurger.Data.Migrations
{
    public partial class upDadosUtil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeCompleto",
                table: "DadosUtilizador");

            migrationBuilder.AlterColumn<string>(
                name: "Telemovel",
                table: "DadosUtilizador",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "NIF",
                table: "DadosUtilizador",
                type: "varchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Morada",
                table: "DadosUtilizador",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Localidade",
                table: "DadosUtilizador",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoPostal",
                table: "DadosUtilizador",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "DadosUtilizador",
                type: "varchar(200)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "DadosUtilizador",
                type: "varchar(200)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DadosUtilId",
                table: "DadosUser",
                type: "varchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "DadosUtilizador");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "DadosUtilizador");

            migrationBuilder.AlterColumn<string>(
                name: "Telemovel",
                table: "DadosUtilizador",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NIF",
                table: "DadosUtilizador",
                type: "varchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Morada",
                table: "DadosUtilizador",
                type: "varchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Localidade",
                table: "DadosUtilizador",
                type: "varchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoPostal",
                table: "DadosUtilizador",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "DadosUtilizador",
                type: "varchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "DadosUtilId",
                table: "DadosUser",
                type: "varchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(450)",
                oldNullable: true);
        }
    }
}
