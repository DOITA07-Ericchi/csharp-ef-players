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

            migrationBuilder.CreateTable(
                name: "player",
                columns: table => new
                {
                    playerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    punteggio = table.Column<int>(type: "int", nullable: false),
                    nPartiteGiocate = table.Column<int>(type: "int", nullable: false),
                    nPartiteVinte = table.Column<int>(type: "int", nullable: false),
                    teamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player", x => x.playerId);
                    table.ForeignKey(
                        name: "FK_player_team_teamId",
                        column: x => x.teamId,
                        principalTable: "team",
                        principalColumn: "teamId",
                        onDelete: ReferentialAction.Cascade);
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "player");

            migrationBuilder.DropTable(
                name: "team");
        }
    }
}
