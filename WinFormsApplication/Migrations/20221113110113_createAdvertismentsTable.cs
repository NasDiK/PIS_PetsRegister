using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApplication.Migrations
{
    /// <inheritdoc />
    public partial class createAdvertismentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PetName = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Settlement_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    PetCategory_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    PetOwner_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PetPassportNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BreedName = table.Column<string>(type: "TEXT", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "TEXT", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisments", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_Settlement_SettlementId",
                table: "Advertisments",
                column: "Settlement_Id",
                principalTable: "Settlements",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_PetCategories_PetCategoryId",
                table: "Advertisments",
                column: "PetCategory_Id",
                principalTable: "PetCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisments_Users_PetOwnerId",
                table: "Advertisments",
                column: "PetOwner_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisments");
        }
    }
}
