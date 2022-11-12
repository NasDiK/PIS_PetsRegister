using Microsoft.EntityFrameworkCore.Migrations;
using WinFormsApplication.Models.Entities;

#nullable disable

namespace WinFormsApplication.Migrations
{
    /// <inheritdoc />
    public partial class createSettlementTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Settlement",
               columns: table => new
               {
                   Id = table.Column<int>(type: "INTEGER", nullable: false)
                       .Annotation("Sqlite:Autoincrement", true),
                   Name = table.Column<string>(type: "TEXT", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Settlement", x => x.Id);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settlement");
        }
    }
}
