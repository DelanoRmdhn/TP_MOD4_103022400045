using TP_MODUL4_103022400045;

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        int kode = kodePos.getKodePos("Batununggal");

        System.Console.WriteLine("Kode Pos Batununggal: " + kode);
    }
}
