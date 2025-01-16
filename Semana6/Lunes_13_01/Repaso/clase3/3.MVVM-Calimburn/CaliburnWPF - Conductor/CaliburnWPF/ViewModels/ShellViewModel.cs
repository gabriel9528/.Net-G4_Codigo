using Caliburn.Micro;
using CaliburnWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnWPF.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _firstName = "Gabriel";
        private string _lastName = "Retamozo";
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Gabriel", LastName = "Retamozo" });
            People.Add(new PersonModel { FirstName = "Jose", LastName = "Enriquez" });
            People.Add(new PersonModel { FirstName = "Daniel", LastName = "Tafur" });
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set
            {
                _people = value;
            }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }

        public void LoadPageOne()
        {
            ActiveItem = new FirstChildViewModel();
        }

        public void LoadPageTwo()
        {
            ActiveItem = new SecondChildViewModel();
        }
    }
}
