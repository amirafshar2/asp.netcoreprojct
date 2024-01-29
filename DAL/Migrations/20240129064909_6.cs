using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Writerid",
                table: "blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_Writerid",
                table: "blogs",
                column: "Writerid");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_writers_Writerid",
                table: "blogs",
                column: "Writerid",
                principalTable: "writers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_writers_Writerid",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_Writerid",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "Writerid",
                table: "blogs");
        }
    }
}
