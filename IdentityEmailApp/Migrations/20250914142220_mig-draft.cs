using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityEmailApp.Migrations
{
    /// <inheritdoc />
    public partial class migdraft : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DraftDate",
                table: "Messages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDraft",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DraftDate",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsDraft",
                table: "Messages");
        }
    }
}
