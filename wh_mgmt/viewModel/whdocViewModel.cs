using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wh_mgmt.viewModel {
  class whdocViewModel {
    #region FIELDS

    private model.whdMstrModel whdmMstr;
    private IList<model.whdDetModel> whdDetList;
    private dataAccess.whdDetDataAccess whdDA;


    #endregion

    #region CONSTRUCTORS

    public whdocViewModel() {
      whdDA = new dataAccess.whdDetDataAccess();
    }

    #endregion

    #region DESTRUCTORS



    #endregion

    #region EVENTS



    #endregion

    #region PROPERTIES

    public model.whdMstrModel WhdmMstr {
      get { return whdmMstr; }
      set { whdmMstr = value; }
    }

    public IList<model.whdDetModel> WhdDetList {
      get { return whdDetList; }
      set { whdDetList = value; }
    }

    #endregion

    #region METHODS


    #endregion
  }
}
