using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baghiut_Andreea_Lab2.Migrations
{
    public partial class RemovePublishingDateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
        name: "PublishingDate",
        table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
            name: "PublishingDate",
            table: "Book",
            type: "datetime2",
            nullable: true);
        }
    }
}
