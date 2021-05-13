using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wh_mgmt.viewModel {
  public class RelayCommand : ICommand {

    private readonly Action<object> execute;
    private readonly Predicate<object> canExecute;

    public RelayCommand(Action<object> Execute) : this(Execute, null) {
    }
    public RelayCommand(Action<object> Execute, Predicate<object> CanExecute) {
      if (Execute == null)
        throw new ArgumentNullException("Execute");
      execute = Execute;
      canExecute = CanExecute;
    }
    public bool CanExecute(object parameter) {
      return canExecute == null ? true : canExecute(parameter);
    }
    public event EventHandler CanExecuteChanged {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }
    public void Execute(object parameter) {
      execute(parameter);
    }

  }
}
