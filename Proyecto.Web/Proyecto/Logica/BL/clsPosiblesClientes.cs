using System;
using System.Data;
using System.Data.SqlClient;
using Proyecto.Logica.Models;

namespace Proyecto.Logica.BL
{
	public class clsPosiblesClientes
	{ 

	SqlConnection _SqlConnection = null;//Permite establecer comunicación con la base de datos
	SqlCommand _SqlCommand = null;//Permite ejecutaar comandos SQL
	SqlDataAdapter _SqlDataAdapter = null;// Permite adaptar un conjunto de datos SQL 
	string stConexion = string.Empty;//Cadena de conexion

	public clsPosiblesClientes()
	{
		clsConexion obclsConexion = new clsConexion();
		stConexion = obclsConexion.getConexion();
	}
		/// <summary>
		/// Consulta Posibles Clientes
		/// </summary>
		/// <returns>Registros Posibles Clientes</returns>
		public DataSet getConsultarPosiblesClientes()
		{
			try
			{

				DataSet dsConsulta = new DataSet();

				_SqlConnection = new SqlConnection(stConexion);
				_SqlConnection.Open();

				_SqlCommand = new SqlCommand("spConsultarPosiblesClientes", _SqlConnection);
				_SqlCommand.CommandType = CommandType.StoredProcedure;

				_SqlCommand.ExecuteNonQuery();

				_SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
				_SqlDataAdapter.Fill(dsConsulta);

				return dsConsulta;

			}
			catch (Exception ex) { throw ex; }
			finally { _SqlConnection.Close(); }

		}

		internal string setAdministarPosiblesClientes(Models.ClsPosiblesClientes obClsPosiblesClientesModels, int inOpcion)
		{
			throw new NotImplementedException();
		}
	}
}