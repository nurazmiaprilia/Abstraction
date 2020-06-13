using System;

namespace Abstraction.Interface
{
    public class Novel : IBukuFiksi
    {
        public void info()
        {
            Console.WriteLine("Judul\t : Hujan");
            Console.WriteLine("Penulis\t : Tere Liye");
            Console.WriteLine("Penerbit : Gramedia Pustaka Utama");
        }
    }
}