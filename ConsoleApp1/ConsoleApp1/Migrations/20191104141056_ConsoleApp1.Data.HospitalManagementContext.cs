using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class ConsoleApp1DataHospitalManagementContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    UserID = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_account", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Benh",
                columns: table => new
                {
                    TenBenh = table.Column<string>(maxLength: 50, nullable: false),
                    TrieuChung1 = table.Column<string>(maxLength: 50, nullable: false),
                    TrieuChung2 = table.Column<string>(maxLength: 50, nullable: false),
                    TrieuChung3 = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_benh", x => x.TenBenh);
                });

            migrationBuilder.CreateTable(
                name: "BenhNhan",
                columns: table => new
                {
                    MaBenhNhan = table.Column<string>(maxLength: 50, nullable: false),
                    TenBenhNhan = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    GioiTinh = table.Column<string>(maxLength: 50, nullable: false),
                    QueQuan = table.Column<string>(maxLength: 50, nullable: false),
                    Benh = table.Column<string>(maxLength: 50, nullable: false),
                    TinhTrang = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_benhnhan", x => x.MaBenhNhan);
                });

            migrationBuilder.CreateTable(
                name: "HeSoLuong",
                columns: table => new
                {
                    NgheNghiep = table.Column<string>(maxLength: 50, nullable: false),
                    HeSoLuongTheoGio = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hesoluong", x => x.NgheNghiep);
                });

            migrationBuilder.CreateTable(
                name: "PhiDieuTri",
                columns: table => new
                {
                    Benh = table.Column<string>(maxLength: 50, nullable: false),
                    ChiPhi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_phidieutri", x => x.Benh);
                    table.ForeignKey(
                        name: "fk_phidieutri_benh",
                        column: x => x.Benh,
                        principalTable: "Benh",
                        principalColumn: "TenBenh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoanhThuQuy1",
                columns: table => new
                {
                    MaSo = table.Column<string>(maxLength: 50, nullable: false),
                    HoTen = table.Column<string>(maxLength: 50, nullable: false),
                    Benh = table.Column<string>(maxLength: 50, nullable: false),
                    NgayXuatVien = table.Column<DateTime>(type: "date", nullable: false),
                    ChiPhi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_doanhthuquy1", x => x.MaSo);
                    table.ForeignKey(
                        name: "fk_doanhthuquy1_benhnhan",
                        column: x => x.MaSo,
                        principalTable: "BenhNhan",
                        principalColumn: "MaBenhNhan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoanhThuQuy2",
                columns: table => new
                {
                    MaSo = table.Column<string>(maxLength: 50, nullable: false),
                    HoTen = table.Column<string>(maxLength: 50, nullable: false),
                    Benh = table.Column<string>(maxLength: 50, nullable: false),
                    NgayXuatVien = table.Column<DateTime>(type: "date", nullable: false),
                    ChiPhi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_doanhthuquy2", x => x.MaSo);
                    table.ForeignKey(
                        name: "fk_doanhthuquy2_benhnhan",
                        column: x => x.MaSo,
                        principalTable: "BenhNhan",
                        principalColumn: "MaBenhNhan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoanhThuQuy3",
                columns: table => new
                {
                    MaSo = table.Column<string>(maxLength: 50, nullable: false),
                    HoTen = table.Column<string>(maxLength: 50, nullable: false),
                    Benh = table.Column<string>(maxLength: 50, nullable: false),
                    NgayXuatVien = table.Column<DateTime>(type: "date", nullable: false),
                    ChiPhi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_doanhthuquy3", x => x.MaSo);
                    table.ForeignKey(
                        name: "fk_doanhthuquy3_benhnhan",
                        column: x => x.MaSo,
                        principalTable: "BenhNhan",
                        principalColumn: "MaBenhNhan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DSBenhNhanDaXuatVien",
                columns: table => new
                {
                    MaSo = table.Column<string>(maxLength: 50, nullable: false),
                    HoTen = table.Column<string>(maxLength: 50, nullable: false),
                    Benh = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dsbenhnhandaxuatvien", x => x.MaSo);
                    table.ForeignKey(
                        name: "fk_dsbenhnhandaxuatvien_benhnhan",
                        column: x => x.MaSo,
                        principalTable: "BenhNhan",
                        principalColumn: "MaBenhNhan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaSo = table.Column<string>(maxLength: 50, nullable: false),
                    SoLuongThuocA = table.Column<int>(nullable: false),
                    SoLuongThuocB = table.Column<int>(nullable: false),
                    SoLuongThuocC = table.Column<int>(nullable: false),
                    SoLuongThuocD = table.Column<int>(nullable: false),
                    SoLuongThuocE = table.Column<int>(nullable: false),
                    PhiDieuTri = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hoadon", x => x.MaSo);
                    table.ForeignKey(
                        name: "fk_hoadon_benhnhan",
                        column: x => x.MaSo,
                        principalTable: "BenhNhan",
                        principalColumn: "MaBenhNhan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(maxLength: 50, nullable: false),
                    TenNhanVien = table.Column<string>(maxLength: 50, nullable: false),
                    GioiTinh = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    NgheNghiep = table.Column<string>(maxLength: 50, nullable: false),
                    SoNgayDiLam = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_nhanvien", x => x.MaNV);
                    table.ForeignKey(
                        name: "fk_nhanvien_hesoluong",
                        column: x => x.NgheNghiep,
                        principalTable: "HeSoLuong",
                        principalColumn: "NgheNghiep",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SoLuongBenhNhan",
                columns: table => new
                {
                    SLBN = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_soluongbenhnhan", x => x.SLBN);
                    table.ForeignKey(
                        name: "fk_soluongbenhnhan_hoadon",
                        column: x => x.SLBN,
                        principalTable: "HoaDon",
                        principalColumn: "MaSo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinBenhNhan",
                columns: table => new
                {
                    MaSo = table.Column<string>(maxLength: 50, nullable: false),
                    SoPhong = table.Column<string>(maxLength: 50, nullable: false),
                    MSHoaDon = table.Column<string>(maxLength: 50, nullable: false),
                    NgayNhapVien = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_thongtinbenhnhan", x => new { x.MaSo, x.SoPhong, x.MSHoaDon });
                    table.ForeignKey(
                        name: "fk_thongtinbenhnhan_benhnhan",
                        column: x => x.MaSo,
                        principalTable: "BenhNhan",
                        principalColumn: "MaBenhNhan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_thongtinbenhnhan_hoadon",
                        column: x => x.MSHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaSo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_NgheNghiep",
                table: "NhanVien",
                column: "NgheNghiep");

            migrationBuilder.CreateIndex(
                name: "ck_nhanvien",
                table: "NhanVien",
                column: "TenNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinBenhNhan_MSHoaDon",
                table: "ThongTinBenhNhan",
                column: "MSHoaDon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "DoanhThuQuy1");

            migrationBuilder.DropTable(
                name: "DoanhThuQuy2");

            migrationBuilder.DropTable(
                name: "DoanhThuQuy3");

            migrationBuilder.DropTable(
                name: "DSBenhNhanDaXuatVien");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhiDieuTri");

            migrationBuilder.DropTable(
                name: "SoLuongBenhNhan");

            migrationBuilder.DropTable(
                name: "ThongTinBenhNhan");

            migrationBuilder.DropTable(
                name: "HeSoLuong");

            migrationBuilder.DropTable(
                name: "Benh");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "BenhNhan");
        }
    }
}
