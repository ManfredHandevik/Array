double[] temperatur = { 3.4, 2.8, 4.0, 3.1, 2.9, 3.6, 3.0 };

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

            // Skriv ut med en decimal
            Console.WriteLine($"Medeltemperatur kl. 08.00 under veckan: {medel:F1} °C"); 
        }