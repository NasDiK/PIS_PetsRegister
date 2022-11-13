using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApplication.Migrations
{
    /// <inheritdoc />
    public partial class createPetCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "PetCategories",
               columns: table => new
               {
                   Id = table.Column<int>(type: "INTEGER", nullable: false)
                       .Annotation("Sqlite:Autoincrement", true),
                   Name = table.Column<string>(type: "TEXT", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_petCategory", x => x.Id);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetCategories");
        }
    }
}
