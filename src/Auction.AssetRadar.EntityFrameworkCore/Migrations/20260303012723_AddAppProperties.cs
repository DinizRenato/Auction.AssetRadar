using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auction.AssetRadar.Migrations
{
    /// <inheritdoc />
    public partial class AddAppProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ExternalCode = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    City = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    AddressLine = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DescriptionRaw = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProperties", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppProperties_Source_ExternalCode",
                table: "AppProperties",
                columns: new[] { "Source", "ExternalCode" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppProperties");
        }
    }
}
