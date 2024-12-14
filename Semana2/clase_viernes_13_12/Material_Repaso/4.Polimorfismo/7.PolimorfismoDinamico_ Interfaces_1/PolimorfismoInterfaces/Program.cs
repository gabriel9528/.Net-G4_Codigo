
using PolimorfismoInterfaces;

IPersona[] personas = new IPersona[2];
personas[0] = new Alumno("Jaime Correa");
personas[1] = new Empleado("Juan Perez");
for (int i = 0; i < personas.Length; i++)
{
    Console.WriteLine(personas[i].Despedirse());
}