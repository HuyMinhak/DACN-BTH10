using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyCSKH.Migrations
{
    public partial class BoMoTa1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "SanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
