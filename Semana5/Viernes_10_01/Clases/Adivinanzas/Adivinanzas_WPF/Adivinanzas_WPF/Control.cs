using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanzas_WPF
{
    public class Control
    {
        public List<Region> listaRegiones;
        public int Puntos;
        public List<int> PreguntasDadas = new List<int>();

        public Control()
        {
            listaRegiones = new List<Region>();
            CargartRegiones();
        }


        private void CargartRegiones()
        {
            listaRegiones.Add(new Region("Argentina", "Buenos Aires"));
            listaRegiones.Add(new Region("Brasil", "Brasilia"));
            listaRegiones.Add(new Region("Chile", "Santiago"));
            listaRegiones.Add(new Region("Uruguay", "Montevideo"));
            listaRegiones.Add(new Region("Paraguay", "Asuncion"));
            listaRegiones.Add(new Region("Bolivia", "La Paz"));
            listaRegiones.Add(new Region("Peru", "Lima"));
            listaRegiones.Add(new Region("Ecuador", "Quito"));
            listaRegiones.Add(new Region("Colombia", "Bogota"));
            listaRegiones.Add(new Region("Venezuela", "Carcas"));
        }

        public void ReiniciarJuego()
        {
            Puntos = 0;
            PreguntasDadas = new List<int>();
        }

        public Region DarPregunta()
        {
            try
            {
                Random random = new Random();
                int indiceAleatorio = random.Next(0, listaRegiones.Count);
                if(PreguntasDadas.Count >= listaRegiones.Count)
                {
                    Console.WriteLine($"Toadas las preguntas han sido realizadas. Puntaje alcanzado: {Puntos}");
                }
                else
                {
                    //Comprobar si la pregunta ya fue dada
                    foreach(var index in PreguntasDadas)
                    {
                        if(index == indiceAleatorio)
                        {
                            return DarPregunta();
                        }
                    }
                }

                PreguntasDadas.Add(indiceAleatorio);
                return listaRegiones[indiceAleatorio];
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
        }
    }
}
