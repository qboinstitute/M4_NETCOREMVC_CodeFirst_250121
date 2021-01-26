using Microsoft.EntityFrameworkCore.Migrations;

namespace M4_NETCOREMVC.CodeFirst.Migrations
{
    public partial class PlayerPositionRelational : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionsId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_PositionsId",
                table: "Player",
                column: "PositionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_SoccerPosition_PositionsId",
                table: "Player",
                column: "PositionsId",
                principalTable: "SoccerPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_SoccerPosition_PositionsId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PositionsId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PositionsId",
                table: "Player");
        }
    }
}
