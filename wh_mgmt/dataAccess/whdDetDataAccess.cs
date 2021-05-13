using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace wh_mgmt.dataAccess {
  public class whdDetDataAccess {

    #region FIELDS



    #endregion

    #region CONSTRUCTORS



    #endregion

    #region DESTRUCTORS



    #endregion

    #region EVENTS



    #endregion

    #region PROPERTIES



    #endregion

    #region METHODS

    public void CreateWhdDet(model.whdDetModel in_whdDet) {
      string sqlCommandWhdDet =
        "insert into whd_det " +
        "(whdd_whdm_id, whdd_sku, whdd_qty, whdd_netto, whdd_brutto) " +
        "values " +
        "(@whdd_whdm_id, @whdd_sku, @whdd_qty, @whdd_netto, @whdd_brutto)";
      try {
        using (TransactionScope scope = new TransactionScope()) {
          using (SqlConnection connection = new SqlConnection()) {
            connection.Open();
            using (SqlCommand SqlCmd = new SqlCommand(sqlCommandWhdDet, connection)) {
              SqlCmd.Parameters.Add("@whdd_whdm_id", SqlDbType.Int);
              SqlCmd.Parameters.Add("@whdd_sku", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdd_qty", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdd_netto", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdd_brutto", SqlDbType.Decimal);

              SqlCmd.Parameters["@whdd_whdm_id"].Value = in_whdDet.Whdd_whdm_id;
              SqlCmd.Parameters["@whdd_sku"].Value = in_whdDet.Whdd_sku;
              SqlCmd.Parameters["@whdd_qty"].Value = in_whdDet.Whdd_qty;
              SqlCmd.Parameters["@whdd_netto"].Value = in_whdDet.Whdd_netto;
              SqlCmd.Parameters["@whdd_brutto"].Value = in_whdDet.Whdd_brutto;

              foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
                if (sqlParameter.Value == null) {
                  sqlParameter.Value = DBNull.Value;
                }
              }
              SqlCmd.ExecuteNonQuery();
            }
          }
          scope.Complete();
        }

      } catch (Exception Ex) {

        throw;
      }
    }

    public model.whdDetModel ReadWhdDetz(model.whdDetModel in_whdDet) {

      model.whdDetModel retWhdDetModel = new model.whdDetModel();

      return retWhdDetModel;
    }

    public List<model.whdDetModel> ReadWhdDet() {

      List<model.whdDetModel> retWhdDetModel = new List<model.whdDetModel>();

      return retWhdDetModel;
    }

    public void UpdateWhdDet(model.whdDetModel in_whdDet) {
      string sqlCommandWhdDet =
        "update whd_det set " +
        "whdd_whdm_id = @whdd_whdm_id" +
        "whdd_sku = @whdd_sku" +
        "whdd_qty = @whdd_qty" +
        "whdd_netto = @whdd_netto" +
        "whdd_brutto = @whdd_brutto" +
        "where whdd_id = @whdd_id";
      try {
        using (TransactionScope scope = new TransactionScope()) {
          using (SqlConnection connection = new SqlConnection()) {
            connection.Open();
            using (SqlCommand SqlCmd = new SqlCommand(sqlCommandWhdDet, connection)) {
              SqlCmd.Parameters.Add("@whdd_whdm_id", SqlDbType.Int);
              SqlCmd.Parameters.Add("@whdd_sku", SqlDbType.NVarChar);
              SqlCmd.Parameters.Add("@whdd_qty", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdd_netto", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdd_brutto", SqlDbType.Decimal);
              SqlCmd.Parameters.Add("@whdd_id", SqlDbType.Int);

              SqlCmd.Parameters["@whdd_whdm_id"].Value = in_whdDet.Whdd_whdm_id;
              SqlCmd.Parameters["@whdd_sku"].Value = in_whdDet.Whdd_sku;
              SqlCmd.Parameters["@whdd_qty"].Value = in_whdDet.Whdd_qty;
              SqlCmd.Parameters["@whdd_netto"].Value = in_whdDet.Whdd_netto;
              SqlCmd.Parameters["@whdd_brutto"].Value = in_whdDet.Whdd_brutto;
              SqlCmd.Parameters["@whdd_id"].Value = in_whdDet.Whdd_id;

              foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
                if (sqlParameter.Value == null) {
                  sqlParameter.Value = DBNull.Value;
                }
              }
              SqlCmd.ExecuteNonQuery();
            }
          }
          scope.Complete();
        }

      } catch (Exception) {

        throw;
      }

    }

    public void DeleteWhdDet(model.whdDetModel in_whdDet) {
      string sqlcommandWhdDet =
        "delete from whd_det where whdd_id = @whdd_id";
      try {
        using (TransactionScope scope = new TransactionScope()) {
          using (SqlConnection connection = new SqlConnection()) {
            connection.Open();
            using (SqlCommand SqlCmd = new SqlCommand(sqlcommandWhdDet, connection)) {
              SqlCmd.Parameters.Add("@whdd_id", SqlDbType.Int);

              SqlCmd.Parameters["@whdd_id"].Value = in_whdDet.Whdd_id;

              foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
                if (sqlParameter.Value == null) {
                  sqlParameter.Value = DBNull.Value;
                }
              }
              SqlCmd.ExecuteNonQuery();
            }
          }
          scope.Complete();
        }
      } catch (Exception) {

        throw;
      }
    }

    #endregion

  }
}
