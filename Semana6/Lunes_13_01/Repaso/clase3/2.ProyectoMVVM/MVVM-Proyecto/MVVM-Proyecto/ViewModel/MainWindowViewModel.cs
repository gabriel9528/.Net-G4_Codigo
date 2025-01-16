using MVVM_Proyecto.DAL;
using MVVM_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVVM_Proyecto.ViewModel
{
    public class MainWindowViewModel : ViewModelBaase
    {
        #region Properties

        private List<Customer> _listCustomers;
        public List<Customer> ListCustomers
        {
            get { return _listCustomers; }
            set
            {
                if(_listCustomers != value)
                {
                    _listCustomers = value;
                    OnPropertyChanged("ListCustomers");
                }
            }
        }

        #endregion

        //Diferencia clave: Constructor vs Lazy Initialization
        //Cuando inicializas el ICommand dentro del constructor, el ICommand se crea inmediatamente al
        //construir el objeto MainViewModel, incluso si nunca se utiliza en la vista.Por otro lado,
        //con lazy initialization, el comando solo se crea cuando la vista lo necesita, es decir,
        //cuando el get de la propiedad CustomerCommand es invocado por el enlace de datos(data binding).
        #region Commands

        private ICommand _customerCommand;
        public ICommand CustomerCommand
        {
            get
            {
                if (_customerCommand == null)
                {
                    _customerCommand = new RelayCommand(param => CustomerCommandExecute(), null);
                }
                return _customerCommand;
            }
        }
        #endregion

        public MainWindowViewModel()
        {
            
        }

        private void CustomerCommandExecute()
        {
            var customerService = new CustomerService();
            var result = customerService.GetCustomers();
            ListCustomers = new List<Customer>(result);

        }
    }
}
