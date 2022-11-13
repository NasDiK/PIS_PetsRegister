using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApplication.Migrations
{
    /// <inheritdoc />
    public partial class createResponsesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
             name: "Responses",
             columns: table => new
             {
                 Id = table.Column<int>(type: "INTEGER", nullable: false)
                     .Annotation("Sqlite:Autoincrement", true),
                 User_Id= table.Column<int>(type: "INTEGER", nullable: false),
                 Advertisment_Id = table.Column<int>(type: "INTEGER", nullable: false),
                 isGeneral = table.Column<bool>(type: "BOOLEAN", nullable: false)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_responses", x => x.Id);
             });

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Users_UserId",
                table: "Responses",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Advertisments_AdvertismentId",
                table: "Responses",
                column: "Advertisment_Id",
                principalTable: "Advertisments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
