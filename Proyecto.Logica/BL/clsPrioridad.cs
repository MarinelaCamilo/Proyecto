using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
	public class clsPrioridad
	{
		SqlConnection _SqlConnection = null;//Permite establecer comunicación con la base de datos
		SqlCommand _SqlCommand = null;//Permite ejecutaar comandos SQL
		SqlDataAdapter _SqlDataAdapter = null;// Permite adaptar un conjunto de datos SQL 
		string stConexion = string.Empty;//Cadena de conexion

		SqlParameter _SqlParameter = null;
		public clsPrioridad()
		{
			clsConexion obclsConexion = new clsConexion();
			stConexion = obclsConexion.getConexion();
		}
		/// <summary>
		/// Consulta Prioridad
		/// </summary>
		/// <returns>Registros de Prioridad</returns>
		public DataSet getConsultarPrioridad()
		{
			try
			{
				DataSet dsConsulta = new DataSet();

				_SqlConnection = new SqlConnection(stConexion);
				_SqlConnection.Open();

				_SqlCommand = new SqlCommand("stConsultarPrioridad", _SqlConnection);
				_SqlCommand.CommandType = CommandType.StoredProcedure;

				_SqlCommand.ExecuteNonQuery();

				_SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
				_SqlDataAdapter.Fill(dsConsulta);

				return dsConsulta;

			}
			catch (Exception ex) { throw ex; }
			finally { _SqlConnection.Close(); }
		}
	}
}
