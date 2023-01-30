using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Web.Logica.Clases
{
    public class Oficinas
    {
        string stConexion = "";
        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
        SqlDataAdapter sqlDataAdapter = null;
        public Oficinas()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.stGetConexion();
        }
        public string create(long OFI_OFICINA_ID, string OFI_NOMBRE, long OFI_CORRESPONSAL_ID)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("CrearOficina", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@OFI_OFICINA_ID", OFI_OFICINA_ID));
                sqlCommand.Parameters.Add(new SqlParameter("@OFI_NOMBRE", OFI_NOMBRE));
                sqlCommand.Parameters.Add(new SqlParameter("@OFI_CORRESPONSAL_ID", OFI_CORRESPONSAL_ID));
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
        public DataSet consultar(long OFI_OFICINA_ID)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ConsultarOficina", sqlConnection);
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
        public string actualizar(long OFI_OFICINA_ID, string OFI_NOMBRE, long OFI_CORRESPONSAL_ID)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ActualizarOficina", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;


                sqlCommand.Parameters.Add(new SqlParameter("@OFI_OFICINA_ID", OFI_OFICINA_ID));
                sqlCommand.Parameters.Add(new SqlParameter("@OFI_NOMBRE", OFI_NOMBRE));
                sqlCommand.Parameters.Add(new SqlParameter("@OFI_CORRESPONSAL_ID", OFI_CORRESPONSAL_ID));

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
        public string eliminar(long OFI_OFICINA_ID)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("EliminarOficina", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@OFI_OFICINA_ID", OFI_OFICINA_ID));

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
        public DataSet consultarGirosXOfi()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ConsultarGirosOficina", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

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
