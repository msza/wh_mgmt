using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wh_mgmt.model {
  public class whdMstrModel : ObservedModel {
    //WH DOC MASTER

    //COMPONENTS ORDER BASED ON SA1201
    //https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1201.md

    #region FIELDS

    //nagłówek dokumentu (data, numer, klient, nazwa, cena netto i brutto)
    private int whdm_id;
    private DateTime whdm_date;
    private string whdm_nbr;
    private string whdm_cust;
    private string whdm_name;
    private decimal whdm_netto;
    private decimal whdm_brutto;

    #endregion

    #region CONSTRUCTORS

    public whdMstrModel() {

    }

    #endregion

    #region DESTRUCTORS

    ~whdMstrModel() {

    }

    #endregion

    #region EVENTS

    

    #endregion

    #region PROPERTIES

    //PROPERTY FIRE EVENT LOGIC:
    //  OnPropertyChanged();
    //BASED ON:
    //https://stackoverflow.com/questions/141370/inotifypropertychanged-property-name-hardcode-vs-reflection
    //DISCOURAGED
    //  OnPropertyChanged("Whdd_id");
    //  OnPropertyChanged(p => p.Name);
    //  OnPropertyChanged(MethodBase.GetCurrentMethod().Name);
    //  NotifyPropertyChanged(nameof(Whdm_id));

    public int Whdm_id {
      get { return whdm_id; }
      set {
        whdm_id = value;
        OnPropertyChanged();
      }
    }

    public DateTime Whdm_date {
      get { return whdm_date; }
      set {
        whdm_date = value;
        OnPropertyChanged();
      }
    }

    public string Whdm_nbr {
      get { return whdm_nbr; }
      set {
        whdm_nbr = value;
        OnPropertyChanged();
      }
    }

    public string Whdm_cust {
      get { return whdm_cust; }
      set {
        whdm_cust = value;
        OnPropertyChanged();
      }
    }

    public string Whdm_name {
      get { return whdm_name; }
      set {
        whdm_name = value;
        OnPropertyChanged();
      }
    }

    public decimal Whdm_netto {
      get { return whdm_netto; }
      set {
        whdm_netto = value;
        OnPropertyChanged();
      }
    }

    public decimal Whdm_brutto {
      get { return whdm_brutto; }
      set {
        whdm_brutto = value;
        OnPropertyChanged();
      }
    }

    #endregion

    #region METHODS



    #endregion

  }
}
