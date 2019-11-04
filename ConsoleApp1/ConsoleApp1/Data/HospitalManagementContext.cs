using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ConsoleApp1.Models;

namespace ConsoleApp1.Data
{
    public partial class HospitalManagementContext : DbContext
    {
        public HospitalManagementContext()
        {

        }

        public HospitalManagementContext(DbContextOptions<HospitalManagementContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Benh> Benh { get; set; }
        public virtual DbSet<BenhNhan> BenhNhan { get; set; }
        public virtual DbSet<DoanhThuQuy1> DoanhThuQuy1 { get; set; }
        public virtual DbSet<DoanhThuQuy2> DoanhThuQuy2 { get; set; }
        public virtual DbSet<DoanhThuQuy3> DoanhThuQuy3 { get; set; }
        public virtual DbSet<DsbenhNhanDaXuatVien> DsbenhNhanDaXuatVien { get; set; }
        public virtual DbSet<HeSoLuong> HeSoLuong { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhiDieuTri> PhiDieuTri { get; set; }
        public virtual DbSet<SoLuongBenhNhan> SoLuongBenhNhan { get; set; }
        public virtual DbSet<ThongTinBenhNhan> ThongTinBenhNhan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MINHKHOA\\TIN;Database=HospitalManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("pk_account");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Benh>(entity =>
            {
                entity.HasKey(e => e.TenBenh)
                    .HasName("pk_benh");

                entity.Property(e => e.TenBenh)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.TrieuChung1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrieuChung2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrieuChung3)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BenhNhan>(entity =>
            {
                entity.HasKey(e => e.MaBenhNhan)
                    .HasName("pk_benhnhan");

                entity.Property(e => e.MaBenhNhan)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Benh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.GioiTinh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QueQuan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenBenhNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DoanhThuQuy1>(entity =>
            {
                entity.HasKey(e => e.MaSo)
                    .HasName("pk_doanhthuquy1");

                entity.Property(e => e.MaSo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Benh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgayXuatVien).HasColumnType("date");

                entity.HasOne(d => d.MaSoNavigation)
                    .WithOne(p => p.DoanhThuQuy1)
                    .HasForeignKey<DoanhThuQuy1>(d => d.MaSo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doanhthuquy1_benhnhan");
            });

            modelBuilder.Entity<DoanhThuQuy2>(entity =>
            {
                entity.HasKey(e => e.MaSo)
                    .HasName("pk_doanhthuquy2");

                entity.Property(e => e.MaSo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Benh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgayXuatVien).HasColumnType("date");

                entity.HasOne(d => d.MaSoNavigation)
                    .WithOne(p => p.DoanhThuQuy2)
                    .HasForeignKey<DoanhThuQuy2>(d => d.MaSo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doanhthuquy2_benhnhan");
            });

            modelBuilder.Entity<DoanhThuQuy3>(entity =>
            {
                entity.HasKey(e => e.MaSo)
                    .HasName("pk_doanhthuquy3");

                entity.Property(e => e.MaSo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Benh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgayXuatVien).HasColumnType("date");

                entity.HasOne(d => d.MaSoNavigation)
                    .WithOne(p => p.DoanhThuQuy3)
                    .HasForeignKey<DoanhThuQuy3>(d => d.MaSo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doanhthuquy3_benhnhan");
            });

            modelBuilder.Entity<DsbenhNhanDaXuatVien>(entity =>
            {
                entity.HasKey(e => e.MaSo)
                    .HasName("pk_dsbenhnhandaxuatvien");

                entity.ToTable("DSBenhNhanDaXuatVien");

                entity.Property(e => e.MaSo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Benh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaSoNavigation)
                    .WithOne(p => p.DsbenhNhanDaXuatVien)
                    .HasForeignKey<DsbenhNhanDaXuatVien>(d => d.MaSo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dsbenhnhandaxuatvien_benhnhan");
            });

            modelBuilder.Entity<HeSoLuong>(entity =>
            {
                entity.HasKey(e => e.NgheNghiep)
                    .HasName("pk_hesoluong");

                entity.Property(e => e.NgheNghiep)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaSo)
                    .HasName("pk_hoadon");

                entity.Property(e => e.MaSo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.HasOne(d => d.MaSoNavigation)
                    .WithOne(p => p.HoaDon)
                    .HasForeignKey<HoaDon>(d => d.MaSo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_hoadon_benhnhan");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("pk_nhanvien");

                entity.HasIndex(e => e.TenNhanVien)
                    .HasName("ck_nhanvien")
                    .IsUnique();

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GioiTinh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgheNghiep)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenNhanVien)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.NgheNghiepNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.NgheNghiep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nhanvien_hesoluong");
            });

            modelBuilder.Entity<PhiDieuTri>(entity =>
            {
                entity.HasKey(e => e.Benh)
                    .HasName("pk_phidieutri");

                entity.Property(e => e.Benh)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BenhNavigation)
                    .WithOne(p => p.PhiDieuTri)
                    .HasForeignKey<PhiDieuTri>(d => d.Benh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_phidieutri_benh");
            });

            modelBuilder.Entity<SoLuongBenhNhan>(entity =>
            {
                entity.HasKey(e => e.Slbn)
                    .HasName("pk_soluongbenhnhan");

                entity.Property(e => e.Slbn)
                    .HasColumnName("SLBN")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SlbnNavigation)
                    .WithOne(p => p.SoLuongBenhNhan)
                    .HasForeignKey<SoLuongBenhNhan>(d => d.Slbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_soluongbenhnhan_hoadon");
            });

            modelBuilder.Entity<ThongTinBenhNhan>(entity =>
            {
                entity.HasKey(e => new { e.MaSo, e.SoPhong, e.MshoaDon })
                    .HasName("pk_thongtinbenhnhan");

                entity.Property(e => e.MaSo).HasMaxLength(50);

                entity.Property(e => e.SoPhong).HasMaxLength(50);

                entity.Property(e => e.MshoaDon)
                    .HasColumnName("MSHoaDon")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayNhapVien).HasColumnType("date");

                entity.HasOne(d => d.MaSoNavigation)
                    .WithMany(p => p.ThongTinBenhNhan)
                    .HasForeignKey(d => d.MaSo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_thongtinbenhnhan_benhnhan");

                entity.HasOne(d => d.MshoaDonNavigation)
                    .WithMany(p => p.ThongTinBenhNhan)
                    .HasForeignKey(d => d.MshoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_thongtinbenhnhan_hoadon");
            });
        }
    }
}
