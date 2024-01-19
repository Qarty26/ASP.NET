using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roads.Migrations
{
    /// <inheritdoc />
    public partial class testv8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Tracks_Id",
                table: "Maps");

            migrationBuilder.AddColumn<Guid>(
                name: "IdTrack",
                table: "Maps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Maps_IdTrack",
                table: "Maps",
                column: "IdTrack",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Tracks_IdTrack",
                table: "Maps",
                column: "IdTrack",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Tracks_IdTrack",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Maps_IdTrack",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "IdTrack",
                table: "Maps");

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Tracks_Id",
                table: "Maps",
                column: "Id",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
