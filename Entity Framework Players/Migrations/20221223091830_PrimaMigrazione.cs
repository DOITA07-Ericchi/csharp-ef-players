using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class PrimaMigrazione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Città = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allenatore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Punteggio = table.Column<int>(type: "int", nullable: false),
                    NPartiteGiocate = table.Column<int>(type: "int", nullable: false),
                    NPartiteVinte = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_player_team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_player_PlayerId",
                table: "player",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_player_TeamId",
                table: "player",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_team_TeamId",
                table: "team",
                column: "TeamId",
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
