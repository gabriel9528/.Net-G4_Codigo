using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Libro
    {
        // Atributos
        private int ISBN;
        private string titulo;
        private string autor;
        private int numPaginas;

        // Constructores
        public Libro(int pISBN, string pTitulo, string pAutor, int pNumPaginas)
        {
            ISBN = pISBN;
            titulo = pTitulo;
            autor = pAutor;
            numPaginas = pNumPaginas;
        }

        // Propiedades
        //Las propiedades son un concepto que permite exponer de manera controlada
        //el acceso y la modificación de los atributos de una clase
        // Las propiedades se utilizan para encapsular y modularizar el acceso a los
        // datos internos de un objeto

        //value es una palabra clave que se utiliza para representar el valor que se
        //asigna a una propiedad cuando se realiza una operación de escritura (set). 
        public int ISBNPropiedad
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        public string TituloPropiedad
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string AutorPropiedad
        {
            get { return autor; }
            set { autor = value; }
        }

        public int NumPaginasPropiedad
        {
            get { return numPaginas; }
            set { numPaginas = value; }
        }

        // Método ToString
        public override string ToString()
        {
            return "El libro " + titulo + " con ISBN " + ISBN +
                   " creado por el autor " + autor +
                   " tiene " + numPaginas + " páginas";
        }
    }
}
