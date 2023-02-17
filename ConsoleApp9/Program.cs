using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange bredden på rektangeln: ");
        int bredd = int.Parse(Console.ReadLine());

        Console.Write("Ange höjden på rektangeln: ");
        int höjd = int.Parse(Console.ReadLine());

        int area = AREA(bredd, höjd);
        Console.WriteLine("Rektangelns area är: " + area);
    }

    static int AREA(int bredd, int höjd)
    {
        return bredd * höjd;
    }
}