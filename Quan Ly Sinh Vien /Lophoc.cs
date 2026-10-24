
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien
{
    public class LopHoc
    {
        [Key]
        public int MaLop { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLop { get; set; }

        public string Khoa { get; set; }

        // Một lớp học có nhiều sinh viên
        public virtual ICollection<SinhVien> SinhViens { get; set; }
            = new HashSet<SinhVien>();
    }
}
