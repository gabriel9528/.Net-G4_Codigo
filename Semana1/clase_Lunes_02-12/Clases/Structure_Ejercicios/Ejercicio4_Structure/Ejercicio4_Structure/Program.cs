using System;

struct ColorRGB
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    public ColorRGB(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public bool EsColorValido()
    {
        return (R >= 0 && R <= 255) && (G >= 0 && G <= 255) && (B >= 0 && B <= 255);
    }
}

class Program
{
    static void Main()
    {
        ColorRGB color = new ColorRGB(120, 255, 300);

        if (color.EsColorValido())
        {
            Console.WriteLine("El color es válido.");
        }
        else
        {
            Console.WriteLine("El color no es válido.");
        }
    }
}
