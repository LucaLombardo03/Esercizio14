using System;

namespace Controllo
{
    public class Sconto
    {
        public static double Saldo (double importo_primo, double importo_secondo)
        {
            if (importo_primo < importo_secondo)
            {
                double sconto = (importo_primo / 100) * 50;
                importo_primo = importo_primo - sconto;
                double importo_totale = importo_primo + importo_secondo;
                return importo_totale;
            }
            else if (importo_primo > importo_secondo)
            {
                double sconto = (importo_secondo / 100) * 50;
                importo_secondo = importo_secondo - sconto;
                double importo_totale = importo_primo + importo_secondo;
                return importo_totale;
            }
        }
    }
}
