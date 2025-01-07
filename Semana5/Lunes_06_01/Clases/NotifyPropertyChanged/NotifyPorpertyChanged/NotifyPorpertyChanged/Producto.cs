using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPorpertyChanged
{
    public class Producto : INotifyPropertyChanged
    {
        private string _nombre;
        private decimal _precio;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if(_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombre");
                    OnPropertyChanged("DescripcionCompleta");
                }
            }
        }

        public decimal Precio
        {
            get => _precio;
            set
            {
                if(_precio != value)
                {
                    _precio = value;
                    OnPropertyChanged("Precio");
                    OnPropertyChanged("DescripcionCompleta");
                }
            }
        }

        //Propiedad combinada
        public string DescripcionCompleta => $"{Nombre} - {Precio:C}";

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
