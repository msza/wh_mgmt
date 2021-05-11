using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace wh_mgmt.dataAccess {
  class whdMstrDataAccess {

    #region FIELDS

    //FIELDS

    #endregion

    #region CONSTRUCTORS
    public whdMstrDataAccess() {

    }

    #endregion

    #region DESTRUCTORS
    ~whdMstrDataAccess() {

    }

    #endregion

    #region PROPERTIES



    #endregion

    #region METHODS

    public void CreateWhdMstr(model.whdMstrModel in_whdMstr) {
      //CREATE BY NEXT ID - SQL SHOULD HANDLE ID NUMERATION
      string sqlCommandWhdMstr =
        "insert into whd_mstr " +
        "(whdm_date, whdm_nbr, whdm_cust, whdm_name, whdm_netto, whdm_brutto) " +
        "values " +
        "(@whdm_date, @whdm_nbr, @whdm_cust, @whdm_name, @whdm_netto, @whdm_brutto)";
      try {
        using (TransactionScope scope = new TransactionScope()) {
          using (SqlConnection connection = new SqlConnection()) {
            connection.Open();
            using (SqlCommand SqlCmd = new SqlCommand(sqlCommandWhdMstr, connection)) {
              SqlCmd.Parameters.Add("@whdm_date", SqlDbType.DateTime);
              SqlCmd.Parameters.Add("@whdm_nbr", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdm_cust", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdm_name", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdm_netto", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdm_brutto", SqlDbType.Decimal);

              SqlCmd.Parameters["@whdm_date"].Value = in_whdMstr.Whdm_date;
              SqlCmd.Parameters["@whdm_nbr"].Value = in_whdMstr.Whdm_nbr;
              SqlCmd.Parameters["@whdm_cust"].Value = in_whdMstr.Whdm_cust;
              SqlCmd.Parameters["@whdm_name"].Value = in_whdMstr.Whdm_name;
              SqlCmd.Parameters["@whdm_netto"].Value = in_whdMstr.Whdm_netto;
              SqlCmd.Parameters["@whdm_brutto"].Value = in_whdMstr.Whdm_brutto;

              foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
                if (sqlParameter.Value == null) {
                  sqlParameter.Value = DBNull.Value;
                }
              }
              SqlCmd.ExecuteNonQuery();
            }
            trhMstrDataAccess trhist = new trhMstrDataAccess();
            trhist.CreateTrhMstr(connection, in_whdMstr, "CREATED");
          }
          scope.Complete();
        }

      } catch (Exception Ex) {

        throw;
      }

    }

    public model.whdMstrModel ReadWhdMstr(model.whdMstrModel in_whdMstr) {

      model.whdMstrModel retWhdMstrModel = new model.whdMstrModel();

      return retWhdMstrModel;
    }

    public List<model.whdMstrModel> ReadWhdMstr() {

      List<model.whdMstrModel> retWhdMstrModelList = new List<model.whdMstrModel>();

      return retWhdMstrModelList;
    }

    public void UpdateWhdMstr(model.whdMstrModel in_whdMstr) {
      //UPDATE BY ID
      string sqlCommandWhdMstr =
        "update whd_mstr set " +
        "whdm_date = @whdm_date, " +
        "whdm_nbr = @whdm_nbr, " +
        "whdm_cust = @whdm_cust, " +
        "whdm_name = @whdm_name, " +
        "whdm_netto = @whdm_netto, " +
        "whdm_brutto = @whdm_brutto " +
        "where whdm_id = @whdm_id";
      try {
        using (TransactionScope scope = new TransactionScope()) {
          using (SqlConnection connection = new SqlConnection()) {
            connection.Open();
            using (SqlCommand SqlCmd = new SqlCommand(sqlCommandWhdMstr, connection)) {
              SqlCmd.Parameters.Add("@whdm_date", SqlDbType.DateTime);
              SqlCmd.Parameters.Add("@whdm_nbr", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdm_cust", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdm_name", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdm_netto", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdm_brutto", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdm_id", SqlDbType.Int);

              SqlCmd.Parameters["@whdm_date"].Value = in_whdMstr.Whdm_date;
              SqlCmd.Parameters["@whdm_nbr"].Value = in_whdMstr.Whdm_nbr;
              SqlCmd.Parameters["@whdm_cust"].Value = in_whdMstr.Whdm_cust;
              SqlCmd.Parameters["@whdm_name"].Value = in_whdMstr.Whdm_name;
              SqlCmd.Parameters["@whdm_netto"].Value = in_whdMstr.Whdm_netto;
              SqlCmd.Parameters["@whdm_brutto"].Value = in_whdMstr.Whdm_brutto;
              SqlCmd.Parameters["@whdm_id"].Value = in_whdMstr.Whdm_id;

              foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
                if (sqlParameter.Value == null) {
                  sqlParameter.Value = DBNull.Value;
                }
              }
              SqlCmd.ExecuteNonQuery();
            }
            trhMstrDataAccess trhist = new trhMstrDataAccess();
            trhist.CreateTrhMstr(connection, in_whdMstr, "UPDATED");
          }
          scope.Complete();
        }

      } catch (Exception) {

        throw;
      }
    }

    public void DeleteWhdMstr(model.whdMstrModel in_whdMstr) {
      //DELETE BY ID
      string sqlcommandWhdMstr =
        "delete from whd_mstr where whdm_id = @whdm_id";
      string sqlcommandWhdDet =
        "delete from whd_det where whdd_whdm_id = @whdm_id";
      try {
        using (TransactionScope scope = new TransactionScope()) {
          using (SqlConnection connection = new SqlConnection()) {
            connection.Open();
            using (SqlCommand SqlCmd = new SqlCommand(sqlcommandWhdMstr, connection)) {
              SqlCmd.Parameters.Add("@whdm_id", SqlDbType.Int);

              SqlCmd.Parameters["@whdm_id"].Value = in_whdMstr.Whdm_id;

              foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
                if (sqlParameter.Value == null) {
                  sqlParameter.Value = DBNull.Value;
                }
              }
              SqlCmd.ExecuteNonQuery();
            }
            using (SqlCommand SqlCmd = new SqlCommand(sqlcommandWhdDet, connection)) {
              SqlCmd.Parameters.Add("@whdm_id", SqlDbType.Int);

              SqlCmd.Parameters["@whdm_id"].Value = in_whdMstr.Whdm_id;

              foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
                if (sqlParameter.Value == null) {
                  sqlParameter.Value = DBNull.Value;
                }
              }
              SqlCmd.ExecuteNonQuery();
            }
            trhMstrDataAccess trhist = new trhMstrDataAccess();
            trhist.CreateTrhMstr(connection, in_whdMstr, "DELETED");
          }
          scope.Complete();
        }

      } catch (Exception Ex) {

        throw;
      }



    }

    #endregion

  }
}
