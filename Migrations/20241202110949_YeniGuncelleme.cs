using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebÖdev.Migrations
{
    /// <inheritdoc />
    public partial class YeniGuncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UygunlukSaatleri",
                table: "Calisanlar");

            migrationBuilder.AlterColumn<int>(
                name: "RandevuDurumu",
                table: "Randevular",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "UygunlukBaslangic",
                table: "Calisanlar",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "UygunlukBitis",
                table: "Calisanlar",
                type: "time",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UygunlukBaslangic",
                table: "Calisanlar");

            migrationBuilder.DropColumn(
                name: "UygunlukBitis",
                table: "Calisanlar");

            migrationBuilder.AlterColumn<string>(
                name: "RandevuDurumu",
                table: "Randevular",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UygunlukSaatleri",
                table: "Calisanlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
