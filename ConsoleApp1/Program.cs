using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //1.STRUCT KHAI BÁO LINH KIỆN 
    public struct LinhKien
    {
        public string MSLK;
        public string Name;
        public string LoaiLK;
        public decimal GiaNhap;
        public int TonKho;

        public LinhKien(string mslk, string name, string llk, decimal gn, int tk)
        {
            MSLK = mslk;
            Name = name;
            LoaiLK = llk;
            GiaNhap = gn;
            TonKho = tk;
        }

        public void HienThi()
        {
            Console.WriteLine($"{MSLK,-15} | {Name,-50} | {LoaiLK,-28} | {(GiaNhap.ToString("N0").Replace(',', '.')),20} đ | {TonKho,13}");
        }
    }

    //2.STRUCT KHỞI TẠO SORTEDLIST LƯU CÁC LOẠI LINH KIỆN 
    public struct ListLK
    {
        public SortedList<string, LinhKien> list;

        public void Initiallize()
        {
            list = new SortedList<string, LinhKien>();

            //1.Linh kien thu dong 
            list.Add("LK01", new LinhKien { MSLK = "LK01", Name = "Dien tro               (Resistor)", LoaiLK = "Linh kien thu dong", GiaNhap = 500, TonKho = 150 });
            list.Add("LK02", new LinhKien { MSLK = "LK02", Name = "tu dien                (Capacitor)", LoaiLK = "Linh kien thu dong", GiaNhap = 1200, TonKho = 80 });
            list.Add("LK03", new LinhKien { MSLK = "LK03", Name = "Cuon cam               (Inductor)", LoaiLK = "Linh kien thu dong", GiaNhap = 2500, TonKho = 45 });
            list.Add("LK04", new LinhKien { MSLK = "LK04", Name = "Bien tro               (Potentiometer)", LoaiLK = "Linh kien thu dong", GiaNhap = 3000, TonKho = 60 });
            list.Add("LK05", new LinhKien { MSLK = "LK05", Name = "Varistor", LoaiLK = "Linh kien thu dong", GiaNhap = 2800, TonKho = 35 });
            list.Add("LK06", new LinhKien { MSLK = "LK06", Name = "Thermistor", LoaiLK = "Linh kien thu dong", GiaNhap = 1500, TonKho = 55 });
            list.Add("LK07", new LinhKien { MSLK = "LK07", Name = "Cau chi                (Fuse)", LoaiLK = "Linh kien thu dong", GiaNhap = 800, TonKho = 120 });
            list.Add("LK08", new LinhKien { MSLK = "LK08", Name = "Transformer            (Bien ap)", LoaiLK = "Linh kien thu dong", GiaNhap = 25000, TonKho = 25 });

            //2.Linh kien Ban Dan 
            list.Add("LK09", new LinhKien { MSLK = "LK09", Name = "Diode                  (D)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 300, TonKho = 200 });
            list.Add("LK10", new LinhKien { MSLK = "LK10", Name = "Transistor             (Q)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 800, TonKho = 100 });
            list.Add("LK11", new LinhKien { MSLK = "LK11", Name = "Thyristor              (SCR)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 4500, TonKho = 30 });
            list.Add("LK12", new LinhKien { MSLK = "LK12", Name = "Triac", LoaiLK = "Linh kien Ban Dan", GiaNhap = 6500, TonKho = 40 });
            list.Add("LK13", new LinhKien { MSLK = "LK13", Name = "Diac", LoaiLK = "Linh kien Ban Dan", GiaNhap = 5800, TonKho = 45 });
            list.Add("LK14", new LinhKien { MSLK = "LK14", Name = "LED                    (Light Emitting Diode)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 250, TonKho = 280 });
            list.Add("LK15", new LinhKien { MSLK = "LK15", Name = "Photodiode", LoaiLK = "Linh kien Ban Dan", GiaNhap = 4200, TonKho = 35 });
            list.Add("LK16", new LinhKien { MSLK = "LK16", Name = "Zener Diode", LoaiLK = "Linh kien Ban Dan", GiaNhap = 600, TonKho = 90 });

            //3.Vi mach Tich hop
            list.Add("LK17", new LinhKien { MSLK = "LK17", Name = "IC Op-amp              (LM741, LM358)", LoaiLK = "Vi mach Tich hop", GiaNhap = 3200, TonKho = 42 });
            list.Add("LK18", new LinhKien { MSLK = "LK18", Name = "IC Timer 555", LoaiLK = "Vi mach Tich hop", GiaNhap = 2000, TonKho = 75 });
            list.Add("LK19", new LinhKien { MSLK = "LK19", Name = "IC Nguon               (LM7805, LM317)", LoaiLK = "Vi mach Tich hop", GiaNhap = 4000, TonKho = 35 });
            list.Add("LK20", new LinhKien { MSLK = "LK20", Name = "IC Logic               (AND, OR, NOT gates)", LoaiLK = "Vi mach Tich hop", GiaNhap = 1800, TonKho = 65 });
            list.Add("LK21", new LinhKien { MSLK = "LK21", Name = "Vi dieu khien          (Arduino, PIC, 8051)", LoaiLK = "Vi mach Tich hop", GiaNhap = 45000, TonKho = 20 });
            list.Add("LK22", new LinhKien { MSLK = "LK22", Name = "IC Khuech dai am thanh (LM386, TDA2030)", LoaiLK = "Vi mach Tich hop", GiaNhap = 5500, TonKho = 25 });
            list.Add("LK23", new LinhKien { MSLK = "LK23", Name = "IC Shift Register      (74HC595)", LoaiLK = "Vi mach Tich hop", GiaNhap = 6000, TonKho = 30 });

            //4.Linh kien Ket noi & Co khi
            list.Add("Lk24", new LinhKien { MSLK = "LK24", Name = "Jack cam               (Audio jack, DC jack)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 2500, TonKho = 65 });
            list.Add("LK25", new LinhKien { MSLK = "LK25", Name = "Cong tac               (Switch)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 1500, TonKho = 85 });
            list.Add("Lk26", new LinhKien { MSLK = "LK26", Name = "Nut nhan               (Push button)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 800, TonKho = 150 });
            list.Add("Lk27", new LinhKien { MSLK = "LK27", Name = "Den bao                (Indicator light)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 1200, TonKho = 95 });
            list.Add("Lk28", new LinhKien { MSLK = "LK28", Name = "Coi bao                (Buzzer)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 3800, TonKho = 40 });
            list.Add("Lk29", new LinhKien { MSLK = "LK29", Name = "Ro-le                  (Relay)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 8000, TonKho = 30 });
            list.Add("Lk30", new LinhKien { MSLK = "LK30", Name = "Dong co                (Motor DC, Servo, Stepper)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 28000, TonKho = 18 });

            //5.Cam bien
            list.Add("LK31", new LinhKien { MSLK = "LK31", Name = "Cam bien nhiet do      (LM35, DHT11)", LoaiLK = "Cam bien", GiaNhap = 35000, TonKho = 15 });
            list.Add("LK32", new LinhKien { MSLK = "LK32", Name = "Cam bien anh sang      (LDR, Phototransistor)", LoaiLK = "Cam bien", GiaNhap = 2000, TonKho = 70 });
            list.Add("LK33", new LinhKien { MSLK = "LK33", Name = "Cam bien chuyen dong   (PIR)", LoaiLK = "Cam bien", GiaNhap = 25000, TonKho = 18 });
            list.Add("LK34", new LinhKien { MSLK = "LK34", Name = "Cam bien sieu am       (HC-SR04)", LoaiLK = "Cam bien", GiaNhap = 18000, TonKho = 22 });
            list.Add("LK35", new LinhKien { MSLK = "LK35", Name = "Cam bien do am", LoaiLK = "Cam bien", GiaNhap = 15000, TonKho = 28 });
            list.Add("LK36", new LinhKien { MSLK = "LK36", Name = "Cam bien gia toc       (MPU6050)", LoaiLK = "Cam bien", GiaNhap = 45000, TonKho = 12 });

            //6.Hien thi
            list.Add("LK37", new LinhKien { MSLK = "LK37", Name = "LCD 16x2", LoaiLK = "Hien thi", GiaNhap = 32000, TonKho = 20 });
            list.Add("LK38", new LinhKien { MSLK = "LK38", Name = "LED 7 doan", LoaiLK = "Hien thi", GiaNhap = 4500, TonKho = 35 });
            list.Add("LK39", new LinhKien { MSLK = "LK39", Name = "Man hinh OLED", LoaiLK = "Hien thi", GiaNhap = 55000, TonKho = 15 });
            list.Add("LK40", new LinhKien { MSLK = "LK40", Name = "Matrix LED", LoaiLK = "Hien thi", GiaNhap = 12000, TonKho = 25 });

            //7.Dao dong & Thach anh
            list.Add("LK41", new LinhKien { MSLK = "LK41", Name = "Thach anh              (Crystal)", LoaiLK = "Dao dong & Thach anh", GiaNhap = 3000, TonKho = 60 });
            list.Add("LK42", new LinhKien { MSLK = "LK42", Name = "IC Tao dao dong", LoaiLK = "Dao dong & Thach anh", GiaNhap = 4500, TonKho = 40 });

            //8.Mach in & Phu kien
            list.Add("LK43", new LinhKien { MSLK = "LK43", Name = "Board mach             (PCB)", LoaiLK = "Mach in & Phu kien", GiaNhap = 8000, TonKho = 50 });
            list.Add("LK44", new LinhKien { MSLK = "LK44", Name = "Day cap ket noi", LoaiLK = "Mach in & Phu kien", GiaNhap = 1500, TonKho = 120 });
            list.Add("LK45", new LinhKien { MSLK = "LK45", Name = "De IC                  (IC Socket)", LoaiLK = "Mach in & Phu kien", GiaNhap = 800, TonKho = 100 });
            list.Add("LK46", new LinhKien { MSLK = "LK46", Name = "Heat sink", LoaiLK = "Mach in & Phu kien", GiaNhap = 2000, TonKho = 75 });
        }

        public void XuatDS()
        {
            Console.WriteLine("MA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
            Console.WriteLine("============================================================================================================================================");
            foreach (var a in list)
            {
                a.Value.HienThi();
            }
        }

        //Hàm về Menu
        public void VeMenu()
        {
            Console.WriteLine("\nNhan Enter de quay ve Menu...");
            Console.ReadKey();
            Console.Clear();
        }

        
    }

    //Phần của Nam
    // THÊM LINH KIỆN 
public struct THEM
{
    public void Them(ref DanhSach ds)
    {
        Console.Clear();
        LinhKien lk = new LinhKien();
        Console.WriteLine("\n=== THÊM LINH KIỆN MỚI ===");

        while (true)
        {
            Console.Write("\nNhập mã linh kiện: ");
            lk.MSLK = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(lk.MSLK))
            {
                Console.WriteLine("\nMa linh kien khong duoc de trong! Nhap lai: ");
                continue;
            }
            if (ds.list.ContainsKey(lk.MSLK))
            {
                Console.WriteLine("\nMa linh kien da ton tai! Nhap lai: ");
                continue;
            }
            break;
        }

        while (true)
        {
            Console.Write("Nhap ten linh kien: ");
            lk.Ten = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lk.Ten))
            {
                Console.WriteLine("\nTen linh kien khong duoc bo trong! Nhap lai: ");
                continue;
            }
            break;
        }

        while (true)
        {
            Console.Write("Nhap loai linh kien: ");
            lk.LoaiLK = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lk.LoaiLK))
            {
                Console.WriteLine("\nLoai linh kien khong duoc bo trong! Nhap lai: ");
                continue;
            }
            break;
        }

        while (true)
        {
            Console.Write("Nhap gia nhap: ");
            if (decimal.TryParse(Console.ReadLine(), out lk.GiaNhap) && lk.GiaNhap >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nGia nhap khong hop le! Nhap lai: ");
            }
        }

        while (true)
        {
            Console.Write("Nhap luong ton kho: ");
            if (int.TryParse(Console.ReadLine(), out lk.TonKho) && lk.TonKho >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nLuong ton kho khong hop le! Nhap lai: ");
            }
        }

        ds.list.Add(lk.MSLK, lk);
        Console.WriteLine("\nThem linh kien thanh cong!");
    }
}
    // CẬP NHẬT LINH KIỆN
public struct CAPNHAT
{
    public void CapNhatTen(ref DanhSach ds, string ma)
    {
        Console.Clear();
        if (ds.list.ContainsKey(ma))
        {
            LinhKien lk = ds.list[ma];
            Console.Write($"\nNhap ten moi cho ma {lk.MSLK}: ");

            string TenMoi;
            while (true)
            {
                TenMoi = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(TenMoi))
                {
                    Console.Write("\nKhong duoc bo trong! Nhap lai: ");
                    continue;
                }
                break;
            }

            lk.Ten = TenMoi;
            ds.list[ma] = lk;
            Console.WriteLine("\nCap nhat thanh cong!");
        }
        else
        {
            Console.WriteLine("\nKhong tim thay linh kien!");
        }
    }

    public void CapNhatLoai(ref DanhSach ds, string ma)
    {
        if (ds.list.ContainsKey(ma))
        {
            LinhKien lk = ds.list[ma];
            Console.Write($"\nNhap loai linh kien moi cho ma {lk.MSLK}: ");

            string LoaiMoi;
            while (true)
            {
                LoaiMoi = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(LoaiMoi))
                {
                    Console.Write("\nKhong duoc bo trong! Nhap lai: ");
                    continue;
                }
                break;
            }

            lk.LoaiLK = LoaiMoi;
            ds.list[ma] = lk;
            Console.WriteLine("\nCap nhat thanh cong!");
        }
        else
        {
            Console.WriteLine("\nKhong tim thay linh kien!");
        }
    }

    public void CapNhatGiaNhap(ref DanhSach ds, string ma)
    {
        if (ds.list.ContainsKey(ma))
        {
            LinhKien lk = ds.list[ma];
            Console.Write($"\nNhap gia nhap moi cho ma {lk.MSLK}: ");

            decimal giaMoi;
            while (true)
            {
                string input = Console.ReadLine().Replace(',', '.');
                if (decimal.TryParse(input, out giaMoi) && giaMoi >= 0)
                {
                    break;
                }
                else
                {
                    Console.Write("\nGia nhap khong hop le! Nhap lai: ");
                }
            }

            lk.GiaNhap = giaMoi;
            ds.list[ma] = lk;
            Console.WriteLine("\nCap nhat thanh cong!");
        }
        else
        {
            Console.WriteLine("\nKhong tim thay linh kien!");
        }
    }

    public void CapNhatTonKho(ref DanhSach ds, string ma)
    {
        if (ds.list.ContainsKey(ma))
        {
            LinhKien lk = ds.list[ma];
            Console.Write($"\nNhap so ton kho moi cho ma {lk.MSLK}: ");

            int tonKhoMoi;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out tonKhoMoi) && tonKhoMoi >= 0)
                {
                    break;
                }
                else
                {
                    Console.Write("\nSo ton kho khong hop le! Nhap lai: ");
                }
            }

            lk.TonKho = tonKhoMoi;
            ds.list[ma] = lk;
            Console.WriteLine("\nCap nhat thanh cong!");
        }
        else
        {
            Console.WriteLine("\nKhong tim thay linh kien!");
        }
    }

    public void CapNhat(ref DanhSach ds)
    {
        Console.WriteLine("\n=== CẬP NHẬT LINH KIỆN ===");

        // Nhập mã linh kiện trước
        Console.Write("Nhap ma linh kien muon cap nhat: ");
        string ma = Console.ReadLine();

        if (!ds.list.ContainsKey(ma))
        {
            Console.WriteLine("\nKhong tim thay linh kien!");
            return;
        }

        // Hiển thị thông tin linh kiện hiện tại
        Console.WriteLine("\nThong tin linh kien hien tai:");
        ds.list[ma].HienThi();

        // Hiển thị menu sửa
        bool tiepTuc = true;
        while (tiepTuc)
        {
            Console.WriteLine("\n=== MENU CAP NHAT LINH KIEN ===");
            Console.WriteLine("1. Cap nhat ten");
            Console.WriteLine("2. Cap nhat loai");
            Console.WriteLine("3. Cap nhat gia nhap");
            Console.WriteLine("4. Cap nhat ton kho");
            Console.WriteLine("5. Quay ve menu chinh");
            Console.Write("Chon cach cap nhat (1-5): ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    CapNhatTen(ref ds, ma);
                    break;
                case "2":
                    CapNhatLoai(ref ds, ma);
                    break;
                case "3":
                    CapNhatGiaNhap(ref ds, ma);
                    break;
                case "4":
                    CapNhatTonKho(ref ds, ma);
                    break;
                case "5":
                    tiepTuc = false;
                    break;
                default:
                    Console.WriteLine("\nLua chon khong hop le!");
                    break;
            }
            if (tiepTuc)
            {
                Console.WriteLine("\nNhan Enter de tiep tuc sua...");
                Console.ReadLine();
            }
        }
    }
}
// XÓA LINH KIỆN 
public struct XOA
{
    public void XoaLinhKien(ref DanhSach ds)
    {
        Console.Clear();
        Console.Write("Nhap ma linh kien muon xoa: ");
        string ma = Console.ReadLine();

        if (ds.list.Remove(ma))
        {
            Console.WriteLine("\nDa xoa linh kien!");
        }
        else
        {
            Console.WriteLine("Khong tim thay ma linh kien can xoa!");
        }
    }
}

    //Phần của Vy
public struct SAPXEPLK
{
    //Hàm sắp xếp theo loại linh kiện 
    public void SapXepTheoLoai(ref ListLK ds)
    {
        var sxtl = ds.list.Values.OrderBy(B => B.LoaiLK).ToList();
        Console.WriteLine("Danh sach sap xep theo loai linh kien: ");

        Console.WriteLine("\nMA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
        Console.WriteLine("============================================================================================================================================");

        int stt = 1;
        foreach (var a in sxtl)
        {
            Console.Write($"{stt++,2}. ");
            a.HienThi();
        }
    }

    //Hàm sắp xếp theo giá nhập 
    public void SapXepTheoGiaNhap(bool tanggiamGN, ref ListLK ds)
    {
        var sxgn = tanggiamGN
            ? ds.list.Values.OrderBy(B => B.GiaNhap).ToList()
            : ds.list.Values.OrderByDescending(B => B.GiaNhap).ToList();

        Console.WriteLine($"Danh sach sap xep theo gia nhap ({(tanggiamGN ? "tang dan" : "giam dan")}): ");

        Console.WriteLine("\nMA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
        Console.WriteLine("============================================================================================================================================");

        int stt = 1;
        foreach (var a in sxgn)
        {
            Console.Write($"{stt++,2}. ");
            a.HienThi();
        }
    }

    //Menu sắp xếp theo giá nhập 
    public void MenuSapXepGiaNhap(ref ListLK ds)
    {
        Console.WriteLine("=== MENU SAP XEP THEO GIA NHAP ===");
        Console.WriteLine("==================================");
        Console.WriteLine("1. Sap xep tang dan");
        Console.WriteLine("2. Sap xep giam dan");
        Console.Write("Lua chon 1 hoac 2: ");

        string chon = Console.ReadLine();

        Console.Clear();

        switch (chon)
        {
            case "1":
                {
                    SapXepTheoGiaNhap(true, ref ds);
                    break;
                }
            case "2":
                {
                    SapXepTheoGiaNhap(false, ref ds);
                    break;
                }
            default:
                {
                    Console.WriteLine("\nLua chon khong hop le!");
                    break;
                }
        }
    }
    Console.WriteLine("\nMA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
        Console.WriteLine("============================================================================================================================================");

        int stt = 1;
        foreach (var a in sxtk)
        {
            Console.Write($"{stt++,2}. ");
            a.HienThi();
        }
    }

    //Menu sắp xếp theo tồn kho 
    public void MenuSapXepTonKho(ref ListLK ds)
    {
        Console.WriteLine("=== MENU SAP XEP THEO TON KHO ===");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Sap xep tang dan");
        Console.WriteLine("2. Sap xep giam dan");
        Console.Write("Lua chon 1 hoac 2: ");
        string chon = Console.ReadLine();

        Console.Clear();

        switch (chon)
        {
            case "1":
                {
                    SapXepTonKho(true, ref ds);
                    break;
                }
            case "2":
                {
                    SapXepTonKho(false, ref ds);
                    break;
                }
            default:
                {
                    Console.WriteLine("\nLua chon khong hop le!");
                    break;
                }
        }
    }

    //Menu tất cả sắp xếp 
    public void SapXep(ref ListLK ds)
    {
        Console.WriteLine("=== MENU SAP XEP ===");
        Console.WriteLine("====================");
        Console.WriteLine("1. Sap xep theo loai");
        Console.WriteLine("2. Sap xep theo gia nhap");
        Console.WriteLine("3. Sap xep theo so ton kho");
        Console.Write("Lua chon cach sap xep (1-3): ");
        string chon = Console.ReadLine();

        Console.Clear();

        switch (chon)
        {
            case "1":
                {
                    SapXepTheoLoai(ref ds);
                    break;
                }
            case "2":
                {
                    MenuSapXepGiaNhap(ref ds);
                    break;
                }
            case "3":
                {
                    MenuSapXepTonKho(ref ds);
                    break;
                }
            default:
                {
                    
                    Console.WriteLine("\nLua chon khong hop le!");
                    break;
                }
        }
    }
}

    //Hàm sắp xếp theo tồn kho 
    public void SapXepTonKho(bool tanggiamTK, ref ListLK ds)
    {
        var sxtk = tanggiamTK
            ? ds.list.Values.OrderBy(B => B.TonKho).ToList()
            : ds.list.Values.OrderByDescending(B => B.TonKho).ToList();

        Console.WriteLine($"Danh sach sap xep theo so ton kho ({(tanggiamTK ? "tang dan" : "giam dan")}): ");
    //Phần của Trọng STRUCT TIMKIEM 
    public struct TIMKIEM
    {
        //Hàm tìm kiếm theo loại 
        public void TimKiemTheoLoai(ref ListLK ds)
        {
            Console.WriteLine("\n=== CHON LOAI LINH KIEN ===");
            Console.WriteLine("===========================");
            Console.WriteLine("1. Linh kien thu dong");
            Console.WriteLine("2. Linh kien Ban Dan");
            Console.WriteLine("3. Vi mach Tich hop");
            Console.WriteLine("4. Linh kien Ket noi & Co khi");
            Console.WriteLine("5. Cam bien");
            Console.WriteLine("6. Hien thi");
            Console.WriteLine("7. Dao dong & Thach anh");
            Console.WriteLine("8. Mach in & Phu kien");
            Console.Write("Nhap lua chon (1–8): ");

            string chon = Console.ReadLine();

            Console.Clear();

            string loai = "";

            switch (chon)
            {
                case "1":
                    loai = "Linh kien thu dong";
                    break;
                case "2":
                    loai = "Linh kien Ban Dan";
                    break;
                case "3":
                    loai = "Vi mach Tich hop";
                    break;
                case "4":
                    loai = "Linh kien Ket noi & Co khi";
                    break;
                case "5":
                    loai = "Cam bien";
                    break;
                case "6":
                    loai = "Hien thi";
                    break;
                case "7":
                    loai = "Dao dong & Thach anh";
                    break;
                case "8":
                    loai = "Mach in & Phu kien";
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }

            Console.WriteLine($"\nDanh sach loai {loai}: ");
            Console.WriteLine("\nMA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
            Console.WriteLine("============================================================================================================================================");
            foreach (var a in ds.list)
            {
                if (a.Value.LoaiLK == loai)
                {
                    a.Value.HienThi();
                }
            }
        }

        //Hàm tìm kiếm theo giá nhập 
        public void TimKiemGiaNhap(ref ListLK ds)
        {
            decimal minGiaNhap = ds.list.Min(B => B.Value.GiaNhap);
            decimal maxGiaNhap = ds.list.Max(B => B.Value.GiaNhap);

            Console.Write($"Nhap gia nhap toi da can tim trong kho ({minGiaNhap.ToString("N0").Replace(',', '.')} - {maxGiaNhap.ToString("N0").Replace(',', '.')}): ");
            int MaxGiaNhap;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out MaxGiaNhap) || MaxGiaNhap < minGiaNhap)
                {
                    Console.Write("\nGia nhap khong hop le! Nhap lai: ");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"\nDanh sach linh kien co gia nhap tu {minGiaNhap} den {MaxGiaNhap} la: ");
            bool TimThayGN = false;

            Console.WriteLine("\nMA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
            Console.WriteLine("============================================================================================================================================");
            foreach (var a in ds.list)
            {
                if (a.Value.GiaNhap >= 0 && a.Value.GiaNhap <= MaxGiaNhap)
                {
                    a.Value.HienThi();
                    TimThayGN = true;
                }
            }

            if (!TimThayGN)
            {
                Console.WriteLine("\nKhong tim thay linh kien trong khoan nay!");
            }
        }

        //Hàm tìm kiếm theo lượng tồn kho 
        public void TimKiemTonKho(ref ListLK ds)
        {
            int minTonKho = ds.list.Min(B => B.Value.TonKho);
            int maxTonKho = ds.list.Max(B => B.Value.TonKho);

            Console.Write($"Nhap so luong ton kho toi da can tim ({minTonKho} - {maxTonKho}): ");
            int MaxGiaTonKho;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out MaxGiaTonKho) || MaxGiaTonKho < minTonKho)
                {
                    Console.Write("\nSo luong ton kho khong hợp le! Nhap lai: ");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"\nDanh sach linh kien co ton kho tu {minTonKho} den {MaxGiaTonKho}");
            bool TimThayTK = false;

            Console.WriteLine("\nMA LINH KIEN    | TEN LINH KIEN                                      | LOAI LINH KIEN               | GIA NHAP LINH KIEN     | LUONG TON KHO");
            Console.WriteLine("============================================================================================================================================");
            foreach (var a in ds.list)
            {
                if (a.Value.TonKho >= 1 && a.Value.TonKho <= MaxGiaTonKho)
                {
                    a.Value.HienThi();
                    TimThayTK = true;
                }
            }

            if (!TimThayTK)
            {
                Console.WriteLine("\nKhong tim thay linh kien tồn kho trong khoang nay!");
            }
        }

        //Hàm menu tìm kiếm 
        public void MenuTimKiem(ref ListLK ds)
        {
            Console.WriteLine("\n=== MENU TiM KIEM LINH KIEN ===");
            Console.WriteLine("===============================");
            Console.WriteLine("1. Tim theo loai linh kien");
            Console.WriteLine("2. Tim theo gia nhap");
            Console.WriteLine("3. Tim theo ton kho");
            Console.Write("Nhap lua chọn (1-3): ");
            string chon = Console.ReadLine();

            Console.Clear();

            switch (chon)
            {
                case "1":
                    {
                        TimKiemTheoLoai(ref ds);
                        break;
                    }
                case "2":
                    {
                        TimKiemGiaNhap(ref ds);
                        break;
                    }
                case "3":
                    {
                        TimKiemTonKho(ref ds);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Lua chọn khong hợp le!");
                        break;
                    }
            }
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ListLK a = new ListLK();
            a.Initiallize();
            

            int use;
            do
            {
                Console.WriteLine("\n~~~ MENU QUAN LY LINH KIEN ĐIEN TU ~~~");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Bang tat ca linh kien co trong kho");
                Console.WriteLine("2. Them linh kien");
                Console.WriteLine("3. Tim kiem linh kien");
                Console.WriteLine("4. Cap nhat linh kien");
                Console.WriteLine("5. Sap xep linh kien");
                Console.WriteLine("6. Xoa linh kien");
                Console.WriteLine("7. Lap rap thiet bi");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");

                if (!int.TryParse(Console.ReadLine(), out use))
                {
                    use = -1;
                }

                Console.Clear();

                switch (use)
                {
                    case 1:
                        {
                            a.XuatDS();
                            a.VeMenu();
                            break;
                        }
                    case 2:
                        {
                            b.Them(ref a);
                            a.VeMenu();
                            break;
                        }
                    case 3:
                        {
                            
                            break;
                        }
                    case 4:
                        {
                           d.CapNhat(ref a);
                            a.VeMenu();
                            break;
                        }
                    case 5:
                        {
                            
                            break;
                        }
                    case 6:
                        {
                            f.XoaLinhKien(ref a);
                            a.VeMenu();
                            break;
                        }
                    case 7:
                        {
                            
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lua chon khong hợp le!");
                            break;
                        }
                }
            } while (use != 0);

            Console.ReadKey();
        }
    }
}
