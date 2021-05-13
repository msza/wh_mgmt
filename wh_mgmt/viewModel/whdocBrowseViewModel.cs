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
    private ICommand createWhdMstrBrowse;
    private ICommand readWhdMstrBrowse;
    private ICommand updateWhdMstrBrowse;
    private ICommand deleteWhdMstrBrowse;

    #endregion

    #region CONSTRUCTORS

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



    #endregion

    #region PROPERTIES

    public IList<model.whdMstrModel> WhdMstrList {
      get { return whdMstrList; }
      set { whdMstrList = value; }
    }

    public ICommand ViewModelCommand {
      get;
      set;
    }

    private bool CanExecuteRead(object parameter) {
      return true;
    }

    #endregion

    #region METHODS

    public ICommand CreateWhdMstrBrowse {
      get {
        if (createWhdMstrBrowse == null) {
          createWhdMstrBrowse = new RelayCommand(param => this.ExecuteCreateWhdMstrBrowse(), null);
        }
        return createWhdMstrBrowse;
      }
    }

    public ICommand ReadWhdMstrBrowse {
      get {
        if (readWhdMstrBrowse == null) {
          readWhdMstrBrowse = new RelayCommand(param => this.ExecuteReadWhdMstrBrowse(), null);
        }
        return readWhdMstrBrowse;
      }
    }
    public ICommand UpdateWhdMstrBrowse {
      get {
        if (updateWhdMstrBrowse == null) {
          updateWhdMstrBrowse = new RelayCommand(param => this.ExecuteUpdateWhdMstrBrowse(), null);
        }
        return updateWhdMstrBrowse;
      }
    }
    public ICommand DeleteWhdMstrBrowse {
      get {
        if (deleteWhdMstrBrowse == null) {
          deleteWhdMstrBrowse = new RelayCommand(param => this.ExecuteDeleteWhdMstrBrowse(), null);
        }
        return deleteWhdMstrBrowse;
      }
    }
    private void ExecuteCreateWhdMstrBrowse() {
      System.Diagnostics.Debug.WriteLine("create");
    }

    public void ExecuteReadWhdMstrBrowse() {
      System.Diagnostics.Debug.WriteLine("read");
    }

    public void ExecuteUpdateWhdMstrBrowse() {
      System.Diagnostics.Debug.WriteLine("update");
    }

    public void ExecuteDeleteWhdMstrBrowse() {
      System.Diagnostics.Debug.WriteLine("delete");
    }

    #endregion

    #region CLASSES

    #endregion

  }
}
