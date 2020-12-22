using System;

namespace Switcher
{
    public class Program
    {
       public  static void Main(string[] args)

        {
            Console.Clear();
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1) Przeliczenie z brutto na netto dla osób powyżej 26 roku życia");
            Console.WriteLine("2) Przeliczenie z brutto na netto dla osób poniżej 26 roku życia");
            Console.WriteLine("3) Obliczenie wypłaty KZN - System 8h");
            Console.WriteLine("4) Obliczenie wypłaty KZN - System 12h");
            Console.WriteLine("5) Autor");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    payment.Program1 program1 = new payment.Program1();
                    break;
                case "2":
                    payment.Program2 program2 = new payment.Program2();
                    program2.ShowText();
                    break;
                case "3":
                    payment.Program3 program3 = new payment.Program3();
                    program3.ShowText();
                    break;
                case "4":
                    payment.Program4 program4 = new payment.Program4();
                    program4.ShowText();
                    break;
                case "5":
                    payment.Program5 program5 = new payment.Program5();
                    program5.ShowText();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
