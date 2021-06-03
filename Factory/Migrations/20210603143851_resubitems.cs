using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class resubitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineNumber",
                table: "Machines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MachineNumber",
                table: "Machines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
