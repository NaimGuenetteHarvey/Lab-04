using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class AjoutHuntingLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zombies_ZombieType_ZombieTypeId",
                table: "zombies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_zombies",
                table: "zombies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZombieType",
                table: "ZombieType");

            migrationBuilder.RenameTable(
                name: "zombies",
                newName: "Zombies");

            migrationBuilder.RenameTable(
                name: "ZombieType",
                newName: "ZombieTypes");

            migrationBuilder.RenameColumn(
                name: "Descritpion",
                table: "Zombies",
                newName: "ShortDesc");

            migrationBuilder.RenameIndex(
                name: "IX_zombies_ZombieTypeId",
                table: "Zombies",
                newName: "IX_Zombies_ZombieTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zombies",
                table: "Zombies",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZombieTypes",
                table: "ZombieTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "HuntingLogs",
                columns: table => new
                {
                    HuntingLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntingLogs", x => x.HuntingLogID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Zombies_ZombieTypes_ZombieTypeId",
                table: "Zombies",
                column: "ZombieTypeId",
                principalTable: "ZombieTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zombies_ZombieTypes_ZombieTypeId",
                table: "Zombies");

            migrationBuilder.DropTable(
                name: "HuntingLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zombies",
                table: "Zombies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZombieTypes",
                table: "ZombieTypes");

            migrationBuilder.RenameTable(
                name: "Zombies",
                newName: "zombies");

            migrationBuilder.RenameTable(
                name: "ZombieTypes",
                newName: "ZombieType");

            migrationBuilder.RenameColumn(
                name: "ShortDesc",
                table: "zombies",
                newName: "Descritpion");

            migrationBuilder.RenameIndex(
                name: "IX_Zombies_ZombieTypeId",
                table: "zombies",
                newName: "IX_zombies_ZombieTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zombies",
                table: "zombies",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZombieType",
                table: "ZombieType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_zombies_ZombieType_ZombieTypeId",
                table: "zombies",
                column: "ZombieTypeId",
                principalTable: "ZombieType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
