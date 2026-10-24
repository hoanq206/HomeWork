using System.Data.Entity;

namespace QuanLySinhVien
{
    public class QuanLySinhVienContext : DbContext
    {
        public QuanLySinhVienContext()
            : base("name=QuanLySinhVienDB")
        {
        }

        public DbSet<LopHoc> LopHocs { get; set; }

        public DbSet<SinhVien> SinhViens { get; set; }
    }
}
