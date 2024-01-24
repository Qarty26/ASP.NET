using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roads.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackHashtagRelations_Hashtags_IdHashtag",
                table: "TrackHashtagRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackHashtagRelations_Tracks_IdTrack",
                table: "TrackHashtagRelations");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackHashtagRelations_Hashtags_IdHashtag",
                table: "TrackHashtagRelations",
                column: "IdHashtag",
                principalTable: "Hashtags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackHashtagRelations_Tracks_IdTrack",
                table: "TrackHashtagRelations",
                column: "IdTrack",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackHashtagRelations_Hashtags_IdHashtag",
                table: "TrackHashtagRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackHashtagRelations_Tracks_IdTrack",
                table: "TrackHashtagRelations");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackHashtagRelations_Hashtags_IdHashtag",
                table: "TrackHashtagRelations",
                column: "IdHashtag",
                principalTable: "Hashtags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackHashtagRelations_Tracks_IdTrack",
                table: "TrackHashtagRelations",
                column: "IdTrack",
                principalTable: "Tracks",
                principalColumn: "Id");
        }
    }
}
