using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
	public class clsEstadoTarea
	{

		SqlConnection _SqlConnection = null;//Permite establecer comunicación con la base de datos
		SqlCommand _SqlCommand = null;//Permite ejecutaar comandos SQL
		SqlDataAdapter _SqlDataAdapter = null;// Permite adaptar un conjunto de datos SQL 
		string stConexion = string.Empty;//Cadena de conexion

		SqlParameter _SqlParameter = null;
		public clsEstadoTarea()
		{
			clsConexion obclsConexion = new clsConexion();
			stConexion = obclsConexion.getConexion();
		}
		/// <summary>
		/// Consulta Estado Tareas
		/// </summary>
		/// <returns>Registros de estado de las tareas</returns>
		public DataSet getConsultarEstadoTareas()
		{
			try
			{
				DataSet dsConsulta = new DataSet();

				_SqlConnection = new SqlConnection(stConexion);
				_SqlConnection.Open();

				_SqlCommand = new SqlCommand("spConsultarEstadoTareas", _SqlConnection);
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