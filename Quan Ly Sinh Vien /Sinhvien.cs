using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySinhVien
{
    public class SinhVien
    {
        [Key]
        public int MaSV { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        public int Tuoi { get; set; }

        // Khóa ngoại liên kết với lớp học
        public int MaLop { get; set; }

        [ForeignKey("MaLop")]
        public virtual LopHoc LopHoc { get; set; }
    }
}
