using System;
using System.Collections.Generic;
using System.Text;

namespace payment
{
    public class Program3
    {
        public void ShowText()
        {
            Console.Clear();

            {
                double sg, premiak, pierwszazmianak, ngk, brutto, pc, dpc, sc, soc, hpif, dhc, tdc, ttb, hi, tdl, netto, stawka, pierwszazmiana, drugazmiana, trzeciazmiana, ng, nagroda, drugazmianak, trzeciazmianak, premia;
                int apfit;
                Console.WriteLine("----- Obliczenie wypłaty KZN - System 8h -----");
                Console.WriteLine("");
                Console.WriteLine("Podaj stawke za godzine np: 20,55");
                stawka = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj liczbe dni pierwszej zmiany");
                pierwszazmiana = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("podaj liczbe dni drugiej zmiany");
                drugazmiana = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj liczbe dni trzeciej zmiany");
                trzeciazmiana = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj liczbe nadgodzin");
                ng = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj przewidzianą nagrode");
                nagroda = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj przewidzianą premie np: 0,25 = 25%");
                premia = Convert.ToDouble(Console.ReadLine());
                ngk = (ng * 2) * stawka;
                // Dodatki
                sg = (pierwszazmiana * 8) + (drugazmiana * 8) + (trzeciazmiana * 8); // suma godzin
                drugazmianak = ((drugazmiana * 8) * 3.76);
                trzeciazmianak = ((trzeciazmiana * 8) * 5.02);
                pierwszazmianak = pierwszazmiana * 8;
                premiak = (((pierwszazmiana * 8) + (drugazmiana * 8) + (trzeciazmiana * 8)) * stawka) * premia;
                brutto = ((sg * stawka) + drugazmianak + trzeciazmianak + nagroda + ngk + premiak);


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
                tdl = ttb * 0.17 - 43.76; // Podatek nalezny, Podatek należny 17% pomniejszony o 43.76zł
                apfit = (int)(tdl - dhc); // Zaliczka na podatek dochodowy

                netto = (brutto - soc - hpif - apfit);
                Console.Clear();
                // "{0:C}" - Wyświetlenie waluty 
                Console.WriteLine("");
                Console.WriteLine("Wypłata Brutto: " + "{0:C}", brutto);
                //Console.WriteLine("Składka emerytalna: " + "{0:C}", pc);
                //Console.WriteLine("Składka rentowa: " + "{0:C}", dpc);
                //Console.WriteLine("Składka chorobowa: " + "{0:C}", sc);
                //Console.WriteLine("Suma składek: " + "{0:C}", soc);
                //Console.WriteLine("Skłądki zdrowotne: " + "{0:C}", hpif);
                //Console.WriteLine("Składka odliczalna od PIT: " + "{0:C}", dhc);
                //Console.WriteLine("Zaliczka na PIT: " + "{0:C}", tdc);
                //Console.WriteLine("Zaliczka na Pit - ttb: " + "{0:C}", ttb);
                Console.WriteLine("Suma godzin: " + sg);
                Console.WriteLine("Liczba nadgodzin: " + ng);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Nadgodziny: " + "{0:C}", ngk);
                Console.WriteLine("Dodatek za 2 zmiane: " + "{0:C}", drugazmianak);
                Console.WriteLine("Dodatek za 3 zmiane: " + "{0:C}", trzeciazmianak);
                Console.WriteLine("Nagdora: " + "{0:C}", nagroda);
                Console.WriteLine("Premia: " + "{0:C}", premiak);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Wypłata netto: " + "{0:C}", netto);

                Console.WriteLine("");
                Console.WriteLine("Naciśnij ENTER żeby zamknąć");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
