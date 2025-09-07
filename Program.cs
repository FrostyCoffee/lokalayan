// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int[] kumpulanAngka = [23, 1, 43, 323, 6, 3, 13, 54, 2];
        TampilkanKumpulanAngka(kumpulanAngka);
        int[] angkaTerurut = BubbleSort(kumpulanAngka);
        TampilkanKumpulanAngka(angkaTerurut);
        Console.ReadLine();
    }

    private static void TampilkanKumpulanAngka(int[] kumpulanAngka)
    {
        foreach (int angka in kumpulanAngka)
        {
            Console.Write($"{angka.ToString()}");
        }
        Console.WriteLine();
    }

    private static void TukarTempatAngka(ref int angka1, ref int angka2)
    {
        int temp = angka1;
        angka1 = angka2;
        angka2 = temp;
    }

    private static int[] BubbleSort(int[] kumpulanAngka)
    {
        bool terurut = false;
        while (!terurut)
        {
            terurut = true;
            for (int i = 0; i < kumpulanAngka.Length - 1; i++)
            {
                if (kumpulanAngka[i] > kumpulanAngka[i + 1])
                {
                    TukarTempatAngka(ref kumpulanAngka[i], ref kumpulanAngka[i + 1]);
                    terurut = false;
                }
            }
        }
        return kumpulanAngka;
    }
}