using System.Security.Cryptography.X509Certificates;
using System.Text;
using QLDSHocSinh.Entities;

namespace QLDSHocSinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<HocSinh> hocSinhs = new List<HocSinh>();
            hocSinhs.Add(new HocSinh(1974, "Minh", 16));
            hocSinhs.Add(new HocSinh(3772, "Vũ", 30));
            hocSinhs.Add(new HocSinh(1912, "Mi", 21));
            hocSinhs.Add(new HocSinh(8524, "Nghi", 20));
            hocSinhs.Add(new HocSinh(3267, "An", 18));

            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("MENU truy vấn");
                Console.WriteLine("1. In ra danh sách toàn bộ học sinh");
                Console.WriteLine("2. Tìm và in danh sách các bạn học sinh có tuổi từ 15 - 18");
                Console.WriteLine("3. Tìm và in danh sách các bạn học sinh có tên bắt đầu bằng chữ A");
                Console.WriteLine("4. Tính tổng tuổi của tất cả sinh viên trong danh sách ");
                Console.WriteLine("5. Tìm và in ra học sinh có tuổi lớn nhất ");
                Console.WriteLine("6. Sắp xếp danh sách học sinh tăng dần theo tuổi và in ra ");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Nhập lựa chọn");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        InDS(hocSinhs);
                        break;
                    case 2:
                        InDs15_18(hocSinhs);
                        break;
                    case 3:
                        DsBatDauA(hocSinhs);
                        break;
                    case 4:
                        TongTuoi(hocSinhs);
                        break;
                    case 5:
                        HocSinhTuoiLonNhat(hocSinhs);
                        break;
                    case 6:
                        SapXepTheoTuoiVaIn(hocSinhs);
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn Sai");
                        break;
                }
            }
        }
        static void InDS(List<HocSinh> hocSinhs)
        {
            foreach (var item in hocSinhs)
            {
                Console.WriteLine(item);
            }
        }

        //Tìm và in danh sách các bạn học sinh có tuổi từ 15 - 18
        static void InDs15_18(List<HocSinh> hocSinhs) 
        {
            var ListAge15_18 = hocSinhs.Where(h => h.Age >= 15 && h.Age <= 18);
            foreach (var item in ListAge15_18)
            {
                Console.WriteLine(item);
            }
        }

        //Tìm và in danh sách các bạn học sinh có tên bắt đầu bằng chữ "A"
        static void DsBatDauA(List<HocSinh> hocSinhs)
        {
            var ListNameA = hocSinhs.Where(h => h.Name.StartsWith("A"));
            foreach (var item in ListNameA)
            {
                Console.WriteLine(item);
            }
        }

        //Tính tổng tuổi của tất cả sinh viên trong danh sách
        static void TongTuoi (List<HocSinh> hocSinhs)
        {
            var tongTuoi = hocSinhs.Sum(h => h.Age);
            Console.WriteLine($"Tổng tuổi: {tongTuoi}");
        }

        //Tìm và in ra học sinh có tuổi lớn nhất
        static void HocSinhTuoiLonNhat(List<HocSinh> hocSinhs)
        {
            var tuoiLonNhat = hocSinhs.OrderByDescending(h => h.Age).FirstOrDefault();

            if (tuoiLonNhat != null)
            {
                Console.WriteLine($"Học sinh có tuổi lớn nhất: {tuoiLonNhat.Id} | {tuoiLonNhat.Name} | {tuoiLonNhat.Age} ");
            }
        }

        //sắp xếp danh sách học sinh tăng dần theo tuổi và in ra
        static void SapXepTheoTuoiVaIn(List<HocSinh> hocSinhs)
        {
            var sapxeptheotuoi = hocSinhs.OrderBy(h => h.Age).ToList();
            foreach (var item in sapxeptheotuoi)
            {
                Console.WriteLine(item);
            }
        }
}
}
