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

    #region CONSTRUCTORS

    public whdocBrowseViewModel() {

      whdMstrList = new List<model.whdMstrModel> {
        new model.whdMstrModel {
          Whdm_id = 1,
          Whdm_date = DateTime.Today,
          Whdm_nbr = "WZ/1/2021",
          Whdm_cust = "50000000",
          Whdm_name = "Shipper A",
          Whdm_netto = 522,
          Whdm_brutto = 522 * 1.23M
        },
        new model.whdMstrModel {
          Whdm_id = 2,
          Whdm_date = DateTime.Today,
          Whdm_nbr = "WZ/2/2021",
          Whdm_cust = "SAARSTAHL",
          Whdm_name = "Shipper B",
          Whdm_netto = 59876,
          Whdm_brutto = 59876 * 1.23M
        },
        new model.whdMstrModel {
          Whdm_id = 3,
          Whdm_date = DateTime.Today,
          Whdm_nbr = "WZ/3/2021",
          Whdm_cust = "59810001",
          Whdm_name = "Shipper C",
          Whdm_netto = 56486,
          Whdm_brutto = 56486 * 1.23M
        },
        new model.whdMstrModel {
          Whdm_id = 4,
          Whdm_date = DateTime.Today,
          Whdm_nbr = "WZ/4/2021",
          Whdm_cust = "CAMESA",
          Whdm_name = "Shipper D",
          Whdm_netto = 12346859,
          Whdm_brutto = 12346859 * 1.23M
        },
        new model.whdMstrModel {
          Whdm_id = 5,
          Whdm_date = DateTime.Today,
          Whdm_nbr = "WZ/5/2021",
          Whdm_cust = "Tauron Wydobycie ",
          Whdm_name = "Shipper E",
          Whdm_netto = 95871544,
          Whdm_brutto = 95871544 * 1.23M
        },
        new model.whdMstrModel {
          Whdm_id = 6,
          Whdm_date = DateTime.Today,
          Whdm_nbr = "WZ/6/2021",
          Whdm_cust = "SpaceX",
          Whdm_name = "Shipper F",
          Whdm_netto = 98745631258,
          Whdm_brutto = 98745631258 * 1.23M
        }
      };

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
      set {
        updater = value;
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
