using System;

//abstraction menggunakan Abstract Class
using Abstraction.AbstractClass;

//abstraksi menggunakan Interface
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Pilihan Jenis Buku");
            Console.WriteLine("======================");
            Console.WriteLine("1. Buku Non Fiksi");
            Console.WriteLine("2. Buku Fiksi");
            Console.WriteLine("======================");
            Console.Write("Pilih Buku [1/2] : ");
            int pil = Convert.ToInt32(Console.ReadLine());
            
            if (pil == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Pilihan Buku Non Fiksi");
                Console.WriteLine("======================");
                Console.WriteLine("1. Biografi");
                Console.WriteLine("2. Ensiklopedi");
                Console.WriteLine("3. Literatur");
                Console.WriteLine("======================");
                Console.Write("Pilih Buku [1/2/3] : ");
                int pilBuku = Convert.ToInt32(Console.ReadLine());

                  BukuNonFiksi bukuNF;

               if (pilBuku == 1)
                    bukuNF = new Biografi();
                else if (pilBuku == 2)
                    bukuNF = new Ensiklopedi();
                else
                    bukuNF = new Literatur();
            
                Console.WriteLine();
                bukuNF.Title(); 
                bukuNF.Data();
            
                Console.ReadKey();
            } 
            
            else if (pil == 2)
            {
                Console.WriteLine();
                Console.WriteLine("  Pilihan Buku Fiksi");
                Console.WriteLine("======================");
                Console.WriteLine("1. Dongeng");
                Console.WriteLine("2. Komik");
                Console.WriteLine("3. Novel");
                Console.WriteLine("======================");
                Console.Write("Pilih Buku [1/2/3] : ");
                int pilBook = Convert.ToInt32(Console.ReadLine());

                IBukuFiksi bukufiksi;

                if (pilBook == 1)
                    bukufiksi = new Dongeng();
                else if (pilBook == 2)
                    bukufiksi = new Komik();
                else
                    bukufiksi = new Novel();
            
                Console.WriteLine();
                Console.WriteLine("=====================================");
                Console.WriteLine("| Berikut Data Buku Yang Anda Pilih |");
                Console.WriteLine("=====================================");
                
                Console.WriteLine();
                bukufiksi.info();
            
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Pilihan Anda tidak tersedia.");
            }  
        }
    }
}