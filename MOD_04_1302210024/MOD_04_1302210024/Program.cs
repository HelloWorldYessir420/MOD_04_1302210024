// See https://aka.ms/new-console-template for more information
using MOD_04_1302210024;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        KodeBuah Search = new KodeBuah();

        Console.WriteLine("Kode " +KodeBuah.Buah.Anggur +  "Adalah " + Search.getKodeBuah(KodeBuah.Buah.Anggur ));
    }
}

