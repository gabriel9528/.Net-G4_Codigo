using Ejercicio2_MVVM.DAL;
using Ejercicio2_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejercicio2_MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Propiedades

        private List<Customer> _listCustomers;
        public List<Customer> ListCustomers
        {
            get { return _listCustomers; }
            set
            {
                if (_listCustomers != value)
                {
                    _listCustomers = value;
                    OnPropertyChanged("ListCustomers");
                }
            }
        }
        #endregion


        //ICommand
        private ICommand _customerCommand;
        public ICommand CustomerCommand
        {
            get
            {
                if(_customerCommand == null)
                {
                    _customerCommand = new RelayCommand(x => CustomerCommandExecute(), null);
                }
                return _customerCommand;
            }
        }

        public MainWindowViewModel()
        {
            
        }

        //Execute
        private void CustomerCommandExecute()
        {
            var customerService = new CustomerService();
            var result = customerService.GetCustomers();
            ListCustomers = new List<Customer>(result);
        }
    }
}
