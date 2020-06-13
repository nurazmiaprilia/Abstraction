using System;

namespace Abstraction.AbstractClass
{
    public class Literatur : BukuNonFiksi
    {
        public override void Data()
        {
            Console.WriteLine("Judul\t: Selembar Itu Berarti");
            Console.WriteLine("Penulis\t: SURYAMAN AMIPRIONO");
            Console.WriteLine("Penerbit: LITERATUR MEDIA SUKSES");
        }
    }
}