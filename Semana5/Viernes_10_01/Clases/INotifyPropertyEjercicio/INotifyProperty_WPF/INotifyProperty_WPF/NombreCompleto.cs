using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyProperty_WPF
{
    public class NombreCompleto : INotifyPropertyChanged
    {
        private string _nombre;
        private string _apellido;
        private string _nombreCompleto;

        public string Nombreee
        {
            get { return _nombre; }
            set
            {
                if(_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombreee");
                    OnPropertyChanged("NombreCompletoTodo");
                }
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (_apellido != value)
                {
                    _apellido = value;
                    OnPropertyChanged("Apellido");
                    OnPropertyChanged("NombreCompletoTodo");
                }
            }
        }

        public string NombreCompletoTodo
        {
            get { return $"{Nombreee} {Apellido}"; }
            set
            {
                if (_nombreCompleto != value)
                {
                    _nombreCompleto = value;
                    var partes = _nombreCompleto.Split(' ');
                    if(partes.Length >= 2 )
                    {
                        Nombreee = partes[0];
                        Apellido = partes[1];
                    }
                    else
                    {
                        Nombreee = _nombreCompleto;
                        Apellido = string.Empty;
                    }

                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
