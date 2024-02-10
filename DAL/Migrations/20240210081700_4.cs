﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "messages2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Senderid = table.Column<int>(type: "int", nullable: true),
                    Receiverid = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages2", x => x.id);
                    table.ForeignKey(
                        name: "FK_messages2_writers_Receiverid",
                        column: x => x.Receiverid,
                        principalTable: "writers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_messages2_writers_Senderid",
                        column: x => x.Senderid,
                        principalTable: "writers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_messages2_Receiverid",
                table: "messages2",
                column: "Receiverid");

            migrationBuilder.CreateIndex(
                name: "IX_messages2_Senderid",
                table: "messages2",
                column: "Senderid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "messages2");
        }
    }
}
