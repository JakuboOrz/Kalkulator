using System;

class Prostopadloscian
{
    private double dlugosc;
    private double szerokosc;
    private double wysokosc;

    public Prostopadloscian(double dlugosc, double szerokosc, double wysokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
        this.wysokosc = wysokosc;
    }

    public double ObliczObjetosc()
    {
        return dlugosc * szerokosc * wysokosc;
    }

    public static bool PorownajObjetosci(Prostopadloscian p1, Prostopadloscian p2)
    {
        return p1.ObliczObjetosc() == p2.ObliczObjetosc();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wymiary pierwszego prostopadłościanu:");
        double dlugosc1 = Convert.ToDouble(Console.ReadLine());
        double szerokosc1 = Convert.ToDouble(Console.ReadLine());
        double wysokosc1 = Convert.ToDouble(Console.ReadLine());
        Prostopadloscian p1 = new Prostopadloscian(dlugosc1, szerokosc1, wysokosc1);

        Console.WriteLine("Podaj wymiary drugiego prostopadłościanu:");
        double dlugosc2 = Convert.ToDouble(Console.ReadLine());
        double szerokosc2 = Convert.ToDouble(Console.ReadLine());
        double wysokosc2 = Convert.ToDouble(Console.ReadLine());
        Prostopadloscian p2 = new Prostopadloscian(dlugosc2, szerokosc2, wysokosc2);

        double objetosc1 = p1.ObliczObjetosc();
        double objetosc2 = p2.ObliczObjetosc();

        Console.WriteLine("Objętość pierwszego prostopadłościanu: " + objetosc1);
        Console.WriteLine("Objętość drugiego prostopadłościanu: " + objetosc2);

        if (Prostopadloscian.PorownajObjetosci(p1, p2))
        {
            Console.WriteLine("Oba prostopadłościany mają taką samą objętość.");
        }
        else
        {

            Console.WriteLine("Oba prostopadłościany mają różną objętość.");
            Console.ReadKey();
        }
    }
}