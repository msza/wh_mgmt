using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wh_mgmt.model {
  public abstract class ObservedModel : INotifyPropertyChanged{
    #region FIELDS



    #endregion

    #region CONSTRUCTORS



    #endregion

    #region DESTRUCTORS



    #endregion

    #region EVENTS

    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    #endregion

    #region PROPERTIES



    #endregion

    #region METHODS

    public void OnPropertyChanged([CallerMemberName] string propertyName = "") {
      PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
  }
}
