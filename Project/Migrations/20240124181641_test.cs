﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roads.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrackCarRelations_AspNetUsers_IdUser",
                table: "UserTrackCarRelations");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrackCarRelations_AspNetUsers_IdUser",
                table: "UserTrackCarRelations",
                column: "IdUser",
                principalTable: "AspNetUsers",
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

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrackCarRelations_AspNetUsers_IdUser",
                table: "UserTrackCarRelations");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrackCarRelations_AspNetUsers_IdUser",
                table: "UserTrackCarRelations",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
