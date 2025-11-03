using System;

class Program
{
    static void Main()
    {
        string[] dias = { "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" };

        while (true)
        {
            int[] ventas = new int[6];
            string[] datos = Console.ReadLine().Split();

            ventas[0] = int.Parse(datos[0]);
            if (ventas[0] == -1)
                break;

            for (int i = 1; i < 6; i++)
                ventas[i] = int.Parse(datos[i]);

            int max = ventas[0], min = ventas[0];
            foreach (int v in ventas)
            {
                if (v > max) max = v;
                if (v < min) min = v;
            }
            int countMax = 0, countMin = 0;
            int diaMax = 0, diaMin = 0;
            for (int i = 0; i < 6; i++)
            {
                if (ventas[i] == max)
                {
                    countMax++;
                    diaMax = i;
                }
                if (ventas[i] == min)
                {
                    countMin++;
                    diaMin = i;
                }
            }

            string textoMax = (countMax > 1) ? "EMPATE" : dias[diaMax];
            string textoMin = (countMin > 1) ? "EMPATE" : dias[diaMin];

            double suma = 0;
            foreach (int v in ventas)
                suma += v;
            double media = suma / 6.0;

            string supera = (ventas[5] > media) ? "SI" : "NO";

            Console.WriteLine($"{textoMax} {textoMin} {supera}");
        }
    }
}
