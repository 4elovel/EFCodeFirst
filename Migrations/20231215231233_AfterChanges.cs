using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AfterChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConcededGoals",
                table: "Teams",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfirmedGoals",
                table: "Teams",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcededGoals",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ConfirmedGoals",
                table: "Teams");
        }
    }
}
