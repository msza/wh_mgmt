using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wh_mgmt.model {
  public class whdDetModel : ObservedModel {
    //WH DOC DETAIL

    //COMPONENTS ORDER BASED ON SA1201
    //https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1201.md

    #region FIELDS
    
    //przypisanych do nagłówka (nazwa artykułu, liczba, cena netto i brutto)
    private int whdd_id;
    private int whdd_whdm_id;
    private string whdd_sku;
    private double whdd_qty;
    private decimal whdd_netto;
    private decimal whdd_brutto;
    
    #endregion

    #region CONSTRUCTORS

    public whdDetModel() {

    }

    #endregion

    #region DESTRUCTORS

    ~whdDetModel() {

    }
    
    #endregion

    #region EVENTS


    #endregion

    #region PROPERTIES

    public int Whdd_id {
      get { return whdd_id; }
      set {
        whdd_id = value;
        OnPropertyChanged();
      }
    }
    public int Whdd_whdm_id {
      get { return whdd_whdm_id; }
      set {
        whdd_whdm_id = value;
        OnPropertyChanged();
      }
    }

    public string  Whdd_sku {
      get { return whdd_sku; }
      set {
        whdd_sku = value;
        OnPropertyChanged();
      }
    }
    public double Whdd_qty {
      get { return whdd_qty; }
      set {
        whdd_qty = value;
        OnPropertyChanged();
      }
    }
    public decimal Whdd_netto {
      get {return whdd_netto; }
      set {
        whdd_netto = value;
        OnPropertyChanged();
      }
    }
    public decimal Whdd_brutto {
      get { return whdd_brutto; }
      set {
        whdd_brutto = value;
        OnPropertyChanged();
      }
    }

    #endregion

    #region METHODS



    #endregion


  }
}
