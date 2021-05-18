using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataCodeFirst.Migrations
{
    public partial class adddbwithFluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCV = table.Column<int>(type: "int", nullable: false),
                    TenCV = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    CuaHangID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCH = table.Column<int>(type: "int", nullable: false),
                    TenCh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DicchiCH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDTrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.CuaHangID);
                });

            migrationBuilder.CreateTable(
                name: "DongSanPham",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MADSP = table.Column<int>(type: "int", nullable: false),
                    TENDSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IDTRANGTHAI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongSanPham", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TenDemKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sodt = table.Column<int>(type: "int", nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Macty = table.Column<int>(type: "int", nullable: false),
                    Tencty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mst = table.Column<int>(type: "int", nullable: false),
                    IDTrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MATH = table.Column<int>(type: "int", nullable: false),
                    TENTH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WEBSITE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDTRANGTHAI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    NhanVienID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNv = table.Column<int>(type: "int", nullable: false),
                    TenNv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDemNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuongNV = table.Column<float>(type: "real", nullable: false),
                    Sodt = table.Column<int>(type: "int", nullable: false),
                    IDTrangThai = table.Column<int>(type: "int", nullable: false),
                    CuaHangId = table.Column<int>(type: "int", nullable: false),
                    ChucVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.NhanVienID);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "ChucVu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_CuaHangId",
                        column: x => x.CuaHangId,
                        principalTable: "CuaHang",
                        principalColumn: "CuaHangID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MASP = table.Column<int>(type: "int", nullable: false),
                    TENSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAHINH = table.Column<int>(type: "int", nullable: false),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRONGLUONGSP = table.Column<float>(type: "real", nullable: false),
                    GIANHAP = table.Column<float>(type: "real", nullable: false),
                    GIABAN = table.Column<float>(type: "real", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    DongSanPhamId = table.Column<int>(type: "int", nullable: false),
                    ThuongHieuId = table.Column<int>(type: "int", nullable: false),
                    IDTRANGTHAI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_DongSanPham_DongSanPhamId",
                        column: x => x.DongSanPhamId,
                        principalTable: "DongSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_ThuongHieu_ThuongHieuId",
                        column: x => x.ThuongHieuId,
                        principalTable: "ThuongHieu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<int>(type: "int", nullable: false),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    MaHD = table.Column<int>(type: "int", nullable: false),
                    NgayTaoHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayThanhToanHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayShipHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNhanHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDTrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "NhanVienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonID = table.Column<int>(type: "int", nullable: true),
                    SanPhamID = table.Column<int>(type: "int", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    DONGIA = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_HoaDon_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuBaoHanh",
                columns: table => new
                {
                    PhieuBaoHanhID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhieu = table.Column<int>(type: "int", nullable: false),
                    SanPhamId = table.Column<int>(type: "int", nullable: false),
                    HoaDonId = table.Column<int>(type: "int", nullable: false),
                    NGAYBATDAU = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NGAYKETTHUC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMEI = table.Column<int>(type: "int", nullable: false),
                    IDTRANGTHAI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuBaoHanh", x => x.PhieuBaoHanhID);
                    table.ForeignKey(
                        name: "FK_PhieuBaoHanh_HoaDon_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuBaoHanh_SanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangId",
                table: "HoaDon",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienId",
                table: "HoaDon",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_HoaDonID",
                table: "HoaDonChiTiets",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_SanPhamID",
                table: "HoaDonChiTiets",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_ChucVuId",
                table: "NhanVien",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_CuaHangId",
                table: "NhanVien",
                column: "CuaHangId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuBaoHanh_HoaDonId",
                table: "PhieuBaoHanh",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuBaoHanh_SanPhamId",
                table: "PhieuBaoHanh",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_DongSanPhamId",
                table: "SanPham",
                column: "DongSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ThuongHieuId",
                table: "SanPham",
                column: "ThuongHieuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "PhieuBaoHanh");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "DongSanPham");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
