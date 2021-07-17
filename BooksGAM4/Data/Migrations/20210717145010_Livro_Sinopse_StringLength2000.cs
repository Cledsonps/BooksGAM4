using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksGAM4.Data.Migrations
{
    public partial class Livro_Sinopse_StringLength2000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sinopse",
                table: "Livros",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 800);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sinopse",
                table: "Livros",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000);
        }
    }
}
