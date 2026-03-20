using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyCSKH.Migrations
{
    public partial class KhoiTaoCSDL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HinhAnh",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoLuong",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "SoLuong",
                table: "SanPham");
        }
    }
}
