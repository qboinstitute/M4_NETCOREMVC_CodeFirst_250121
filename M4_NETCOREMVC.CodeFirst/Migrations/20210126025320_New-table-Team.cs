using Microsoft.EntityFrameworkCore.Migrations;

namespace M4_NETCOREMVC.CodeFirst.Migrations
{
    public partial class NewtableTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_SoccerPosition_PositionsId",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "PositionsId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_SoccerPosition_PositionsId",
                table: "Player",
                column: "PositionsId",
                principalTable: "SoccerPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_SoccerPosition_PositionsId",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "PositionsId",
                table: "Player",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_SoccerPosition_PositionsId",
                table: "Player",
                column: "PositionsId",
                principalTable: "SoccerPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
