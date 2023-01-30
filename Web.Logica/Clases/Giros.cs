using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Web.Logica.Clases
{
    public class Giros
    {
        string stConexion = "";
        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
        SqlDataAdapter sqlDataAdapter = null;
        public Giros()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.stGetConexion();
        }
        public string create(long GIR_GIRO_ID, string GIR_RECIBO, long GIR_OFICINA_ID)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("CrearGiro", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@GIR_GIRO_ID", GIR_GIRO_ID));
                sqlCommand.Parameters.Add(new SqlParameter("@GIR_RECIBO", GIR_RECIBO));
                sqlCommand.Parameters.Add(new SqlParameter("@GIR_OFICINA_ID", GIR_OFICINA_ID));
                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@MENSAJE";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();
                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        public DataSet consultar(long GIR_GIRO_ID)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ConsultarGiro", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@GIR_GIRO_ID", GIR_GIRO_ID));

                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        public string actualizar(long GIR_GIRO_ID, string GIR_RECIBO, long GIR_OFICINA_ID)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ActualizarGiro", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;


                sqlCommand.Parameters.Add(new SqlParameter("@GIR_GIRO_ID", GIR_GIRO_ID));
                sqlCommand.Parameters.Add(new SqlParameter("@GIR_RECIBO", GIR_RECIBO));
                sqlCommand.Parameters.Add(new SqlParameter("@GIR_OFICINA_ID", GIR_OFICINA_ID));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@MENSAJE";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        public string eliminar(long GIR_GIRO_ID)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("EliminarGiro", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@GIR_GIRO_ID", GIR_GIRO_ID));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@MENSAJE";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        ///
        public DataSet consultarOficinaGiro(string OFI_OFICINA_ID)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ConsultarOficinaGiro", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@OFI_OFICINA_ID", OFI_OFICINA_ID));

                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
    }
}
