using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntoTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_player",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_player_id",
                table: "player");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "player",
                newName: "teamId");

            migrationBuilder.AlterColumn<int>(
                name: "teamId",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "playerId",
                table: "player",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_player",
                table: "player",
                column: "playerId");

            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    teamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    città = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    allenatore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.teamId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_player_playerId",
                table: "player",
                column: "playerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_player_teamId",
                table: "player",
                column: "teamId");

            migrationBuilder.CreateIndex(
                name: "IX_team_teamId",
                table: "team",
                column: "teamId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_player_team_teamId",
                table: "player",
                column: "teamId",
                principalTable: "team",
                principalColumn: "teamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_teamId",
                table: "player");

            migrationBuilder.DropTable(
                name: "team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_player",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_player_playerId",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_player_teamId",
                table: "player");

            migrationBuilder.DropColumn(
                name: "playerId",
                table: "player");

            migrationBuilder.RenameColumn(
                name: "teamId",
                table: "player",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_player",
                table: "player",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_player_id",
                table: "player",
                column: "id",
                unique: true);
        }
    }
}
