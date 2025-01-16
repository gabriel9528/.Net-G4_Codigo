using QuickMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuickMVVM.ViewModel
{
    public class MainViewModel : ChangeNotifier
    {
        private PersonModel _personModel;
        public PersonModel PersonModel
        {
            get => _personModel;
            set
            {
                _personModel = value;
                OnPropertyChanged(nameof(PersonModel));
            }
        }

        private ObservableCollection<PersonModel> _observablePersons;
        public ObservableCollection<PersonModel> ObservablePersons
        {
            get => _observablePersons;
            set
            {
                _observablePersons = value;
            }
        }

        public void AddPerson()
        {
            ObservablePersons.Add(PersonModel);
            PersonModel = new PersonModel();
        }

        public ICommand AddCommand { get; set; }
        //public ICommand AddCommand => new RelayCommand(AddPerson, null);

        public MainViewModel()
        {
            AddCommand = new AddCommand(this);
            ObservablePersons = new ObservableCollection<PersonModel>();
            PersonModel = new PersonModel();
        }
    }

}
