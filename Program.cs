using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
       Mahasiswa Mahasiswa = new Mahasiswa();

        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nPilih Menu Aplikasi");
                Console.Write("\n");
                Console.Write("\n1. Tambah Mahasiswa");
                Console.Write("\n2. Hapus Mahasiswa");
                Console.Write("\n3. Tampilkan Mahasiswa");
                Console.Write("\n4. Keluar");

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4:
                        System.Environment.Exit(0);
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Mahasiswa Mahasiswa = new Mahasiswa();

            Console.Write("\nNIM: ");
            Mahasiswa.nim = Console.ReadLine();
            Console.Write("\nNama: ");
            Mahasiswa.nama = Console.ReadLine();
            Console.Write("\nJenis Kelamin [L/P] : ");
            Mahasiswa.Kelamin = Console.ReadLine();
            Console.Write("\nIPK : ");
            Mahasiswa.total = Console.ReadLine();
            


            daftarMahasiswa.Add(Mahasiswa);

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("\nData Penjualan");
            foreach (Mahasiswa Mahasiswa in daftarMahasiswa)
            {
                string jenisAkhir;
                Console.WriteLine("1. {0}, {1}, {2}, {3}, {4}",Mahasiswa.nim, Mahasiswa.nama, Mahasiswa.Kelamin, daftarMahasiswa, Mahasiswa.total);
                Console.WriteLine("\n");

                // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

                Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
            }
        }
    }
}