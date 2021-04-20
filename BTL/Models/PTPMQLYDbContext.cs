using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL.Models
{
    public partial class PTPMQLYDbContext : DbContext
    {
        public PTPMQLYDbContext()
            : base("name=PTPMQLYDbContext")
        {
        }

        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Tendangnhap)
                .IsFixedLength()
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<BTL.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<BTL.Models.Nhanvien1> Nhanvien1 { get; set; }
    }
}
