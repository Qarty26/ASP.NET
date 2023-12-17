using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roads.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tag",
                table: "Hashtags",
                newName: "Tag");

            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "Hashtags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tag",
                table: "Hashtags",
                newName: "tag");

            migrationBuilder.AlterColumn<string>(
                name: "tag",
                table: "Hashtags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
