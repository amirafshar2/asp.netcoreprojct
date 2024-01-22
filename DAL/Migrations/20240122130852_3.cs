using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Blogid",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Categoryid",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comments_Blogid",
                table: "comments",
                column: "Blogid");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_Categoryid",
                table: "blogs",
                column: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_categories_Categoryid",
                table: "blogs",
                column: "Categoryid",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_Blogid",
                table: "comments",
                column: "Blogid",
                principalTable: "blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_categories_Categoryid",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_Blogid",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_Blogid",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_blogs_Categoryid",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "Blogid",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "Categoryid",
                table: "blogs");
        }
    }
}
