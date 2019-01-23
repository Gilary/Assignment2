using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Skills_CompanyId",
                table: "Skills",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Companies_CompanyId",
                table: "Skills",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Companies_CompanyId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_CompanyId",
                table: "Skills");
        }
    }
}
