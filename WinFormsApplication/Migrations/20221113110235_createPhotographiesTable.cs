using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApplication.Migrations
{
    /// <inheritdoc />
    public partial class createPhotographiesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Photographies",
              columns: table => new
              {
                  Id = table.Column<int>(type: "INTEGER", nullable: false)
                      .Annotation("Sqlite:Autoincrement", true),
                  Advertisment_Id = table.Column<int>(type: "INTEGER", nullable: false),
                  Filepath = table.Column<string>(type: "TEXT", nullable: false),
                  isGeneral = table.Column<bool>(type: "TEXT", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_photograpiesId", x => x.Id);
              });

            migrationBuilder.AddForeignKey(
                name: "FK_Photographies_Advertisments_AdvertismentId",
                table: "Photographies",
                column: "Advertisment_Id",
                principalTable: "Advertisments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Photographies");
        }
    }
}
