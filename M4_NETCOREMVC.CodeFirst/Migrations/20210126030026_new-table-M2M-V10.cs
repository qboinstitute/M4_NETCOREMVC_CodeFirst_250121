﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace M4_NETCOREMVC.CodeFirst.Migrations
{
    public partial class newtableM2MV10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerTeam",
                columns: table => new
                {
                    PlayersId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTeam", x => new { x.PlayersId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_PlayerTeam_Player_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTeam_Team_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTeam_TeamsId",
                table: "PlayerTeam",
                column: "TeamsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerTeam");
        }
    }
}
