using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2a
{
    public class Pelicula
    {
        private string codigo;
        private string titulo;
        private string director;
        private int duracion;

        // Propiedades para Código
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código no puede ser nulo o vacío.");
                codigo = value;
            }
        }

        // Propiedades para Título
        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El título no puede ser nulo o vacío.");
                titulo = value;
            }
        }

        // Propiedades para Director
        public string Director
        {
            get { return director; }
            set
            {
                director = value;
            }
        }

        // Propiedades para Duración
        public int Duracion
        {
            get { return duracion; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La duración debe ser un número positivo mayor a 0.");
                duracion = value;
            }
        }

        // Método ToString
        public override string ToString()
        {
            return $"La película \"{Titulo}\", dirigida por {Director}, tiene una duración de {Duracion} minutos.";
        }
    }
}
