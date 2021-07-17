using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksGAM4.Data.Migrations
{
    public partial class Livro_ISBN_intForString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Livros",
                type: "varchar(13)",
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ISBN",
                table: "Livros",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(13)");
        }
    }
}
