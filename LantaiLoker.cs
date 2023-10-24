using System;


public class LantaiLoker
{
    public static int kapasitasLoker(int nomorLoker)
    {
        int lantai = 1;
        int lokerPerLantai = 5;
        int nomorAwalLoker = 1;

        while (nomorLoker > nomorAwalLoker + lokerPerLantai - 1)
        {
            nomorAwalLoker += lokerPerLantai;
            lantai++;

            if (lantai % 3 == 0)
            {
                lokerPerLantai = 7;
            }
            else if (lantai % 3 == 1)
            {
                lokerPerLantai = 5;
            }
            else
            {
                lokerPerLantai = 6;
            }
        }

        return lantai;
    }

   static void Main(string[] args)
    {
        Console.Write("Masukkan nomor loker: ");
        int nomorLoker = int.Parse(Console.ReadLine());

        int lantai = kapasitasLoker(nomorLoker);
        Console.WriteLine($"Lantai: {lantai}");
    }
}
