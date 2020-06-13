using System;

namespace Abstraction.AbstractClass
{
    public class Biografi : BukuNonFiksi
    {
        public override void Data()
        {
            Console.WriteLine("Judul\t: Biografi Bacharuddin Jusuf Habibie");
            Console.WriteLine("Penulis\t: A. Makmur Makka");
            Console.WriteLine("Penerbit: The Habibie Center Mandiri");
        }
    }
}