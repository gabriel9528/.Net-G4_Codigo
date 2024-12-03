using System;

struct FechaSimple
{
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Año { get; set; }

    public FechaSimple(int dia, int mes, int año)
    {
        Dia = dia;
        Mes = mes;
        Año = año;
    }

    public bool EsFechaValida()
    {
        if (Año < 1) return false;
        if (Mes < 1 || Mes > 12) return false;
        if (Dia < 1 || Dia > 31) return false;

        // Meses con 30 días
        if ((Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11) && Dia > 30)
            return false;

        // Febrero y años bisiestos
        if (Mes == 2)
        {
            bool esBisiesto = (Año % 4 == 0 && Año % 100 != 0) || (Año % 400 == 0);
            if (Dia > 29 || (Dia == 29 && !esBisiesto))
                return false;
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        FechaSimple fecha = new FechaSimple(29, 2, 2023);

        if (fecha.EsFechaValida())
        {
            Console.WriteLine("La fecha es válida.");
        }
        else
        {
            Console.WriteLine("La fecha no es válida.");
        }
    }
}
