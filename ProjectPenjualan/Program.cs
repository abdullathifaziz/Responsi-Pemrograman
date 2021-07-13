using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.WriteLine("+-------------------------+");
                Console.Write("\n| Nomor Menu [1..4]: ");
                
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|   PILIH MENU APLIKASI   |");
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("");
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("| 1. Tambah Penjualan     |");
            Console.WriteLine("| 2. Hapus Penjualan      |");
            Console.WriteLine("| 3. Tampilkan Penjualan  |");
            Console.WriteLine("| 4. Keluar               |");
            Console.WriteLine("+-------------------------+");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.Clear();

            int nota;
            string tanggal, nama;
            char jenis;
            double total;

            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|  Tambah Data Penjualan  |");
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("");

            Console.WriteLine("+-------------------------+");
            Console.Write("| Nota: ");
            nota = int.Parse(Console.ReadLine());
            Console.Write("| tanggal: ");
            tanggal = Console.ReadLine();
            Console.Write("| Customer: ");
            nama = Console.ReadLine();
            Console.Write("| Jenis [T/K] : ");
            jenis = char.Parse(Console.ReadLine());
            Console.Write("| Total Nota: ");
            total = double.Parse(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Nama = nama, Jenis = jenis, Total = total });

            Console.WriteLine("+-------------------------+");
            Console.WriteLine("\n| Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.Clear();

            bool ketemu = false;
            int hapus;
            int x = 0;

            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|   Hapus Data Penjualan  |");
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("");
            Console.WriteLine("+-------------------------+");
            Console.Write("| Nota: ");
            hapus = int.Parse(Console.ReadLine());
            foreach (Penjualan penjual in daftarPenjualan)
            {
                if (hapus == penjual.Nota)
                {
                    ketemu = true;
                    break;
                }
                x++;
            }
            if (ketemu)
            {
                daftarPenjualan.RemoveAt(x);
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("|  Data Berhasil Dihapus  |");
                Console.WriteLine("+-------------------------+");
            }
            else
            {
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("|   Data Tidak Ditemukan  |");
                Console.WriteLine("+-------------------------+");
            }

            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.Clear();

            int no = 1;
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|      Data Penjualan     |");
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("");

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (penjualan.Jenis == 'T' || penjualan.Jenis == 't')
                {
                    Console.WriteLine(" {0}, {1}, {2}, {3}, Tunai, {4}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Total);
                }

                else if (penjualan.Jenis == 'K' || penjualan.Jenis == 'k')
                {
                    Console.WriteLine(" {0}, {1}, {2}, {3}, Kredit, {4}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Total);
                }

                no++;
            }

            Console.WriteLine("\n Tekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
