using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wh_mgmt.dataAccess {
  class trhMstrDataAccess {
    //TRANSACTION HISTORY MASTER DATA ACCESS

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
    public void CreateTrhMstr(SqlConnection connection, 
                              model.whdMstrModel in_whd_mstr,
                              string in_tr_type) {

      string sqlcommand = 
        "insert into trhMstr " +
        "(trh_docid, trh_eff_date, trh_tr_type) " +
        "values " +
        "(@trh_docid, @trh_eff_date, @trh_tr_type)";

      if (connection != null && connection.State == ConnectionState.Closed) {
        try {
          using (SqlCommand SqlCmd = new SqlCommand(sqlcommand, connection)) {
            SqlCmd.Parameters.Add("@trh_docid", SqlDbType.Int);
            SqlCmd.Parameters.Add("@trh_eff_date", SqlDbType.DateTime);
            SqlCmd.Parameters.Add("@trh_ty_type", SqlDbType.NVarChar);

            SqlCmd.Parameters["@trh_docid"].Value = in_whd_mstr.Whdm_id;
            SqlCmd.Parameters["@trh_eff_date"].Value = DateTime.UtcNow;
            SqlCmd.Parameters["trh_tr_type"].Value = in_tr_type;

            foreach (SqlParameter sqlParameter in SqlCmd.Parameters) {
              if (sqlParameter.Value == null) {
                sqlParameter.Value = DBNull.Value;
              }
            }

            SqlCmd.ExecuteNonQuery();
          }
        } catch (Exception ex) {

          throw;
        }

      }
    }

    #endregion
  }
}
