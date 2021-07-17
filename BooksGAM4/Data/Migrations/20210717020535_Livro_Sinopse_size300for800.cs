using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksGAM4.Data.Migrations
{
    public partial class Livro_Sinopse_size300for800 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sinopse",
                table: "Livros",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sinopse",
                table: "Livros",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 800);
        }
    }
}
