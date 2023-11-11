using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_2.Migrations.Lab4
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Models1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models5",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models6",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models2_Models1_Model1Id",
                        column: x => x.Model1Id,
                        principalTable: "Models1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models4_Models3_Model3Id",
                        column: x => x.Model3Id,
                        principalTable: "Models3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelsRelation",
                columns: table => new
                {
                    Model5Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model6Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelsRelation", x => new { x.Model5Id, x.Model6Id });
                    table.ForeignKey(
                        name: "FK_ModelsRelation_Models5_Model5Id",
                        column: x => x.Model5Id,
                        principalTable: "Models5",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelsRelation_Models6_Model6Id",
                        column: x => x.Model6Id,
                        principalTable: "Models6",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models2_Model1Id",
                table: "Models2",
                column: "Model1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Models4_Model3Id",
                table: "Models4",
                column: "Model3Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModelsRelation_Model6Id",
                table: "ModelsRelation",
                column: "Model6Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models2");

            migrationBuilder.DropTable(
                name: "Models4");

            migrationBuilder.DropTable(
                name: "ModelsRelation");

            migrationBuilder.DropTable(
                name: "Students2");

            migrationBuilder.DropTable(
                name: "Models1");

            migrationBuilder.DropTable(
                name: "Models3");

            migrationBuilder.DropTable(
                name: "Models5");

            migrationBuilder.DropTable(
                name: "Models6");
        }
    }
}
