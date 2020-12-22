using System;

namespace payment
{
    public class Program1
    {
        public Program1()
        {
            Main();
        }
        static void Main()
        {
            Console.Clear();

            {
                double brutto, pc, dpc, sc, soc, hpif, dhc, tdc, ttb, hi, tdl, netto;
                int apfit;
                Console.WriteLine("----- Przeliczenie z brutto na netto dla osób powyżej 26 roku życia -----");
                Console.WriteLine("");
                Console.WriteLine("Podaj wypłate brutto");

                brutto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                //składek na ubezpieczenia społeczne

                pc = brutto * 0.0976; // Składka emerytalna - pension contribution
                dpc = brutto * 0.0150; // składka rentowa - disability pension contribution
                sc = brutto * 0.0245; //składka chorobowa - sickness contribution
                soc = pc + dpc + sc; // Suma składek - Sum of contributions

                // Obliczenie składki zdrowotnej
                hi = brutto - soc; // Podstawa wymiaru składki na ubezpieczenie zdrowotne - health insurance
                hpif = hi * 0.09;   // Skłądki zdrowotna w całości - Health premium in full
                dhc = hi * 0.0775; // Składka zdrowotna podlegająca odliczeniu - Deductible health contribution

                // Zaliczka na podatek dochodowy

                tdc = 250; // Koszty uzyskania przychodów - Tax deductible costs
                ttb = brutto - soc - tdc; // Podstawa opodatkowania - The tax base
                tdl = ttb * 0.17 - 43.76; // Podatek należny 17% pomniejszony o 43.76zł - Tax due 17 % less 43.76
                apfit = (int)(tdl - dhc); // Zaliczka na podatek dochodowy - Advance payment for income tax

                netto = (brutto - soc - hpif - apfit);

                // "{0:C}" - Wyświetlenie waluty 
                Console.Clear();
                Console.WriteLine("----- Przeliczenie z brutto na netto dla osób powyżej 26 roku życia -----");
                Console.WriteLine("");
                Console.WriteLine("Brutto: " + "{0:C}", brutto);
                Console.WriteLine("Składka emerytalna: " + "{0:C}", pc);
                Console.WriteLine("Składka rentowa: " + "{0:C}", dpc);
                Console.WriteLine("Składka chorobowa: " + "{0:C}", sc);
                Console.WriteLine("Suma składek: " + "{0:C}", soc);
                Console.WriteLine("Skłądki zdrowotne: " + "{0:C}", hpif);
                Console.WriteLine("Składka odliczalna od PIT: " + "{0:C}", dhc);
                Console.WriteLine("Zaliczka na PIT: " + "{0:C}", tdc);
                //Console.WriteLine("Zaliczka na Pit - ttb: " + "{0:C}", ttb);
                Console.WriteLine("Wypłata netto: " + "{0:C}", netto);

                Console.WriteLine("");
                Console.WriteLine("Naciśnij ENTER żeby zamknąć");
                Console.ReadKey();
            }
            Console.Clear();
        }
    }
}
