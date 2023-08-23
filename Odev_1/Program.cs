using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{

    class Hayvan
    {
        public string Tur { get; set; }
        public string Isim { get; set; }

        public Hayvan(string tür, string isim)
        {
            Tur = tür;
            Isim = isim;
        }

        public void BilgiGoster()
        {
            Console.WriteLine($"Tür: {Tur}, İsim: {Isim}");
        }
    }

    class Memeli : Hayvan
    {
        public bool SutVerir { get; set; }

        public Memeli(string tür, string isim, bool sutVerir)
            : base(tür, isim)
        {
            SutVerir = sutVerir;
        }

        public void SutBilgisiniGoster()
        {
            Console.WriteLine($"Süt Verir: {SutVerir}");
        }
    }

    class Kuş : Hayvan
    {
        public bool Ucar { get; set; }

        public Kuş(string tür, string isim, bool ucar)
            : base(tür, isim)
        {
            Ucar = ucar;
        }

        public void UcmaBilgisiniGoster()
        {
            Console.WriteLine($"Uçar: {Ucar}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Memeli köpek = new Memeli("Köpek", "Karabaş", false);
            Kuş kartal = new Kuş("Kartal", "Şimşek", true);

            köpek.BilgiGoster();
            köpek.SutBilgisiniGoster();

            kartal.BilgiGoster();
            kartal.UcmaBilgisiniGoster();
        }
    }
}
