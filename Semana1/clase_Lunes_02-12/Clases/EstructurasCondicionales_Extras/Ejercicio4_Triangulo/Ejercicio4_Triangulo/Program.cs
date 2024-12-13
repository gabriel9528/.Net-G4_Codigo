Console.WriteLine("Juego del triangulo!");

float[] lados = new float[3];
float mayor = 0;
float sumar = 0;
int i, j, auxiliar = 0, flag = 0;

for (i = 0; i < 3; i++)
{
    Console.WriteLine("Lado {0}:", i + 1);
    lados[i] = float.Parse(Console.ReadLine());

    if (lados[i] > mayor)
    {
        mayor = lados[i];
        auxiliar = i;
    }
}

//auxiliar toma el índice del valor del lado más largo
//Se asegura que el índice más largo no se incluya en la suma
for (i = 0; i < 3; i++)
{
    if (auxiliar != i)
    {
        sumar = sumar + lados[i];
    }
}

if (mayor < sumar)
{
    Console.WriteLine("Es un triangulo");
    for (i = 0; i < 2; i++)
    {
        for (j = i + 1; j < 3; j++)
        {
            if (lados[i] == lados[j])
            {
                flag++;
            }
        }
    }
    if (flag == 3)
    {
        Console.WriteLine("Triangulo: ---> Equilatero");
    }
    else
    {
        for (i = 0; i < 2; i++)
        {
            for (j = i + 1; j < 3; j++)
            {
                if (lados[i] == lados[j])
                {
                    flag++;
                }
            }
        }
        if (flag == 2)
        {
            Console.WriteLine("Triangulo: ---> Isosceles");
        }
        else
        {
            Console.WriteLine("Triangulo: ---> Escaleno");
        }
    }
}
else
{
    Console.WriteLine("No es un triangulo");
}
Console.ReadLine();
