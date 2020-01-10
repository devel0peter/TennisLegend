using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisLegend.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTimeUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedDateTimeUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Rules = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTimeUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedDateTimeUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTimeUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedDateTimeUtc = table.Column<DateTime>(nullable: true),
                    CompetitionId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Score = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Place = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTimeUtc = table.Column<DateTime>(nullable: false),
                    LastModifiedDateTimeUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false),
                    PlayerOneId = table.Column<int>(nullable: true),
                    PlayerTwoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Players_PlayerOneId",
                        column: x => x.PlayerOneId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Players_PlayerTwoId",
                        column: x => x.PlayerTwoId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_CompetitionId",
                table: "Matches",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PlayerOneId",
                table: "Teams",
                column: "PlayerOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PlayerTwoId",
                table: "Teams",
                column: "PlayerTwoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
