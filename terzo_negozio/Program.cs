using System;

namespace terzo_negozio
{
    class Program
    {
        static void Main(string[] args)
        {
            double importo_primo = 0;
            double importo_secondo = 0;
            double importo_totale = 0;
            double sconto = 0;
            Console.Write("Inserisci il prezzo del primo prodotto: ");
            importo_primo = double.Parse(Console.ReadLine());
            Console.Write("Inserisci il prezzo del secondo prodotto: ");
            importo_secondo = double.Parse(Console.ReadLine());
            if (importo_primo < importo_secondo)
            {
                sconto = (importo_primo / 100) * 50;
                importo_primo = importo_primo - sconto;
                importo_totale = importo_primo + importo_secondo;
                Console.WriteLine($"L'importo totale è {importo_totale}");
            }
            else if (importo_primo > importo_secondo)
            {
                sconto = (importo_secondo / 100) * 50;
                importo_secondo = importo_secondo - sconto;
                importo_totale = importo_primo + importo_secondo;
                Console.WriteLine($"L'importo totale è {importo_totale}");
            }
            Console.ReadLine();

        }
    }
}
