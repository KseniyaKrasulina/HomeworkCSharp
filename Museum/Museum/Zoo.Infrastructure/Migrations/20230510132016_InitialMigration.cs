using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

#nullable disable

namespace Museum.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exhibits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(nullable: false),
                    HallID = table.Column<long>(type: "bigint", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibits", x => x.Id);

                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                    table.ForeignKey(
                                           name: "FK_Exhibits_Halls_HallId",
                                           column: x => x.Id,
                                           principalTable: "Halls",
                                           principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exhibits_HallsID",
                table: "Exhibits",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Birth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HallId = table.Column<long>(type: "bigint", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);

                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),


                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                                          name: "FK_Positions_Workers_Id",
                                          column: x => x.Id,
                                          principalTable: "Halls",
                                          principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Levels_of_education",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Level = table.Column<string>(type: "text", nullable: false),
                    WorkerID = table.Column<long>(type: "bigint", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels_of_education", x => x.Id);

                });
            migrationBuilder.CreateTable(
                name: "Positions_of_workers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PositionID = table.Column<int>(type: "bigint", nullable: false),
                    WorkerID = table.Column<int>(type: "bigint", nullable: false),

                },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Positions_of_workers", x => x.Id);
                     table.ForeignKey(
                                           name: "FK_Level_of_education_Workers_WorkerID",
                                           column: x => x.WorkerID,
                                           principalTable: "Workers",
                                           principalColumn: "Id");
                     table.ForeignKey(
                                           name: "FK_Level_of_education_Workers_PositionID",
                                           column: x => x.PositionID,
                                           principalTable: "Positions",
                                           principalColumn: "Id");
                 });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exhibits");

            migrationBuilder.DropTable(
                name: "Halls");
            migrationBuilder.DropTable(
               name: "Workers");
            migrationBuilder.DropTable(
                name: "Positions");
            migrationBuilder.DropTable(
                name: "Levels_of_education");
            migrationBuilder.DropTable(
                name: "Positions_of_workers");

        }
    }
}
