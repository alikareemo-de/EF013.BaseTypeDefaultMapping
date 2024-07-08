using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF013.BaseTypeDefaultMapping.Migrations
{
    /// <inheritdoc />
    public partial class configINDVandCOPR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Particpants");

            migrationBuilder.AddColumn<string>(
                name: "ParticpantType",
                table: "Particpants",
                type: "VARCHAR(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticpantType",
                table: "Particpants");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Particpants",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }
    }
}
