using QuickMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuickMVVM
{
    public class AddCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private MainViewModel _associatedVM;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //_associatedVM.AddPerson(parameter);
            _associatedVM.AddPerson();
        }

        public AddCommand(MainViewModel mainViewModel)
        {
            _associatedVM = mainViewModel;
        }
    }
}
