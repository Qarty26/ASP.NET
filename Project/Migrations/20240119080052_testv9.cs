using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roads.Migrations
{
    /// <inheritdoc />
    public partial class testv9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Maps_IdTrack",
                table: "Maps");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTrack",
                table: "Maps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_IdTrack",
                table: "Maps",
                column: "IdTrack",
                unique: true,
                filter: "[IdTrack] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Maps_IdTrack",
                table: "Maps");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTrack",
                table: "Maps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maps_IdTrack",
                table: "Maps",
                column: "IdTrack",
                unique: true);
        }
    }
}
