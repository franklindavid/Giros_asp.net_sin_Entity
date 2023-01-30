using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Web.Logica.Clases
{
    public class Corresponsales
    {
        string stConexion = "";
        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
        SqlDataAdapter sqlDataAdapter = null;
        public Corresponsales()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.stGetConexion();
        }
        public string create(long COR_CORRESPONSAL_ID, string COR_NOMBRE)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("CrearCorresponsal", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@COR_CORRESPONSAL_ID", COR_CORRESPONSAL_ID));
                sqlCommand.Parameters.Add(new SqlParameter("@COR_NOMBRE", COR_NOMBRE));
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
        public DataSet consultar(long COR_CORRESPONSAL_ID)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ConsultarCorresponsal", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@COR_CORRESPONSAL_ID", COR_CORRESPONSAL_ID));

                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        public string actualizar(long COR_CORRESPONSAL_ID, string COR_NOMBRE)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("ActualizarCorresponsal", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;


                sqlCommand.Parameters.Add(new SqlParameter("@COR_CORRESPONSAL_ID", COR_CORRESPONSAL_ID));
                sqlCommand.Parameters.Add(new SqlParameter("@COR_NOMBRE", COR_NOMBRE));

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
        public string eliminar(long COR_CORRESPONSAL_ID)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("EliminarCorresponsal", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@COR_CORRESPONSAL_ID", COR_CORRESPONSAL_ID));

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

        }

   
   }
