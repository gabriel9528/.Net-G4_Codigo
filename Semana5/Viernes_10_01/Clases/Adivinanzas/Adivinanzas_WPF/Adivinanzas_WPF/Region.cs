using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanzas_WPF
{
    public class Region
    {
        public string Pais {  get; set; }
        public string Capital {  get; set; }

        public Region(string pais, string capital)
        {
            Pais = pais;
            Capital = capital;
        }
    }
}
