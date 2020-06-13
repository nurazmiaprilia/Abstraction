using System;

namespace Abstraction.Interface
{
    public class Dongeng : IBukuFiksi
    {
        public void info()
        {
            Console.WriteLine("Judul\t : Dongeng Binatang");
            Console.WriteLine("Penulis\t : Koen Setyawan");
            Console.WriteLine("Penerbit : Grasindo");
        }
    }
}