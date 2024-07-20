using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace egovBroadcastingModel.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class removeproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoreInfoUrl",
                table: "DisasterNotices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoreInfoUrl",
                table: "DisasterNotices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
