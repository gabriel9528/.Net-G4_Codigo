
using Polimorfismo1;

Persona[] personas = new Persona[2];
personas[0] = new Alumno("Gabriel Fernando");
personas[1] = new Empleado("Jorge Flores");
for (int i = 0; i < personas.Length; i++)
{
    Console.WriteLine(personas[i].Saludar());
}