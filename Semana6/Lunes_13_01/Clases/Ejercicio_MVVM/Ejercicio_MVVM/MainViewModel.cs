using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejercicio_MVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        //ICommand

        public ICommand UpdateCommand { get; }

        public string FirstName
        {
            get { return _firstName; }
            set 
            { 
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
                UpdateFullNameFromNames();
            }

        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
                UpdateFullNameFromNames();
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if(_fullName != value)
                {
                    _fullName = value;
                    OnPropertyChanged(nameof(FullName));
                    UpdateNamesFromFullNames();
                }
            }
        }

        public MainViewModel()
        {
            UpdateCommand = new RelayCommand(Update, CanUpdate);
            _firstName = string.Empty;
            _lastName = string.Empty;
            UpdateFullNameFromNames();
        }

        private void Update()
        {
            //Logica para actualizar
            FirstName = "Escribe tu primer nombre";
            LastName = "Escribe tu apellido";
        }

        private bool CanUpdate()
        {
            return !string.IsNullOrEmpty(FirstName) &&
                !string.IsNullOrEmpty(LastName);
        }

        private void UpdateFullNameFromNames()
        {
            _fullName = $"{FirstName} {LastName}";
            OnPropertyChanged(nameof(FullName));
        }

        private void UpdateNamesFromFullNames()
        {
            var name = _fullName.Split(' ');
            if(name.Length > 0)
            {
                FirstName = name[0];
                LastName = name[1];
            }
            else
            {
                FirstName = _fullName;
                LastName = string.Empty;
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
