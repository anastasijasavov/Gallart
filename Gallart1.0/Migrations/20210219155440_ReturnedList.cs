using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallart.Migrations
{
    public partial class ReturnedList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListId",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_ListId",
                table: "Paintings",
                column: "ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Lists_ListId",
                table: "Paintings",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Lists_ListId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_ListId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "ListId",
                table: "Paintings");
        }
    }
}
