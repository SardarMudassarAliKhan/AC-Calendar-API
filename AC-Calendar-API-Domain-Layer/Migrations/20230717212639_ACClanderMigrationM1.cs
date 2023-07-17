using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AC_Calendar_API_Domain_Layer.Migrations
{
    /// <inheritdoc />
    public partial class ACClanderMigrationM1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clanders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    display = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startEditable = table.Column<bool>(type: "bit", nullable: false),
                    durationEditable = table.Column<bool>(type: "bit", nullable: false),
                    overlap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    backgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    borderColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    textColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clanders");
        }
    }
}
