using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roads.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hashtags_Tracks_TrackId",
                table: "Hashtags");

            migrationBuilder.DropIndex(
                name: "IX_Hashtags_TrackId",
                table: "Hashtags");

            migrationBuilder.DropColumn(
                name: "IdTrack",
                table: "Hashtags");

            migrationBuilder.DropColumn(
                name: "TrackId",
                table: "Hashtags");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "TrackHashtagRelations",
                columns: table => new
                {
                    IdTrack = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHashtag = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackHashtagRelations", x => new { x.IdHashtag, x.IdTrack });
                    table.ForeignKey(
                        name: "FK_TrackHashtagRelations_Hashtags_IdHashtag",
                        column: x => x.IdHashtag,
                        principalTable: "Hashtags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackHashtagRelations_Tracks_IdTrack",
                        column: x => x.IdTrack,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackHashtagRelations_IdTrack",
                table: "TrackHashtagRelations",
                column: "IdTrack");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackHashtagRelations");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "IdTrack",
                table: "Hashtags",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TrackId",
                table: "Hashtags",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Hashtags_TrackId",
                table: "Hashtags",
                column: "TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hashtags_Tracks_TrackId",
                table: "Hashtags",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
