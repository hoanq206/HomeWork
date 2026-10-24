
using System;
using System.Linq;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new QuanLySinhVienContext())
            {
                // Tạo lớp học nếu chưa có
                var lop = db.LopHocs.FirstOrDefault(
                    l => l.TenLop == "CNTT K20");

                if (lop == null)
                {
                    lop = new LopHoc
                    {
                        TenLop = "CNTT K20",
                        Khoa = "Cong nghe thong tin"
                    };

                    db.LopHocs.Add(lop);
                    db.SaveChanges();
                }

                // Thêm sinh viên nếu chưa tồn tại
                var sinhVien = db.SinhViens.FirstOrDefault(
                    s => s.HoTen == "Nguyen Van A"
                         && s.MaLop == lop.MaLop);

                if (sinhVien == null)
                {
                    sinhVien = new SinhVien
                    {
                        HoTen = "Nguyen Van A",
                        Tuoi = 20,
                        MaLop = lop.MaLop
                    };

                    db.SinhViens.Add(sinhVien);
                    db.SaveChanges();
                }

                Console.WriteLine("DANH SACH SINH VIEN");
                Console.WriteLine("-----------------------------");

                var danhSach = db.SinhViens
                    .Include("LopHoc")
                    .ToList();

                foreach (var sv in danhSach)
                {
                    Console.WriteLine("Ma SV: " + sv.MaSV);
                    Console.WriteLine("Ho ten: " + sv.HoTen);
                    Console.WriteLine("Tuoi: " + sv.Tuoi);
                    Console.WriteLine("Ma lop: " + sv.MaLop);
                    Console.WriteLine("Ten lop: " + sv.LopHoc.TenLop);
                    Console.WriteLine("-----------------------------");
                }
            }

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
