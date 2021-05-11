using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wh_mgmt.viewModel {
  class whdocBrowseViewModel {
    #region FIELDS

    private IList<model.whdMstrModel> whdMstrList;

    #endregion

    #region CONSTRUCTOR

    public whdocBrowseViewModel() {

    }

    #endregion

    #region DESTRUCTORS

    ~whdocBrowseViewModel() {

    }

    #endregion

    #region EVENTS



    #endregion

    #region INTERFACES

    private ICommand updater;
    public ICommand UpdateCommand {
      get {
        if (updater == null) {
          updater = new Updater();
        }
        return updater;
      }
    }

    #endregion

    #region PROPERTIES

    public IList<model.whdMstrModel> WhdMstrList {
      get { return whdMstrList; }
      set { whdMstrList = value; }
    }

    #endregion

    #region METHODS



    #endregion

    #region CLASSES

    private class Updater : ICommand {

      public bool CanExecute(object parameter) {
        return true;
      }

      public event EventHandler CanExecuteChanged;

      public void Execute(object parameter) {

      }

    }

    #endregion

  }
}
