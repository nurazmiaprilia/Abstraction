using System;

namespace Abstraction.AbstractClass
{
    public abstract class BukuNonFiksi
    {
        public void Title()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("| Berikut Data Buku Yang Anda Pilih |");
            Console.WriteLine("=====================================");
        }

        public abstract void Data();
    }
}