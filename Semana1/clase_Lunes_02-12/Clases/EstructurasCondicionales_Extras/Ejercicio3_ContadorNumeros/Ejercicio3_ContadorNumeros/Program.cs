//Contador de numeros pares, numeros enteros entre dos limites, el numero mayor y el numero menor

float num1, num2, menor, mayor;
int i, cont = 0, contpar = 0;

do
{
    Console.Write("Número 1:");
    num1 = float.Parse(Console.ReadLine());

    Console.Write("Número 2:");
    num2 = float.Parse(Console.ReadLine());
} while (num1 == num2);

if (num1 < num2)
{
    menor = num1;
    mayor = num2;
}
else
{
    menor = num2;
    mayor = num1;
}

for (i = (int)menor + 1; i < (int)mayor; i++)
{
    Console.Write("{0}|", i);
    cont++;
    if (i % 2 == 0)
        contpar++;
}
if (num1 == num2 - 1 || num2 == num1 - 1)
    Console.Write("\n\nNo hay numeros enteros entre {0} y el {1}", num1, num2);
else
    Console.Write("\n\nEntre {0} y {1} hay {2} números de los cuales {3} son pares", menor, mayor, cont, contpar);

Console.Read();