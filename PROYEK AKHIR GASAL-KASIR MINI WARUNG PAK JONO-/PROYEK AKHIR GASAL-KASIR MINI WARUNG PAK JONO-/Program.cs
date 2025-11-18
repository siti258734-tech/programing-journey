using System;

namespace PROYEK_AKHIR_GASAL_KASIR_MINI_WARUNG_PAK_JONO_
{
    internal class Program
    {
        // --- FUNGSI (METHOD) DIMULAI ---
        static void TampilkanStruk(int totalBelanja, int uangPembeli, int kembalian)
        {
            Console.Clear();
            Console.WriteLine("=== STRUK PEMBAYARAN ===");
            Console.WriteLine("Total Belanja : Rp " + totalBelanja);
            Console.WriteLine("Uang Pembeli  : Rp " + uangPembeli);
            Console.WriteLine("Kembalian     : Rp " + kembalian);
            Console.WriteLine("PEMBAYARAN BERHASIL!");
            Console.WriteLine("\nTerima kasih sudah berbelanja di Warung Pak Jono!");
        }
        // --- SFUNGSI (METHOD) SELESAI ---

        static void Main(string[] args)
        {
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                            KASIR MINI WARUNG PAK JONO                                                  ");
            Console.WriteLine("========================================================================================================================");


            // Membuat array daftar barang ===
            string[] barang = new string[4];

            // === BARANG YANG TERSEDIA ===
            // array 4 elemen dengan tipe data string
            string[] pilihanbarang = new string[4];
            Console.WriteLine("====================");
            Console.WriteLine("BARANG YANG TERSEDIA");
            Console.WriteLine("====================");

            // mengisi elemen array
            barang[0] = "Camilan";
            barang[1] = "Sayur";
            barang[2] = "Buah";
            barang[3] = "Bumbu";

            // Menampilkan isi array MENGGUNAKAN PERULANGAN FOR (SISIPAN)
            Console.WriteLine("Daftar Barang Yang Tersedia");
            Console.WriteLine("---------------------------");

            /// --- PERULANGAN FOR YANG DIMODIFIKASI ---
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Barang ke-{i + 1} {barang[i]}");
            }
            // --- AKHIR PERULANGAN FOR ---


            // === Variabel dan tipe data ===
            string namaBarang;
            int jumlah;
            double harga = 0, total, bayar, kembalian; // Inisialisasi 'harga' agar bisa diakses di luar switch
            string metodepembayaran;



            // Percabangan switch
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("    Masukkan barang yang ingin dipilih (1-4)    ");
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Anda memilih: ");
            int Pilihan = int.Parse(Console.ReadLine());

            switch (Pilihan)
            {
                case 1: Console.WriteLine("Anda memilih Camilan. Harga: Rp 5.000"); harga = 5000; break;
                case 2: Console.WriteLine("Anda memilih Sayur. Harga: Rp 10.000"); harga = 10000; break;
                case 3: Console.WriteLine("Anda memilih Buah. Harga: Rp 15.000"); harga = 15000; break;
                case 4: Console.WriteLine("Anda memilih Bumbu. Harga: Rp 7.000"); harga = 7000; break;
                default: Console.WriteLine("Barang tidak tersedia!"); break;
            }


            // Operator untuk menghitung harga barang
            Console.WriteLine("======================");
            Console.WriteLine("Masukkan Harga Barang:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("========================");
            Console.WriteLine("Masukkan Jumlah Barang: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total pembelian: " + (a * b));


            // === PEMBAYARAN CASH ===

            Console.Write("\nMasukkan total belanja: Rp ");
            int totalBelanja = int.Parse(Console.ReadLine());

            // Input uang dari pembeli
            Console.Write("Masukkan jumlah uang pembeli: Rp ");
            int uangPembeli = int.Parse(Console.ReadLine());

            // Hitung kembalian
            int Kembalian = uangPembeli - totalBelanja;

            // Tampilkan hasil (Diganti dengan pemanggilan fungsi)
            // --- PENGGANTIAN KODE ASLI DENGAN FUNGSI BARU ---
            TampilkanStruk(totalBelanja, uangPembeli, Kembalian);
            // --- AKHIR PENGGANTIAN ---
        }
    }
}