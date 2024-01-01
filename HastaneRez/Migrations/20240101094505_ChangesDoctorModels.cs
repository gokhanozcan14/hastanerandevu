using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRez.Migrations
{
    public partial class ChangesDoctorModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHome",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHome",
                table: "Doctors");
        }
    }
}
