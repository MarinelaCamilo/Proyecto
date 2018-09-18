using System;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto.Logica.BL
{
	public class clsUsuarios
	{
		SqlConnection _SqlConnection = null;//Permite establecer comunicación con la base de datos
		SqlCommand _SqlCommand = null;//Permite ejecutaar comandos SQL
		SqlDataAdapter _SqlDataAdapter = null;// Permite adaptar un conjunto de datos SQL 
		string stConexion = string.Empty;//Cadena de conexion

		public clsUsuarios()
		{

			clsConexion obclsConexion = new clsConexion();
			stConexion = obclsConexion.getConexion();
		}
		/// <summary>
		/// Valida Ususario
		/// </summary>
		/// <param name="obclsUsuarios">Objeto Usuario</param>
		/// <returns>Confirmación</returns>
		public bool getValidarUsuario(Models.clsUsuarios obclsUsuarios)
		{
			try
			{

				DataSet dsConsulta = new DataSet();

				_SqlConnection = new SqlConnection(stConexion);
				_SqlConnection.Open();

				_SqlCommand = new SqlCommand("spConsultarUsuario", _SqlConnection);
				_SqlCommand.CommandType = CommandType.StoredProcedure;

				_SqlCommand.Parameters.Add(new SqlParameter("@CLogin", obclsUsuarios.stLogin));
				_SqlCommand.Parameters.Add(new SqlParameter("@CPassword", obclsUsuarios.stPassword));

				_SqlCommand.ExecuteNonQuery();

				_SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
				_SqlDataAdapter.Fill(dsConsulta);

				if (dsConsulta.Tables[0].Rows.Count > 0) return true;
				else return false;
				
			}
		catch(Exception ex) {throw ex; }
		finally { _SqlConnection.Close(); }

		}
	}
}
