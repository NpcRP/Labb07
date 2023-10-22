using System;
using System.Globalization;
public class Geometri
{
    public virtual double Area()
    {
        return 0;
    }
}

public class Rektangel : Geometri
{
    public double Sida1 { get; set; }
    public double Sida2 { get; set; }

    public Rektangel()
    {
        Sida1 = 3.0;
        Sida2 = 6.0;
    }

    public override double Area()
    {
        return Sida1 * Sida2;
    }
}

public class Fyrkant : Geometri
{
    public double Sida { get; set; }

    public Fyrkant()
    {
        Sida = 6.0;
    }

    public override double Area()
    {
        return Sida * Sida;
    }
}

public class Cirkel : Geometri
{
    public double Radius { get; set; }

    public Cirkel()
    {
        Radius = 5.0;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Parallellogram : Geometri
{
    public double Bas { get; set; }
    public double Hojd { get; set; }

    public Parallellogram()
    {
        Bas = 4.0;
        Hojd = 5.0;
    }

    public override double Area()
    {
        return Bas * Hojd;
    }
}

public class Ellips : Geometri
{
    public double StorRadie { get; set; }
    public double LitenRadie { get; set; }

    public Ellips()
    {
        StorRadie = 7.0;
        LitenRadie = 3.0;
    }

    public override double Area()
    {
        return Math.PI * StorRadie * LitenRadie;
    }
}

class Program
{
    static void Main()
    {
        Geometri[] geometriArray = new Geometri[5];
        geometriArray[0] = new Cirkel();
        geometriArray[1] = new Fyrkant();
        geometriArray[2] = new Rektangel();
        geometriArray[3] = new Parallellogram();
        geometriArray[4] = new Ellips();

        Console.WriteLine("Area Cirkel: " + geometriArray[0].Area().ToString("F2"));
        Console.WriteLine("Area Fyrkant: " + geometriArray[1].Area().ToString("F2"));
        Console.WriteLine("Area Rektangel: " + geometriArray[2].Area().ToString("F2"));
    }
}
