using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roads.Migrations
{
    /// <inheritdoc />
    public partial class testv11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AspNetUsers_UserId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_UserId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cars");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_IdUser",
                table: "Cars",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AspNetUsers_IdUser",
                table: "Cars",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AspNetUsers_IdUser",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_IdUser",
                table: "Cars");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AspNetUsers_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
