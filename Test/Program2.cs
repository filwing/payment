using System;
using System.Collections.Generic;
using System.Text;

namespace payment
{
    public class Program2
    {
        public void ShowText()
        {
            Console.Clear();

            {
                double brutto, pc, dpc, sc, soc, hpif, dhc, tdc, ttb, hi, netto;
                Console.WriteLine("----- Przeliczenie z brutto na netto dla osób poniżej 26 roku życia -----");
                Console.WriteLine("");
                Console.WriteLine("Podaj wypłate brutto");

                brutto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                //składek na ubezpieczenia społeczne

                pc = brutto * 0.0976; // Składka emerytalna
                dpc = brutto * 0.0150; // składka rentowa
                sc = brutto * 0.0245; //składka chorobowa
                soc = pc + dpc + sc; // Suma składek

                // Obliczenie składki zdrowotnej
                hi = brutto - soc; // Podstawa wymiaru składki na ubezpieczenie zdrowotne:
                hpif = hi * 0.09;   // Skłądki zdrowotna w całości
                dhc = hi * 0.0775; // Składka zdrowotna podlegająca odliczeniu

                // Zaliczka na podatek dochodowy

                tdc = 250; // Koszty uzyskania przychodów
                ttb = brutto - soc - tdc; // Podstawa opodatkowania

                netto = (brutto - soc - hpif);

                // "{0:C}" - Wyświetlenie waluty 
                Console.Clear();
                Console.WriteLine("----- Przeliczenie z brutto na netto dla osób poniżej 26 roku życia -----");
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

