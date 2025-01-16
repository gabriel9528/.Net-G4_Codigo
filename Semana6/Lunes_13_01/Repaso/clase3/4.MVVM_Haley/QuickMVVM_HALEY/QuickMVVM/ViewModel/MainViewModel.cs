using Haley.Models;
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

        //public ICommand AddCommand { get; set; }
        public ICommand AddCommand => new DelegateCommand(AddPerson);
        public ICommand DeleteCommand => new DelegateCommand<PersonModel>(DeletePerson);

        private void DeletePerson(PersonModel obj)
        {
            if (obj == null) return;
            if (!ObservablePersons.Contains(obj)) return;

            ObservablePersons.Remove(obj);
        }

        public MainViewModel()
        {
            //AddCommand = new AddCommand(this);
            ObservablePersons = new ObservableCollection<PersonModel>();
            PersonModel = new PersonModel();
        }
    }

}
