using System;

namespace Abstraction.Interface
{
    public class Komik : IBukuFiksi
    {
        public void info()
        {
            Console.WriteLine("Judul\t : Komik Hantu Nusantara");
            Console.WriteLine("Penulis\t : Studio Cakwaw");
            Console.WriteLine("Penerbit : Bhuana Ilmu Populer");
        }
    }
}