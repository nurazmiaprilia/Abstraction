using System;

namespace Abstraction.AbstractClass
{
    public class Ensiklopedi : BukuNonFiksi
    {
        public override void Data()
        {
            Console.WriteLine("Judul\t: Ensiklopedi Akhir Zaman");
            Console.WriteLine("Penulis\t: Dr. Muhammad Ahmad Al-Mubayyadh");
            Console.WriteLine("Penerbit: Granada Mediatama");
        }
    }
}