double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
        if (temperatur.Length == 0)
        {
            Console.WriteLine("Ingen data att beräkna medeltemperatur från.");
        }
        else
        {
            double summa = 0;
            foreach (double t in temperatur)
            {
                summa += t;
            }
            double medel = summa / temperatur.Length;
            Console.WriteLine($"Medeltemperatur kl. 08.00 under veckan: {medel:F1} °C"); 
        }