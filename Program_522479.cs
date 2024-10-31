using System;
using ComputeElipsArea;
using ComputeElipsPerimeter;
using ComputeElipsEdges;
using ComputeElipsEquation;
class Program_522479
{
    public static void Main(string[] args)
    {
        double mayor = 7;
        double minor = 14;

        ElipsArea elips1 = new ElipsArea(mayor, minor);
        ElipsPerimeter elips2 = new ElipsPerimeter(mayor, minor);
        ElipsEdges elips3 = new ElipsEdges();
        ElipsEquation elips4 = new ElipsEquation(mayor, minor);

        double LuasElips = elips1.ComputeArea();
        double KelilingElips = elips2.ComputePerimeter();
        double RusukElips = elips3.ComputeElipsEdges();
        string PersamaanElips = elips4.ComputeElipsEquation();

        Console.WriteLine($"Elips dengan panjang mayor semi axis {mayor} dan minor semi axis {minor} memiliki properti:");
        Console.WriteLine($"Luas = {LuasElips}");
        Console.WriteLine($"Keliling = {KelilingElips}");
        Console.WriteLine($"Banyak Rusuk = {RusukElips}");
        Console.WriteLine($"Persamaan elipsnya: {PersamaanElips}");

    }
}
