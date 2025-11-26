using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao
{
    //1.STRUCT KHAI BÁO LINH KIỆN 
    public struct LinhKien
    {
        public string MSLK;
        public string Name;
        public string LoaiLK;
        public decimal GiaNhap;
        public int TonKho;
        public bool TrangThai;
        public string GhiChu;
        

        public LinhKien(string mslk, string name, string llk, decimal gn, int tk, bool tt, string gc)
        {
            MSLK = mslk;
            Name = name;
            LoaiLK = llk;
            GiaNhap = gn;
            TonKho = tk;
            TrangThai = tt;
            GhiChu = gc;
        }

        public void HienThi()
        {
            string TrangThaiText = TrangThai ? "Con hang" : "Het hang";
            Console.WriteLine($"║ {MSLK,-15} ║ {Name,-50} ║ {LoaiLK,-28} ║ {(GiaNhap.ToString("N0").Replace(',', '.')),20} đ ║ {TonKho,13} ║ {TrangThaiText,-15} ║ {GhiChu,-35} ║");

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
            list.Add("PT-DT", new LinhKien { MSLK = "PT-DT", Name = "Dien tro               (Resistor)", LoaiLK = "Linh kien thu dong", GiaNhap = 500, TonKho = 150, TrangThai = true, GhiChu = "" });
            list.Add("PT-TD", new LinhKien { MSLK = "PT-TD", Name = "tu dien                (Capacitor)", LoaiLK = "Linh kien thu dong", GiaNhap = 1200, TonKho = 80, TrangThai = true, GhiChu = "" });
            list.Add("PT-CC", new LinhKien { MSLK = "PT-CC", Name = "Cuon cam               (Inductor)", LoaiLK = "Linh kien thu dong", GiaNhap = 2500, TonKho = 45, TrangThai = true, GhiChu = "" });
            list.Add("PT-BT", new LinhKien { MSLK = "PT-BT", Name = "Bien tro               (Potentiometer)", LoaiLK = "Linh kien thu dong", GiaNhap = 3000, TonKho = 60 , TrangThai = true, GhiChu = ""  });
            list.Add("PT-Va", new LinhKien { MSLK = "PT-Va", Name = "Varistor", LoaiLK = "Linh kien thu dong", GiaNhap = 2800, TonKho = 35 , TrangThai = true, GhiChu = "" });
            list.Add("PT-Th", new LinhKien { MSLK = "PT-Th", Name = "Thermistor", LoaiLK = "Linh kien thu dong", GiaNhap = 1500, TonKho = 55 , TrangThai = true, GhiChu = "" });
            list.Add("PT-CaCh", new LinhKien { MSLK = "PT-CaCh", Name = "Cau chi                (Fuse)", LoaiLK = "Linh kien thu dong", GiaNhap = 800, TonKho = 120 , TrangThai = true, GhiChu = "" });
            list.Add("PT-Tr", new LinhKien { MSLK = "PT-Tr", Name = "Transformer            (Bien ap)", LoaiLK = "Linh kien thu dong", GiaNhap = 25000, TonKho = 25 , TrangThai = true, GhiChu = "" });

            //2.Linh kien Ban Dan 
            list.Add("SD-Di", new LinhKien { MSLK = "SD-Di", Name = "Diode                  (D)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 300, TonKho = 200, TrangThai = true, GhiChu = "" });
            list.Add("SD-Tr", new LinhKien { MSLK = "SD-Tr", Name = "Transistor             (Q)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 800, TonKho = 100 , TrangThai = true, GhiChu = "" });
            list.Add("SD-Th", new LinhKien { MSLK = "SD-Th", Name = "Thyristor              (SCR)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 4500, TonKho = 30 , TrangThai = true, GhiChu = "" });
            list.Add("SD-Tri", new LinhKien { MSLK = "SD-Tri", Name = "Triac", LoaiLK = "Linh kien Ban Dan", GiaNhap = 6500, TonKho = 40 , TrangThai = true, GhiChu = "" });
            list.Add("SD-Dia", new LinhKien { MSLK = "SD-Dia", Name = "Diac", LoaiLK = "Linh kien Ban Dan", GiaNhap = 5800, TonKho = 45 , TrangThai = true, GhiChu = "" });
            list.Add("SD-Le", new LinhKien { MSLK = "SD-Le", Name = "LED                    (Light Emitting Diode)", LoaiLK = "Linh kien Ban Dan", GiaNhap = 250, TonKho = 280 , TrangThai = true, GhiChu = "" });
            list.Add("SD-Ph", new LinhKien { MSLK = "SD-Ph", Name = "Photodiode", LoaiLK = "Linh kien Ban Dan", GiaNhap = 4200, TonKho = 35 , TrangThai = true, GhiChu = "" });
            list.Add("SD-ZD", new LinhKien { MSLK = "SD-ZD", Name = "Zener Diode", LoaiLK = "Linh kien Ban Dan", GiaNhap = 600, TonKho = 90 , TrangThai = true, GhiChu = "" });

            //3.Vi mach Tich hop
            list.Add("IC-OA", new LinhKien { MSLK = "IC-OA", Name = "IC Op-amp              (LM741, LM358)", LoaiLK = "Vi mach Tich hop", GiaNhap = 3200, TonKho = 42 , TrangThai = true, GhiChu = "" });
            list.Add("IC-T5", new LinhKien { MSLK = "IC-T5", Name = "IC Timer 555", LoaiLK = "Vi mach Tich hop", GiaNhap = 2000, TonKho = 75 , TrangThai = true , GhiChu = "" });
            list.Add("IC-Ng", new LinhKien { MSLK = "IC-Ng", Name = "IC Nguon               (LM7805, LM317)", LoaiLK = "Vi mach Tich hop", GiaNhap = 4000, TonKho = 35 , TrangThai = true, GhiChu = "" });
            list.Add("IC-Lo", new LinhKien { MSLK = "IC-Lo", Name = "IC Logic               (AND, OR, NOT gates)", LoaiLK = "Vi mach Tich hop", GiaNhap = 1800, TonKho = 65 , TrangThai = true, GhiChu = "" });
            list.Add("IC-VDK", new LinhKien { MSLK = "IC-VDK", Name = "Vi dieu khien          (Arduino, PIC, 8051)", LoaiLK = "Vi mach Tich hop", GiaNhap = 45000, TonKho = 20 , TrangThai = true, GhiChu = "" });
            list.Add("IC-KD", new LinhKien { MSLK = "IC-KD", Name = "IC Khuech dai am thanh (LM386, TDA2030)", LoaiLK = "Vi mach Tich hop", GiaNhap = 5500, TonKho = 25 , TrangThai = true, GhiChu = "" });
            list.Add("IC-SR", new LinhKien { MSLK = "IC-SR", Name = "IC Shift Register      (74HC595)", LoaiLK = "Vi mach Tich hop", GiaNhap = 6000, TonKho = 30 , TrangThai = true, GhiChu = "" });

            //4.Linh kien Ket noi & Co khi
            list.Add("ME-JC", new LinhKien { MSLK = "ME-JC", Name = "Jack cam               (Audio jack, DC jack)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 2500, TonKho = 65 , TrangThai = true, GhiChu = "" });
            list.Add("ME-CT", new LinhKien { MSLK = "ME-CT", Name = "Cong tac               (Switch)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 1500, TonKho = 85 , TrangThai = true, GhiChu = "" });
            list.Add("ME-NN", new LinhKien { MSLK = "ME-NN", Name = "Nut nhan               (Push button)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 800, TonKho = 150 , TrangThai = true, GhiChu = "" });
            list.Add("ME-DB", new LinhKien { MSLK = "ME-DB", Name = "Den bao                (Indicator light)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 1200, TonKho = 95 , TrangThai = true, GhiChu = "" });
            list.Add("ME-CB", new LinhKien { MSLK = "ME-CB", Name = "Coi bao                (Buzzer)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 3800, TonKho = 40 , TrangThai = true, GhiChu = "" });
            list.Add("ME-RL", new LinhKien { MSLK = "ME-RL", Name = "Ro-le                  (Relay)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 8000, TonKho = 30 , TrangThai = true, GhiChu = "" });
            list.Add("ME-DC", new LinhKien { MSLK = "ME-DC", Name = "Dong co                (Motor DC, Servo, Stepper)", LoaiLK = "Linh kien Ket noi & Co khi", GiaNhap = 28000, TonKho = 18 , TrangThai = true, GhiChu = "" });

            //5.Cam bien
            list.Add("SS-CBND", new LinhKien { MSLK = "SS-CBND", Name = "Cam bien nhiet do      (LM35, DHT11)", LoaiLK = "Cam bien", GiaNhap = 35000, TonKho = 15 , TrangThai = true, GhiChu = "" });
            list.Add("SS-CBAS", new LinhKien { MSLK = "SS-CBAS", Name = "Cam bien anh sang      (LDR, Phototransistor)", LoaiLK = "Cam bien", GiaNhap = 2000, TonKho = 70 , TrangThai = true, GhiChu = "" });
            list.Add("SS-CBCD", new LinhKien { MSLK = "SS-CBCD", Name = "Cam bien chuyen dong   (PIR)", LoaiLK = "Cam bien", GiaNhap = 25000, TonKho = 18 , TrangThai = true, GhiChu = "" });
            list.Add("SS-CBSA", new LinhKien { MSLK = "SS-CBSA", Name = "Cam bien sieu am       (HC-SR04)", LoaiLK = "Cam bien", GiaNhap = 18000, TonKho = 22 , TrangThai = true, GhiChu = "" });
            list.Add("SS-CBDA", new LinhKien { MSLK = "SS-CBDA", Name = "Cam bien do am", LoaiLK = "Cam bien", GiaNhap = 15000, TonKho = 28 , TrangThai = true, GhiChu = "" });
            list.Add("SS-CBGT", new LinhKien { MSLK = "SS-CBGT", Name = "Cam bien gia toc       (MPU6050)", LoaiLK = "Cam bien", GiaNhap = 45000, TonKho = 12 , TrangThai = true, GhiChu = "" });

            //6.Hien thi
            list.Add("DSP-L1", new LinhKien { MSLK = "DSP-L1", Name = "LCD 16x2", LoaiLK = "Hien thi", GiaNhap = 32000, TonKho = 20 , TrangThai = true, GhiChu = "" });
            list.Add("DSP-L7D", new LinhKien { MSLK = "DSP-L7D", Name = "LED 7 doan", LoaiLK = "Hien thi", GiaNhap = 4500, TonKho = 35 , TrangThai = true, GhiChu = "" });
            list.Add("DSP-MHO", new LinhKien { MSLK = "DSP-MHO", Name = "Man hinh OLED", LoaiLK = "Hien thi", GiaNhap = 55000, TonKho = 15 , TrangThai = true, GhiChu = "" });
            list.Add("DSP-ML", new LinhKien { MSLK = "DSP-ML", Name = "Matrix LED", LoaiLK = "Hien thi", GiaNhap = 12000, TonKho = 25 , TrangThai = true, GhiChu = "" });

            //7.Dao dong & Thach anh
            list.Add("OSC-TA", new LinhKien { MSLK = "OSC-TA", Name = "Thach anh              (Crystal)", LoaiLK = "Dao dong & Thach anh", GiaNhap = 3000, TonKho = 60 , TrangThai = true, GhiChu = "" });
            list.Add("OSC-DD", new LinhKien { MSLK = "OSC-DD", Name = "IC dao dong", LoaiLK = "Dao dong & Thach anh", GiaNhap = 4500, TonKho = 40 , TrangThai = true, GhiChu = "" });

            //8.Mach in & Phu kien
            list.Add("PCB-BM", new LinhKien { MSLK = "PCB-BM", Name = "Board mach             (PCB)", LoaiLK = "Mach in & Phu kien", GiaNhap = 8000, TonKho = 50 , TrangThai = true, GhiChu = "" });
            list.Add("PCB-KN", new LinhKien { MSLK = "PCB-KN", Name = "Day cap ket noi", LoaiLK = "Mach in & Phu kien", GiaNhap = 1500, TonKho = 120 , TrangThai = true, GhiChu = "" });
            list.Add("PCB-DI", new LinhKien { MSLK = "PCD-DI", Name = "De IC                  (IC Socket)", LoaiLK = "Mach in & Phu kien", GiaNhap = 800, TonKho = 100 , TrangThai = true, GhiChu = "" });
            list.Add("PCB-HS", new LinhKien { MSLK = "PCD-HS", Name = "Heat sink", LoaiLK = "Mach in & Phu kien", GiaNhap = 2000, TonKho = 75 , TrangThai = true, GhiChu = "" });
        }

        

        

        //Hàm lấy danh sách 
        public List<LinhKien> LayDanhSach()
        {
            return new List<LinhKien>(list.Values);
        }
    }

    //STRUCT XUẤT DANH SÁCH LINH KIỆN
    public struct XUATDSLK
    {
        public void xuat(ref ListLK ds)
        {
            int stt = 1;
            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");
            foreach (var a in ds.list)
            {
                Console.Write($"║ {stt++,5}. ");
                a.Value.HienThi();
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            CHUCNANGMENU.VeMenu();
        }
    }

    //STRUCT CHỨC NĂNG MENU 
    public struct CHUCNANGMENU
    {
        public static void VeMenu()
        {
            Console.WriteLine("\nNhan ENTER de ve menu chinh...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
        }

        public static int ChoChon()
        {
            Console.WriteLine("\n──────────────────────────────");
            Console.WriteLine("Nhấn ESC để quay lại");
            Console.WriteLine("Nhấn ENTER để về menu chính");
            Console.WriteLine("──────────────────────────────");

            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape) return 1; // quay lại
                if (key == ConsoleKey.Enter) return 2; // về menu chính
            }
        }
    }

    //Phần của Thành Nam 
    public struct NHAPLK
    {
        public void Them(ref ListLK ds)
        {
            
            LinhKien lk = new LinhKien();
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║  === CHON LOAI LINH KIEN CAN NHAP ===  ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║ 1. Linh kien thu dong                  ║");
            Console.WriteLine("║ 2. Linh kien Ban Dan                   ║");
            Console.WriteLine("║ 3. Vi mach Tich hop                    ║");
            Console.WriteLine("║ 4. Linh kien Ket noi & Co khi          ║");
            Console.WriteLine("║ 5. Cam bien                            ║");
            Console.WriteLine("║ 6. Hien thi                            ║");
            Console.WriteLine("║ 7. Dao dong & Thach anh                ║");
            Console.WriteLine("║ 8. Mach in & Phu kien                  ║");
            Console.WriteLine("║ Esc. Quay lai                          ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("Nhap lua chon (1–8): ");

            ConsoleKeyInfo key = Console.ReadKey(true);

            Console.Clear();

            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }

            string loai = "";

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    loai = "Linh kien thu dong";
                    break;
                case ConsoleKey.D2:
                    loai = "Linh kien Ban Dan";
                    break;
                case ConsoleKey.D3:
                    loai = "Vi mach Tich hop";
                    break;
                case ConsoleKey.D4:
                    loai = "Linh kien Ket noi & Co khi";
                    break;
                case ConsoleKey.D5:
                    loai = "Cam bien";
                    break;
                case ConsoleKey.D6:
                    loai = "Hien thi";
                    break;
                case ConsoleKey.D7:
                    loai = "Dao dong & Thach anh";
                    break;
                case ConsoleKey.D8:
                    loai = "Mach in & Phu kien";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lua chon khong hop le! Chon lai: ");
                    return;
            }

            string TenNguoiNhap;
            while (true)
            {
                Console.Write("\nNhap ten nguoi nhap: ");
                TenNguoiNhap = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(TenNguoiNhap))
                {
                    Console.WriteLine("\nTen nguoi nhap khong duoc bo trong! Nhap lai: ");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Nhap ma linh kiện: ");
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
                lk.Name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(lk.Name))
                {
                    Console.WriteLine("\nTen linh kien khong duoc bo trong! Nhap lai: ");
                    continue;
                }
                break;
            }

            lk.LoaiLK = loai;

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

            lk.TrangThai = lk.TonKho > 0 ? true : false;
            lk.GhiChu = $"Nguoi nhap: {TenNguoiNhap}";
            ds.list.Add(lk.MSLK, lk);
            Console.WriteLine("\nThem linh kien thanh cong!");

            int chon = CHUCNANGMENU.ChoChon();
            if (chon == 1)
            {
                Them(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }
    }

    // SỬA
    public struct SUA
    {
        public void CapNhatTen(ref ListLK ds, string ma)
        {
            Console.Clear();
            Console.WriteLine("\nThong tin linh kien hien tai:");
            Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            ds.list[ma].HienThi();

            Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            if (ds.list.ContainsKey(ma))
            {
                LinhKien lk = ds.list[ma];
                Console.Write($"\nNhap ten moi cho ma {lk.MSLK}: ");

                string tenMoi;
                while (true)
                {
                    tenMoi = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(tenMoi))
                    {
                        Console.Write("\nKhong duoc bo trong! Nhap lai: ");
                        continue;
                    }
                    break;
                }

                lk.Name = tenMoi;
                ds.list[ma] = lk;
                Console.WriteLine("\nCap nhat thanh cong!");
                Console.WriteLine("\nThong tin linh kien hien tai:");
                Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
                Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
                Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

                ds.list[ma].HienThi();

                Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("\nKhong tim thay linh kien!");
            }

            int chon = CHUCNANGMENU.ChoChon();

            if (chon == 1)
            {
                MenuCapNhat(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        public void CapNhatLoai(ref ListLK ds, string ma)
        {
            Console.Clear();
            Console.WriteLine("\nThong tin linh kien hien tai:");
            Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            ds.list[ma].HienThi();

            Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            if (ds.list.ContainsKey(ma))
            {
                LinhKien lk = ds.list[ma];
                Console.Write($"\nNhap loai linh kien moi cho ma {lk.MSLK}: ");

                string loaiMoi;
                while (true)
                {
                    loaiMoi = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(loaiMoi))
                    {
                        Console.Write("\nKhong duoc bo trong! Nhap lai: ");
                        continue;
                    }
                    break;
                }

                lk.LoaiLK = loaiMoi;
                ds.list[ma] = lk;
                Console.WriteLine("\nCap nhat thanh cong!");
                Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
                Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
                Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

                ds.list[ma].HienThi();

                Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("\nKhong tim thay linh kien!");
            }

            int chon = CHUCNANGMENU.ChoChon();

            if (chon == 1)
            {
                MenuCapNhat(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        public void CapNhatGiaNhap(ref ListLK ds, string ma)
        {
            Console.Clear();
            Console.WriteLine("\nThong tin linh kien hien tai:");
            Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            ds.list[ma].HienThi();

            Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

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
                Console.WriteLine("\nThong tin linh kien hien tai:");
                Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
                Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
                Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

                ds.list[ma].HienThi();

                Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("\nKhong tim thay linh kien!");
            }

            int chon = CHUCNANGMENU.ChoChon();

            if (chon == 1)
            {
                MenuCapNhat(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        public void CapNhatTonKho(ref ListLK ds, string ma)
        {
            Console.Clear();
            Console.WriteLine("\nThong tin linh kien hien tai:");
            Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            ds.list[ma].HienThi();

            Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

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
                lk.TrangThai = tonKhoMoi > 0 ? true : false;
                ds.list[ma] = lk;
                Console.WriteLine("\nCap nhat thanh cong!");
                Console.WriteLine("\nThong tin linh kien hien tai:");
                Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
                Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
                Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

                ds.list[ma].HienThi();

                Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("\nKhong tim thay linh kien!");
            }

            int chon = CHUCNANGMENU.ChoChon();

            if (chon == 1)
            {
                MenuCapNhat(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        public void MenuCapNhat(ref ListLK ds)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║  === CHON LOAI LINH KIEN CAN CAP NHAT ===  ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║ 1. Linh kien thu dong                      ║");
            Console.WriteLine("║ 2. Linh kien Ban Dan                       ║");
            Console.WriteLine("║ 3. Vi mach Tich hop                        ║");
            Console.WriteLine("║ 4. Linh kien Ket noi & Co khi              ║");
            Console.WriteLine("║ 5. Cam bien                                ║");
            Console.WriteLine("║ 6. Hien thi                                ║");
            Console.WriteLine("║ 7. Dao dong & Thach anh                    ║");
            Console.WriteLine("║ 8. Mach in & Phu kien                      ║");
            Console.WriteLine("║ Esc. Quay lai                              ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.Write("Nhap lua chon (1–8): ");

            ConsoleKeyInfo key = Console.ReadKey(true);

            if(key.Key == ConsoleKey.Escape)
            {
                return;
            }

            Console.Clear();

            string loai = "";

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    loai = "Linh kien thu dong";
                    break;
                case ConsoleKey.D2:
                    loai = "Linh kien Ban Dan";
                    break;
                case ConsoleKey.D3:
                    loai = "Vi mach Tich hop";
                    break;
                case ConsoleKey.D4:
                    loai = "Linh kien Ket noi & Co khi";
                    break;
                case ConsoleKey.D5:
                    loai = "Cam bien";
                    break;
                case ConsoleKey.D6:
                    loai = "Hien thi";
                    break;
                case ConsoleKey.D7:
                    loai = "Dao dong & Thach anh";
                    break;
                case ConsoleKey.D8:
                    loai = "Mach in & Phu kien";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lua chon khong hop le! Chon lai: ");
                    return;
            }

            int stt = 1;
            Console.WriteLine($"\nDanh sach loai {loai}: ");
            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            foreach (var a in ds.list)
            {
                if (a.Value.LoaiLK == loai)
                {
                    Console.Write($"║ {stt++,5}. ");
                    a.Value.HienThi();

                }
            }

            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            // Nhập mã linh kiện trước
            Console.Write("Nhap ma linh kien muon cap nhat: ");
            string ma = Console.ReadLine();

            if (!ds.list.ContainsKey(ma))
            {
                Console.WriteLine("\nKhong tim thay linh kien!");
                return;
            }

            Console.Clear();
            
            // Hiển thị menu sửa
             ConsoleKeyInfo chon;
            Console.WriteLine("\n╔═════════════════════════════════╗");
            Console.WriteLine("║ === MENU CAP NHAT LINH KIEN === ║");
            Console.WriteLine("╠═════════════════════════════════╣");
            Console.WriteLine("║ 1. Cap nhat ten                 ║");
            Console.WriteLine("║ 2. Cap nhat loai                ║");
            Console.WriteLine("║ 3. Cap nhat gia nhap            ║");
            Console.WriteLine("║ 4. Cap nhat ton kho             ║");
            Console.WriteLine("║ ESC. Quay lai                   ║");
            Console.WriteLine("╚═════════════════════════════════╝");
            Console.Write("Chon cach cap nhat: ");

            chon = Console.ReadKey(true);

            if (chon.Key == ConsoleKey.Escape)
            {
                MenuCapNhat(ref ds);
                return;
            }

            switch (chon.Key)
            {
                case ConsoleKey.D1:
                    CapNhatTen(ref ds, ma);
                    break;
                case ConsoleKey.D2:
                    CapNhatLoai(ref ds, ma);
                    break;
                case ConsoleKey.D3:
                    CapNhatGiaNhap(ref ds, ma);
                    break;
                case ConsoleKey.D4:
                    CapNhatTonKho(ref ds, ma);
                    break;
                
                default:
                    Console.Clear();
                    Console.WriteLine("\nLua chon khong hop le! Chon lai: ");
                    break;
            }
            
        }
    }

    // XÓA LINH KIỆN 
    public struct XOA
    {
        public void XoaLinhKien(ref ListLK ds)
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

    //Phần của Thanh Vy 
    public struct SAPXEPLK
    {
        //Hàm sắp xếp theo loại linh kiện 
        public void SapXepTheoLoai(ref ListLK ds)
        {
            var sxtl = ds.list.Values.OrderBy(B => B.LoaiLK).ToList();
            Console.WriteLine("Danh sach sap xep theo loai linh kien: ");

            Console.WriteLine("\n╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            int stt = 1;
            foreach (var a in sxtl)
            {
                Console.Write($"║ {stt++,5}. ");
                a.HienThi();
            }

            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            int chon = CHUCNANGMENU.ChoChon();

            if (chon == 1)
            {
                MenuSapXep(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        //Hàm sắp xếp theo giá nhập 
        public void SapXepTheoGiaNhap(bool tanggiamGN, ref ListLK ds)
        {
            var sxgn = tanggiamGN
                ? ds.list.Values.OrderBy(B => B.GiaNhap).ToList()
                : ds.list.Values.OrderByDescending(B => B.GiaNhap).ToList();

            Console.WriteLine($"Danh sach sap xep theo gia nhap ({(tanggiamGN ? "tang dan" : "giam dan")}): ");

            Console.WriteLine("\n╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            int stt = 1;
            foreach (var a in sxgn)
            {
                Console.Write($"║ {stt++,5}. ");
                a.HienThi();
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            int chon = CHUCNANGMENU.ChoChon();

            if (chon == 1)
            {
                MenuSapXepGiaNhap(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        //Menu sắp xếp theo giá nhập 
        public void MenuSapXepGiaNhap(ref ListLK ds)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║ === MENU SAP XEP THEO GIA NHAP === ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║ 1. Sap xep tang dan                ║");
            Console.WriteLine("║ 2. Sap xep giam dan                ║");
            Console.WriteLine("║ ESC. Quay lai                      ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.Write("Lua chon 1 hoac 2: ");

            ConsoleKeyInfo key = Console.ReadKey(true);

            if(key.Key == ConsoleKey.Escape)
            {
                MenuSapXep(ref ds);
                return;
            }

            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        SapXepTheoGiaNhap(true, ref ds);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        SapXepTheoGiaNhap(false, ref ds);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\nLua chon khong hop le! Chon lai: ");
                        break;
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
            Console.WriteLine("\n╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            int stt = 1;
            foreach (var a in sxtk)
            {
                Console.Write($"║ {stt++,5}. ");
                a.HienThi();
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");
            int chon = CHUCNANGMENU.ChoChon();

            if (chon == 1)
            {
                MenuSapXepTonKho(ref ds);
                return;
            }
            else if (chon == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        //Menu sắp xếp theo tồn kho 
        public void MenuSapXepTonKho(ref ListLK ds)
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ === MENU SAP XEP THEO TON KHO === ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║ 1. Sap xep tang dan               ║");
            Console.WriteLine("║ 2. Sap xep giam dan               ║");
            Console.WriteLine("║ ESC. Quay lai                     ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write("Lua chon 1 hoac 2: ");
            
            ConsoleKeyInfo key = Console.ReadKey(true);

            if(key.Key == ConsoleKey.Escape)
            {
                MenuSapXep(ref ds);
                return;
            }

            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        SapXepTonKho(true, ref ds);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        SapXepTonKho(false, ref ds);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\nLua chon khong hop le! Chon lai: ");
                        break;
                    }
            }
        }

        //Menu tất cả sắp xếp 
        public void MenuSapXep(ref ListLK ds)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║     === MENU SAP XEP ===     ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║ 1. Sap xep theo loai         ║");
            Console.WriteLine("║ 2. Sap xep theo gia nhap     ║");
            Console.WriteLine("║ 3. Sap xep theo so ton kho   ║");
            Console.WriteLine("║ ESC. Quay lai                ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.Write("Lua chon cach sap xep (1-3): ");
            
            ConsoleKeyInfo key = Console.ReadKey(true);

            if(key.Key == ConsoleKey.Escape)
            {
                return;
            }

            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        SapXepTheoLoai(ref ds);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        MenuSapXepGiaNhap(ref ds);
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        MenuSapXepTonKho(ref ds);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\nLua chon khong hop le! Chon lai: ");
                        break;
                    }
            }
        }
    }

    //Phần của Phạm Trọng 
    //4.STRUCT TÌM KIẾM LINH KIỆN 
    public struct TIMKIEM
    {
        //Hàm tìm kiếm theo loại 
        public void TimKiemTheoLoai(ref ListLK ds)
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║  === CHON LOAI LINH KIEN ===  ║");
            Console.WriteLine("╠═══════════════════════════════╣");
            Console.WriteLine("║ 1. Linh kien thu dong         ║");
            Console.WriteLine("║ 2. Linh kien Ban Dan          ║");
            Console.WriteLine("║ 3. Vi mach Tich hop           ║");
            Console.WriteLine("║ 4. Linh kien Ket noi & Co khi ║");
            Console.WriteLine("║ 5. Cam bien                   ║");
            Console.WriteLine("║ 6. Hien thi                   ║");
            Console.WriteLine("║ 7. Dao dong & Thach anh       ║");
            Console.WriteLine("║ 8. Mach in & Phu kien         ║");
            Console.WriteLine("║ Esc. Quay lai                 ║");
            Console.WriteLine("╚═══════════════════════════════╝");
            Console.Write("Nhap lua chon (1–8): ");

            ConsoleKeyInfo key = Console.ReadKey(true);

            Console.Clear();

            if(key.Key == ConsoleKey.Escape)
            {
                return;
            }

            string loai = "";

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    loai = "Linh kien thu dong";
                    break;
                case ConsoleKey.D2:
                    loai = "Linh kien Ban Dan";
                    break;
                case ConsoleKey.D3:
                    loai = "Vi mach Tich hop";
                    break;
                case ConsoleKey.D4:
                    loai = "Linh kien Ket noi & Co khi";
                    break;
                case ConsoleKey.D5:
                    loai = "Cam bien";
                    break;
                case ConsoleKey.D6:
                    loai = "Hien thi";
                    break;
                case ConsoleKey.D7:
                    loai = "Dao dong & Thach anh";
                    break;
                case ConsoleKey.D8:
                    loai = "Mach in & Phu kien";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lua chon khong hop le! Chon lai: ");
                    return;
            }

            int stt = 1;
            Console.WriteLine($"\nDanh sach loai {loai}: ");
            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            foreach (var a in ds.list)
            {
                if (a.Value.LoaiLK == loai)
                {
                    Console.Write($"║ {stt++,5}. ");
                    a.Value.HienThi();
                    
                }
            }

            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");



            int use = CHUCNANGMENU.ChoChon();

            if(use == 1)
            {
                TimKiemTheoLoai(ref ds);
                return;
            }
            else if(use == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
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

            Console.Clear();

            Console.WriteLine($"\nDanh sach linh kien co gia nhap tu {minGiaNhap} den {MaxGiaNhap} la: ");
            bool TimThayGN = false;
            int stt = 1;

            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");
            foreach (var a in ds.list)
            {
                if (a.Value.GiaNhap >= 0 && a.Value.GiaNhap <= MaxGiaNhap)
                {
                    Console.Write($"║ {stt++,5}. ");
                    a.Value.HienThi();
                    TimThayGN = true;
                }
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            if (!TimThayGN)
            {
                Console.WriteLine("\nKhong tim thay linh kien trong khoan nay!");
            }

            int use = CHUCNANGMENU.ChoChon();

            if (use == 1)
            {
                MenuTimKiem(ref ds);
                return;
            }
            else if (use == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
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

            Console.Clear();

            Console.WriteLine($"\nDanh sach linh kien co ton kho tu {minTonKho} den {MaxGiaTonKho}");
            bool TimThayTK = false;
            int stt = 1;

            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");
            foreach (var a in ds.list)
            {
                if (a.Value.TonKho >= 1 && a.Value.TonKho <= MaxGiaTonKho)
                {
                    Console.Write($"║ {stt++,5}. ");
                    a.Value.HienThi();
                    TimThayTK = true;
                }
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            if (!TimThayTK)
            {
                Console.WriteLine("\nKhong tim thay linh kien tồn kho trong khoang nay!");
            }

            int use = CHUCNANGMENU.ChoChon();

            if (use == 1)
            {
                MenuTimKiem(ref ds);
                return;
            }
            else if (use == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        //Hàm menu tìm kiếm 
        public void MenuTimKiem(ref ListLK ds)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔═════════════════════════════════╗");
                Console.WriteLine("║ === MENU TiM KIEM LINH KIEN === ║");
                Console.WriteLine("╠═════════════════════════════════╣");
                Console.WriteLine("║ 1. Tim theo loai linh kien      ║");
                Console.WriteLine("║ 2. Tim theo gia nhap            ║");
                Console.WriteLine("║ 3. Tim theo ton kho             ║");
                Console.WriteLine("║ Esc. Quay lai                   ║");
                Console.WriteLine("╚═════════════════════════════════╝");

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }

                Console.Clear();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        TimKiemTheoLoai(ref ds);
                        break;
                    case ConsoleKey.D2:
                        TimKiemGiaNhap(ref ds);
                        break;
                    case ConsoleKey.D3:
                        TimKiemTonKho(ref ds);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nLua chon khong hop le! chon lai: ");
                        break;
                }


            }
        }
    }

    //Phần của Thanh Tú 
    //8.STRUCT SINH BỘ LINH KIỆN BẰNG ĐỆ QUY 
    public struct SINHBOLINHKIEN
    {
        public void SD(ref ListLK ds)
        {
            if (ds.list.Count == 0)
            {
                Console.WriteLine("Danh sach rong, khong the sinh bo linh kien!S");
            }
            Console.Write("Nhap so luong linh kien trong 1 bo (m): ");
            int m;
            while (!int.TryParse(Console.ReadLine(), out m) || m <= 0 || m > ds.list.Count)
            {
                Console.Write("\nSo khong hop le! Nhap lai: ");
            }

            List<LinhKien> list = ds.LayDanhSach();
            Console.WriteLine($"\n=== CAC BO LINH KIEN (chon {m} tu {list.Count}) ===");
            List<LinhKien> tam = new List<LinhKien>();
            ToHopDeQuy(list, tam, 0, m);
        }

        private void ToHopDeQuy(List<LinhKien> list, List<LinhKien> tam, int start, int m)
        {
            if (m == 0)
            {
                foreach (var lk in tam)
                    Console.Write(lk.MSLK + " ");
                Console.WriteLine();
                return;
            }

            for (int i = start; i <= list.Count - m; i++)
            {
                tam.Add(list[i]);
                ToHopDeQuy(list, tam, i + 1, m - 1);
                tam.RemoveAt(tam.Count - 1);
            }
        }
    }

    // STRUCT XUẤT KHO LINH KIỆN
    public struct XUATKHOLK 
    {
        public void XuatKhoLinhKien(ref ListLK ds)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║  === CHON LOAI LINH KIEN CAN XUAT KHO ===  ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.WriteLine("║ 1. Linh kien thu dong                      ║");
            Console.WriteLine("║ 2. Linh kien Ban Dan                       ║");
            Console.WriteLine("║ 3. Vi mach Tich hop                        ║");
            Console.WriteLine("║ 4. Linh kien Ket noi & Co khi              ║");
            Console.WriteLine("║ 5. Cam bien                                ║");
            Console.WriteLine("║ 6. Hien thi                                ║");
            Console.WriteLine("║ 7. Dao dong & Thach anh                    ║");
            Console.WriteLine("║ 8. Mach in & Phu kien                      ║");
            Console.WriteLine("║ Esc. Quay lai                              ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.Write("Nhap lua chon (1–8): ");

            ConsoleKeyInfo key = Console.ReadKey(true);

            Console.Clear();

            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }

            string loai = "";

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    loai = "Linh kien thu dong";
                    break;
                case ConsoleKey.D2:
                    loai = "Linh kien Ban Dan";
                    break;
                case ConsoleKey.D3:
                    loai = "Vi mach Tich hop";
                    break;
                case ConsoleKey.D4:
                    loai = "Linh kien Ket noi & Co khi";
                    break;
                case ConsoleKey.D5:
                    loai = "Cam bien";
                    break;
                case ConsoleKey.D6:
                    loai = "Hien thi";
                    break;
                case ConsoleKey.D7:
                    loai = "Dao dong & Thach anh";
                    break;
                case ConsoleKey.D8:
                    loai = "Mach in & Phu kien";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lua chon khong hop le! Chon lai: ");
                    return;
            }

            // Hiển thị danh sách linh kiện thuộc loại đã chọn
            Console.WriteLine($"\nDANH SACH LINH KIEN LOAI '{loai}':");
            int stt = 1;
            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");

            foreach (var a in ds.list)
            {
                if (a.Value.LoaiLK == loai)
                {
                    Console.Write($"║ {stt++,5}. ");
                    a.Value.HienThi();
                }
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            // Nhập mã linh kiện cần xuất
            Console.Write("\nNhap ma linh kien can xuat kho: ");
            string ma = Console.ReadLine();

            if (!ds.list.ContainsKey(ma))
            {
                Console.WriteLine("\nKhong tim thay linh kien!");
                CHUCNANGMENU.VeMenu();
                return;
            }

            LinhKien lk = ds.list[ma];

            Console.Clear();

            // Hiển thị thông tin linh kiện
            Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");
            ds.list[ma].HienThi();
            Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            // Kiểm tra tồn kho
            if (lk.TonKho <= 0)
            {
                Console.WriteLine("\nLinh kien da het hang, khong the xuat!");
                CHUCNANGMENU.VeMenu();
                return;
            }

            // Nhập số lượng xuất
            int soLuongXuat;
            while (true)
            {
                Console.Write("Nhap so luong can xuat: ");
                if (int.TryParse(Console.ReadLine(), out soLuongXuat) && soLuongXuat > 0)
                {
                    if (soLuongXuat <= lk.TonKho)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"So luong xuat vuot qua ton kho! Ton kho hien tai: {lk.TonKho}");
                    }
                }
                else
                {
                    Console.WriteLine("So luong khong hop le! Nhap lai: ");
                }
            }

            

            // Nhập người xuất
            Console.Write("Nhap ten nguoi xuat: ");
            string nguoiXuat = Console.ReadLine();

            // Xác nhận xuất
            Console.WriteLine($"\nXAC NHAN XUAT KHO:");
            Console.WriteLine($"- Linh kien: {lk.Name} ({lk.MSLK})");
            Console.WriteLine($"- So luong: {soLuongXuat}");
            
            Console.WriteLine($"- Nguoi xuat: {nguoiXuat}");
            Console.Write("\nBan co chac chan muon xuat? (y/n): ");

            string xacNhan = Console.ReadLine().ToLower();
            if (xacNhan != "y" && xacNhan != "yes")
            {
                Console.WriteLine("\nDa huy thao tac xuat kho!");
                CHUCNANGMENU.VeMenu();
                return;
            }

            // Thực hiện xuất kho
            lk.TonKho -= soLuongXuat;

            // Tự động cập nhật trạng thái
            lk.TrangThai = lk.TonKho > 0;

            // Cập nhật ghi chú
            string ghiChuMoi = $"Nguoi xuat: {nguoiXuat}";
            if (!string.IsNullOrEmpty(lk.GhiChu))
            {
                lk.GhiChu += $"; {ghiChuMoi}";
            }
            else
            {
                lk.GhiChu = ghiChuMoi;
            }

            ds.list[ma] = lk;

            Console.Clear();

            Console.WriteLine("\nXuat kho thanh cong!");

            Console.WriteLine("╔═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");
            ds.list[ma].HienThi();
            Console.WriteLine("╚═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            int use = CHUCNANGMENU.ChoChon();

            if (use == 1)
            {
                XuatKhoLinhKien(ref ds);
                return;
            }
            else if (use == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }
    }

    //STRUCT CẢNH BÁO
    public struct  CANHBAO 
    {
        public void TonKhoThap(ref ListLK ds)
        {
            Console.WriteLine("Danh sach linh kien co ton kho thap hown muc toi thieu: ");
            int stt = 1;
            bool found = false;
            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");
            foreach (var a in ds.list)
            {
                if(a.Value.TonKho < 30)
                {
                    Console.Write($"║ {stt++,5}. ");
                    a.Value.HienThi();
                    found = true;
                }
                
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            if (!found)
            {
                Console.WriteLine("Khong co linh kien nao thap hon muc toi thieu!");
                return;
            }

            int use = CHUCNANGMENU.ChoChon();

            if (use == 1)
            {
                MenuCanhBao(ref ds);
                return;
            }
            else if (use == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        public void TonKhoCao(ref ListLK ds)
        {
            Console.WriteLine("Danh sach linh lien co ton kho cao gay u dong von: ");
            int stt = 1;
            bool found = false;
            Console.WriteLine("╔════════╦═════════════════╦════════════════════════════════════════════════════╦══════════════════════════════╦════════════════════════╦═══════════════╦═════════════════╦═════════════════════════════════════╗");
            Console.WriteLine("║ STT    ║ MA LINH KIEN    ║ TEN LINH KIEN                                      ║ LOAI LINH KIEN               ║ GIA NHAP LINH KIEN     ║ LUONG TON KHO ║ TRANG THAI      ║ GHI CHU                             ║");
            Console.WriteLine("╠════════╬═════════════════╬════════════════════════════════════════════════════╬══════════════════════════════╬════════════════════════╬═══════════════╬═════════════════╬═════════════════════════════════════╣");
            foreach (var a in ds.list)
            {
                if(a.Value.TonKho > 250)
                {
                    Console.Write($"║ {stt++,5}. ");
                    a.Value.HienThi();
                    found = true;
                }
                
            }
            Console.WriteLine("╚════════╩═════════════════╩════════════════════════════════════════════════════╩══════════════════════════════╩════════════════════════╩═══════════════╩═════════════════╩═════════════════════════════════════╝");

            if (!found)
            {
                Console.WriteLine("Khong co linh kien nao cao gay u dong von! ");
            }

            int use = CHUCNANGMENU.ChoChon();

            if (use == 1)
            {
                MenuCanhBao(ref ds);
                return;
            }
            else if (use == 2)
            {
                CHUCNANGMENU.VeMenu();
                return;
            }
        }

        public void MenuCanhBao(ref ListLK ds)
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.WriteLine("║             === MENU CANH BAO ===             ║");
            Console.WriteLine("╠═══════════════════════════════════════════════╣");
            Console.WriteLine("║ 1. Canh bao ton kho thap hon muc toi thiu     ║");
            Console.WriteLine("║ 2. Canh bao ton kho cao gay u dong von        ║");
            Console.WriteLine("║ Esc. Quay lai                                 ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");

            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }

            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    TonKhoThap(ref ds);
                    break;
                case ConsoleKey.D2:
                    TonKhoCao(ref ds);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nLua chon khong hop le! Chon lai: ");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ListLK a = new ListLK();
            a.Initiallize();
            NHAPLK b = new NHAPLK();
            SUA c = new SUA();
            XOA d = new XOA();
            SAPXEPLK e = new SAPXEPLK();
            TIMKIEM f = new TIMKIEM();
            SINHBOLINHKIEN g = new SINHBOLINHKIEN();
            XUATDSLK h = new XUATDSLK();
            XUATKHOLK i = new XUATKHOLK();
            CANHBAO j = new CANHBAO();


            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║ ~~~ MENU QUAN LY LINH KIEN ĐIEN TU ~~~ ║");
                Console.WriteLine("╠════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Bang tat ca linh kien co trong kho  ║");
                Console.WriteLine("║ 2. Nhap linh kien                      ║");
                Console.WriteLine("║ 3. Tim kiem linh kien                  ║");
                Console.WriteLine("║ 4. Cap nhat linh kien                  ║");
                Console.WriteLine("║ 5. Sap xep linh kien                   ║");
                Console.WriteLine("║ 6. Xoa linh kien                       ║");
                Console.WriteLine("║ 7. Lap rap thiet bi                    ║");
                Console.WriteLine("║ 8. Xuat kho linh kien                  ║");
                Console.WriteLine("║ 9. Canh bao                            ║");
                Console.WriteLine("║ Esc. Thoat                             ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.Write("Chon chuc nang: ");

                key = Console.ReadKey(true);

                Console.Clear();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            h.xuat(ref a);
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            b.Them(ref a);
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            f.MenuTimKiem(ref a);
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            c.MenuCapNhat(ref a);
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            e.MenuSapXep(ref a);
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            d.XoaLinhKien(ref a);
                            CHUCNANGMENU.VeMenu();
                            break;
                        }
                    case ConsoleKey.D7:
                        {
                            g.SD(ref a);
                            CHUCNANGMENU.VeMenu();
                            break;
                        }
                    case ConsoleKey.D8:
                        {
                            i.XuatKhoLinhKien(ref a);
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D9:
                        {
                            j.MenuCanhBao(ref a);
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.WriteLine("Thoat...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lua chon khong hợp le!");
                            break;
                        }
                }
            } while (key.Key != ConsoleKey.Escape);

            Console.ReadKey();
        }
    }
}
