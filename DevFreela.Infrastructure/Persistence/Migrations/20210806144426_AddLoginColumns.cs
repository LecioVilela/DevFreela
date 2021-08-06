using Microsoft.EntityFrameworkCore.Migrations;

namespace DevFreela.Infrastructure.Persistence.Migrations
{
    public partial class AddLoginColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_IdFreeLancer",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "IdFreeLancer",
                table: "Projects",
                newName: "IdFreelancer");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_IdFreeLancer",
                table: "Projects",
                newName: "IX_Projects_IdFreelancer");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FreelanceProjectsId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_FreelanceProjectsId",
                table: "Projects",
                column: "FreelanceProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_FreelanceProjectsId",
                table: "Projects",
                column: "FreelanceProjectsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_IdFreelancer",
                table: "Projects",
                column: "IdFreelancer",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_FreelanceProjectsId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_IdFreelancer",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_FreelanceProjectsId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FreelanceProjectsId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "IdFreelancer",
                table: "Projects",
                newName: "IdFreeLancer");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_IdFreelancer",
                table: "Projects",
                newName: "IX_Projects_IdFreeLancer");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_IdFreeLancer",
                table: "Projects",
                column: "IdFreeLancer",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
