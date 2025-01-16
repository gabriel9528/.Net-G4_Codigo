using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Proyecto
{
    //INotifyPropertyChanged
    //La interfaz INotifyPropertyChanged se utiliza para notificar a la interfaz de usuario
    //(o a cualquier otro suscriptor) cuando el valor de una propiedad ha cambiado.

    //INotifyPropertyChanging
    //La interfaz INotifyPropertyChanging es similar, pero su propósito es notificar antes de
    //que cambie el valor de una propiedad.
    // Notificar a los suscriptores que una propiedad está a punto de cambiar, permitiendo acciones preventivas o de registro.
    public abstract class ViewModelBaase : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event PropertyChangingEventHandler? PropertyChanging;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void OnPropertyChanging(string propertyName)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
    }
}
