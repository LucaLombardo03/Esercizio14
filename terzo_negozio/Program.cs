using System;
using Controllo;

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
            importo_totale = Sconto.Saldo(importo_primo, importo_secondo);
            Console.ReadLine();
        }
    }
}
